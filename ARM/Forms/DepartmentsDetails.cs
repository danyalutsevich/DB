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
            buttonUpdate.Enabled = false;
            UpdateListBox();

        }

        private void UpdateListBox(bool updateList = false)
        {

            var index = listBoxDepartments.SelectedIndex;

            if (updateList)
            {





            }
            else
            {
                listBoxDepartments.Items.Clear();

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
            listBoxDepartments.SelectedIndex = index;
        }

        private void listBoxDepartments_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxDepartments.SelectedIndex == -1)
            {
                return;
            }

            var id = ((ORM.Departments)listBoxDepartments.SelectedItem).Id.ToString();

            labelDepId.Text = id;

            // this query gets the amount of main managers in defined department
            var MainManagersCount = @$"SELECT COUNT(*) FROM Managers WHERE Id_main_dep ='{id}'";

            // this query gets the amount of sec managers in defined department
            var SecManagersCount = @$"SELECT COUNT(*) FROM Managers WHERE Id_sec_dep ='{id}'";

            using (SqlCommand command = new SqlCommand(MainManagersCount, connection))
            {
                labelAmountOfMainManagers.Text = command.ExecuteScalar().ToString();
                command.CommandText = SecManagersCount;
                labelAmountOfSecManagers.Text = command.ExecuteScalar().ToString();
            }

            // Params
            string prepQuery = "SELECT COUNT(*) FROM Managers WHERE Id_sec_dep = @mid";

            using (SqlCommand command = new SqlCommand(prepQuery, connection))
            {
                command.Parameters.Add("@mid", SqlDbType.UniqueIdentifier);
                command.Parameters["@mid"].Value = Guid.Parse(id);

                labelSecManPar.Text = command.ExecuteScalar().ToString();
            }

            // Placeholder is not supported by sqlcommand





        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {




            buttonUpdate.Enabled = false;
            if (listBoxDepartments.SelectedIndex == -1)
            {
                MessageBox.Show("Select an index");
                return;
            }



            var id = ((ORM.Departments)listBoxDepartments.SelectedItem).Id.ToString();

            labelDepId.Text = id;

            var NewName = textBoxUpdate.Text;

            if (NewName.Length == 0)
            {
                MessageBox.Show("Enter Name");
                return;
            }

            // confirm update

            var res = MessageBox.Show("Apply changes?", "", MessageBoxButtons.YesNo);

            if (res == DialogResult.No)
            {
                return;
            }
            try
            {

                var query = "UPDATE Departments SET Name = @name WHERE id = @id";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.Add("@name", SqlDbType.NVarChar);
                    command.Parameters.Add("@id", SqlDbType.UniqueIdentifier);

                    command.Parameters["@name"].Value = NewName;
                    command.Parameters["@id"].Value = Guid.Parse(id);

                    command.ExecuteNonQuery();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show($"Update error {ex.Message}");
            }
                MessageBox.Show("Successfully updated");

            Task.Run(() => { UpdateListBox(); });

        }

        private void textBoxUpdate_TextChanged(object sender, EventArgs e)
        {
            if (textBoxUpdate.Text.Length == 0)
            {
                buttonUpdate.Enabled = false;
            }
            else
            {
                buttonUpdate.Enabled = true;
            }
        }
    }
}
