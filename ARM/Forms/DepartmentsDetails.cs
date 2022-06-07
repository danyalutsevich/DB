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
                    }

                }
            }

        }

        private void listBoxDepartments_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(listBoxDepartments.SelectedIndex == -1)
            {
                return;
            }

            var id = ((ORM.Departments)listBoxDepartments.SelectedItem).Id.ToString();

            labelDepId.Text = id;

            // this query gets the amount of managers in defined department
            var MainManagersCount = @$"SELECT COUNT(*) FROM Managers WHERE Id_main_dep ='{id}'";
            
            var SecManagersCount = @$"SELECT COUNT(*) FROM Managers WHERE Id_sec_dep ='{id}'";

            using (SqlCommand command = new SqlCommand(MainManagersCount, connection))
            {
                labelAmountOfMainManagers.Text = command.ExecuteScalar().ToString();
                command.CommandText = SecManagersCount;
                labelAmountOfSecManagers.Text = command.ExecuteScalar().ToString();
            }


        }
    }
}
