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

namespace WinFormsApp1
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            this.textBox2.PasswordChar = '*';
        }

        // SqlConnection con = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=PatientRegister;Integrated Security=True;Connect Timeout=30;Encrypt=False"))

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                textBox2.UseSystemPasswordChar = false;
            }
            else
            {
                textBox2.UseSystemPasswordChar = true;
            }
        }

        //private void button1_Click(object sender, EventArgs e)
        //{
        //    if (textBox1.Text != "" && textBox2.Text != "")
        //    {
        //        string query = "select count(*) from User_SignUp where textbox2='" + textBox1.Text + "'and " + "textbox3='" + textBox2.Text + "'";
        //        con.Open();
        //        SqlCommand command = new SqlCommand(query, con);
        //        int v = (int)command.ExecuteScalar();
        //        if (v != 0)
        //        {
        //            MessageBox.Show("Error name or password", "Error!");
        //        }
        //        else
        //        {
        //            MessageBox.Show("Login Successful");
        //            textBox1.Text = "";
        //            textBox2.Text = "";
        //        }
        //    }
        //    else
        //    {
        //        MessageBox.Show("Fill in the blanks");
        //    }
        //}


        private void button1_Click(object sender, EventArgs e)
        {
            string username = textBox1.Text;
            string password = textBox2.Text;

            // Basic validation
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please enter username and password.");
                return;
            }

            // SQL query to check user credentials
            string query = "SELECT * FROM User_SignUp WHERE Name = @username AND Password = @password";

            try
            {
                using (SqlConnection con = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=PatientRegister;Integrated Security=True;Connect Timeout=30;Encrypt=False"))
                {
                    con.Open();

                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@username", username);
                        cmd.Parameters.AddWithValue("@password", password); // Note: This assumes plain text passwords. Consider hashing for security

                        SqlDataReader reader = cmd.ExecuteReader();

                        if (reader.HasRows)
                        {
                            // Successful login
                            MessageBox.Show("Login successful!");
                            // Redirect to the main form or perform other actions
                        }
                        else
                        {
                            MessageBox.Show("Invalid username or password.");
                        }

                        // reader.Close();
                        Menu menu = new Menu();
                        menu.Show();

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form2 form2 = new Form2();
            this.Hide();
            form2.Show();
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (textBox2.PasswordChar == '*')
            {
                textBox2.PasswordChar = '\0';
            }
            else
            {
                textBox2.PasswordChar = '*';
            }
        }
    }
}

