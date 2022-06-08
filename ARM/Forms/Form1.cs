using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using Microsoft.Extensions.Configuration;

namespace ARM
{
    public partial class Form1 : Form
    {
        public SqlConnection connection;
        public SqlConnection GoogleCloud;


        public Form1()
        {
            InitializeComponent();
            connection = new SqlConnection(Program.Configuration.GetConnectionString("Database1"));
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            try
            {
                connection.Open();
                labelConnectionStatus.Text = "Connected";
                labelConnectionStatus.ForeColor = System.Drawing.Color.Green;

            }
            catch (SqlException ex)
            {
                labelConnectionStatus.Text = "Disconnected";
                labelConnectionStatus.ForeColor = System.Drawing.Color.Red;
                MessageBox.Show(ex.Message);
                return;

            }

            using (SqlCommand command = new SqlCommand(@"SELECT COUNT(*) FROM Departments", connection))
            {
                command.CommandText = @"SELECT COUNT(*) FROM Departments";
                labelDepartmentsCount.Text = command.ExecuteScalar().ToString();

                command.CommandText = @"SELECT COUNT(*) FROM Managers";
                labelManagersCount.Text = command.ExecuteScalar().ToString();
                
                command.CommandText = @"SELECT COUNT(*) FROM Products";
                labelProductsCount.Text = command.ExecuteScalar().ToString();

                command.CommandText = @"SELECT COUNT(*) FROM Sales";
                labelSalesCount.Text = command.ExecuteScalar().ToString();

            }




        }

        private void buttonDepDetails_Click(object sender, EventArgs e)
        {
            new Forms.DepartmentsDetails().ShowDialog(this);
        }

        private void labelDepartments_Click(object sender, EventArgs e)
        {

        }

        private void label1_DoubleClick(object sender, EventArgs e)
        {
            MessageBox.Show(Program.Configuration.GetSection("Params").GetSection("par1").Value);
        }

        private void buttonCloudConnect_Click(object sender, EventArgs e)
        {

            GoogleCloud = new SqlConnection(Program.Configuration.GetConnectionString("GoogleCloud"));

            try
            {
                GoogleCloud.Open();
                labelGoogleCloud.ForeColor = Color.Green;
            }
            catch(SqlException ex)
            {
                labelGoogleCloud.ForeColor = Color.Red;
                MessageBox.Show(ex.Message);
            }

        }
    }
}
