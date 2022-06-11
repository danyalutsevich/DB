using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ARM.Forms
{
    public partial class Products : Form
    {
        public Products()
        {
            InitializeComponent();
            products = new();
        }

        private SqlConnection connection;

        private int page = 1;
        private int perpage = 5;
        private bool order = true;

        private List<ORM.Products> products;


        private void Products_Load(object sender, EventArgs e)
        {
            if (Owner is Form1 owner)
            {
                connection = owner.connection;
            }
            else
            {
                MessageBox.Show("Invalid form Owner");
                return;
            }

            comboBoxOrderBy.Items.Add("Id");
            comboBoxOrderBy.Items.Add("Name");
            comboBoxOrderBy.Items.Add("Price");

            UpdateList();
            UpdateListBox();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            page++;
            var maxPages = Math.Ceiling((float)products.Count / perpage) - 1;
            if (page > maxPages)
            {
                page = (int)maxPages;
            }
            labelPage.Text = (page + 1).ToString();
            UpdateListBox();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            page--;
            if (page < 0) page = 0;
            labelPage.Text = (page + 1).ToString();
            UpdateListBox();
        }

        
        private void UpdateListBox() // opens the selected page
        {
            listBoxProducts.Items.Clear();
            
            UpdateProductsOrder();
            
            var display = products.Skip(page * perpage).Take(perpage).ToList();

            foreach (var product in display)
            {
                listBoxProducts.Items.Add(product);
            }
        } 

        private void UpdateList() // request to database, updates local List with products 
        {
            products.Clear();

            using (var command = new SqlCommand("SELECT * FROM Products", connection))
            {
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        products.Add(new ORM.Products(reader));
                    }
                }
            }
        } 

        private void UpdateProductsOrder() // sets the local List to the selected order
        {
            if (comboBoxOrderBy.Text == "Name")
            {
                if (order)
                {
                    products = products.OrderBy(p => p.Name).ToList();
                }
                else
                {
                    products = products.OrderByDescending(p => p.Name).ToList();
                }
            }
            else if (comboBoxOrderBy.Text == "Price")
            {
                if (order)
                {
                    products = products.OrderBy(p => p.Price).ToList();
                }
                else
                {
                    products = products.OrderByDescending(p => p.Price).ToList();
                }
            }
            else if (comboBoxOrderBy.Text == "Id")
            {
                if (order)
                {
                    products = products.OrderBy(p => p.Id).ToList();
                }
                else
                {
                    products = products.OrderByDescending(p => p.Id).ToList();
                }
            }

        }

        private void comboBoxOrderBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateListBox();
        }

        private void textBoxPerPage_TextChanged(object sender, EventArgs e)
        {
            try
            {
                perpage = int.Parse(textBoxPerPage.Text);
                if (perpage > products.Count)
                {
                    perpage = products.Count;
                }

            }
            catch
            {
                MessageBox.Show($"Enter value beetween 1 and {products.Count}");
            }

        }

        private void buttonOrder_Click(object sender, EventArgs e)
        {

            if (order)
            {
                order = false;
                buttonOrder.Text = "🠉";
            }
            else
            {
                order = true;
                buttonOrder.Text = "🠋";
            }
            UpdateListBox();
        }

        private void listBoxProducts_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (listBoxProducts.SelectedIndex == -1)
            {
                return;
            }

            if (listBoxProducts.SelectedItem is ORM.Products product)
            {

                labelProductID.Text = product?.Id.ToString();

                textBoxName.Text = product?.Name;

                textBoxPrice.Text = product?.Price.ToString();

            }
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            var index = listBoxProducts.SelectedIndex;
            using (var command = new SqlCommand("UPDATE Products SET Name = @name, Price = @price WHERE Id = @id", connection))
            {
                command.Parameters.Add("@name", SqlDbType.NVarChar).Value = textBoxName.Text;
                command.Parameters.Add("@price", SqlDbType.Float).Value = double.Parse(textBoxPrice.Text);
                command.Parameters.Add("@id", SqlDbType.UniqueIdentifier).Value = Guid.Parse(labelProductID.Text);

                var res = MessageBox.Show($"Confirm name {textBoxName.Text}, price {textBoxPrice.Text}, id {labelProductID.Text}", "Confirm", MessageBoxButtons.YesNo);
                if (res == DialogResult.Yes)
                {
                    command.ExecuteNonQueryAsync()
                        .ContinueWith(t => UpdateList())
                        .ContinueWith(t => UpdateListBox())
                        .ContinueWith(t => MessageBox.Show("Updated"))
                        .ContinueWith(t => listBoxProducts.SelectedIndex = index);
                }
            }

        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {

            if (listBoxProducts.SelectedIndex == -1)
            {
                return;
            }

            if (listBoxProducts.SelectedItem is ORM.Products product)
            {

                var res = MessageBox.Show($"Delete product:\n {product.Name} {product.Price}?", "Confirm", MessageBoxButtons.YesNo);

                if (res == DialogResult.No)
                {
                    return;
                }


                using (var command = new SqlCommand("DELETE FROM Products WHERE id = @id", connection))
                {
                    command.Parameters.AddWithValue("@id", Guid.Parse(labelProductID.Text));
                    command.ExecuteNonQueryAsync()
                        .ContinueWith(t => UpdateList())
                        .ContinueWith(t => UpdateListBox())
                        .ContinueWith(t => MessageBox.Show("Deleted"));
                }

                labelProductID.Text = "";

                textBoxName.Text = "";

                textBoxPrice.Text = "";
            }

        }

        private void buttonCreate_Click(object sender, EventArgs e)
        {

            if (String.IsNullOrEmpty(textBoxCreateName.Text))
            {
                MessageBox.Show("Enter name");
                return;
            }
            if (String.IsNullOrEmpty(textBoxCreatePrice.Text))
            {
                MessageBox.Show("Enter price");
                return;
            }

            if (products.Any(p => p.Name.Equals(textBoxCreateName.Text)))
            {
                MessageBox.Show("Product with this name already exists");
                return;
            }

            double price;

            try
            {
                price = double.Parse(textBoxCreatePrice.Text);
            }
            catch
            {
                MessageBox.Show("Enter valid price (number)");
                return;
            }

            using (var command = new SqlCommand("INSERT INTO Products (Name, Price, Id) VALUES (@name, @price, NEWID())", connection))
            {
                command.Parameters.Add("@name", SqlDbType.NVarChar).Value = textBoxCreateName.Text;
                command.Parameters.Add("@price", SqlDbType.Float).Value = price;

                command.ExecuteNonQueryAsync()
                    .ContinueWith(t =>   // This takes ListBox to the page with created product
                    {
                        UpdateProductsOrder();
                        
                        var created = products.Where(p => p.Name.Equals(textBoxCreateName.Text)).FirstOrDefault();

                        page = products.IndexOf(created) / perpage;
                        
                        textBoxCreateName.Text = "";
                        textBoxCreatePrice.Text = "";

                    })
                    .ContinueWith(t => UpdateList())
                    .ContinueWith(t => UpdateListBox())
                    .ContinueWith(t => MessageBox.Show("Created"));
            }
        }

       
    }
}
