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

namespace ARM.Forms
{
    public partial class DepartmentsDetails : Form
    {

        private SqlConnection connection;
            
        public DepartmentsDetails()
        {
            InitializeComponent();
            connection = null!;

        }

        private void DepartmentsDetails_Load(object sender, EventArgs e)
        {
            connection = ((Form1)Owner).connection;

            using (SqlCommand command = new SqlCommand(@"SELECT * FROM Departments", connection))
            {
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        listBoxDepartments.Items.Add(new ORM.Departments { Id = reader.GetGuid("Id"), Name = reader.GetString("Name") });
                        //listBoxDepartments.Items.Add(reader["Name"]);
                    }

                }
            }

        }
    }
}
