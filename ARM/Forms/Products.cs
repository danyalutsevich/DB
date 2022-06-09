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
            var maxPages = Math.Ceiling((float)products.Count / perpage);
            if (page > maxPages)
            {
                page = (int)maxPages;
            }
            labelPage.Text = page.ToString();
            UpdateListBox();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            page--;
            if (page < 0) page = 0;
            labelPage.Text = page.ToString();
            UpdateListBox();
        }

        private void UpdateListBox()
        {
            listBoxProducts.Items.Clear();
            List<ORM.Products> display = new List<ORM.Products>(); // products to display on listbox
            
            // order logic
            if (comboBoxOrderBy.Text == "Name")
            {
                if (order)
                {
                    display = products.OrderBy(p => p.Name).Skip(page * perpage).Take(perpage).ToList();
                }
                else
                {
                    display = products.OrderByDescending(p => p.Name).Skip(page * perpage).Take(perpage).ToList();
                }
            }
            else if (comboBoxOrderBy.Text == "Price")
            {
                if (order)
                {
                    display = products.OrderBy(p => p.Price).Skip(page * perpage).Take(perpage).ToList();
                }
                else
                {
                    display = products.OrderByDescending(p => p.Price).Skip(page * perpage).Take(perpage).ToList();
                }
            }
            else if (comboBoxOrderBy.Text == "Id")
            {
                if (order)
                {
                    display = products.OrderBy(p => p.Id).Skip(page * perpage).Take(perpage).ToList();
                }
                else
                {
                    display = products.OrderByDescending(p => p.Id).Skip(page * perpage).Take(perpage).ToList();
                }
            }

            foreach (var product in display)
            {
                listBoxProducts.Items.Add(product.Name + " " + product.Price.ToString());
            }
        }

        private void UpdateList()
        {
            listBoxProducts.Items.Clear();

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
    }
}
