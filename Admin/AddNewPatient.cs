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

namespace PatientManagementSystem_RollBased.Forms.Admin
{
    public partial class AddNewPatient : Form
    {
        public AddNewPatient()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text) || string.IsNullOrWhiteSpace(textBox3.Text))
            {
                MessageBox.Show("Patient Name and Contact are required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // Connection string
                string connectionString = "YourConnectionStringHere";

                // Stored Procedure Call
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    using (SqlCommand command = new SqlCommand("AddNewPatient", connection))
                    {
                        command.CommandType = System.Data.CommandType.StoredProcedure;

                        // Add parameters
                        command.Parameters.AddWithValue("@PatientName", textBox1.Text);
                        command.Parameters.AddWithValue("@Address", textBox2.Text);
                        command.Parameters.AddWithValue("@Contact", textBox3.Text);
                        command.Parameters.AddWithValue("@MedicalHistory", textBox4.Text);
                        command.Parameters.AddWithValue("@Age", int.TryParse(textBox5.Text, out int age) ? age : (object)DBNull.Value);

                        // Open connection and execute
                        connection.Open();
                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Patient added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            //ClearFields();
                        }
                        else
                        {
                            MessageBox.Show("Failed to add patient. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
}
