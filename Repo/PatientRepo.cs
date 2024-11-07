using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsApp1.Model;


namespace WinFormsApp1.Repo
{
    public class PatientRepo
    {
        private readonly string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=PatientRegister;Integrated Security=True;Connect Timeout=30;Encrypt=False";


        public List<Patient> GetPatients()
        {
            var patients = new List<Patient>();
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string sql = "SELECT * FROM NewClient ORDER BY id DESC";
                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Patient patient = new Patient();
                                patient.id = reader.GetInt32(0);
                                patient.firstName = reader.GetString(1);
                                patient.lastName = reader.GetString(2);
                                patient.contactNumber
                                 = reader.GetString(3); // Assuming contact number is at index

                                patient.height = reader.GetDecimal(5);
                                // patient.weight = reader.GetDecimal(5);
                                // Assuming height is at index 5
                                patient.address = reader.GetString(6);
                                patient.email = reader.GetString(7);
                                patient.city = reader.GetString(8);
                                patient.state = reader.GetString(9);
                                patient.postalCode = reader.GetString(10);



                                patient.gender = reader.GetString(12);
                                patient.maritalStatus = reader.GetString(13);
                                patients.Add(patient);

                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception:" + ex.ToString());
            }


            return patients;
        }
        public Patient? GetPatient(int id)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string sql = "SELECT * FROM NewClient WHERE PatientID=@id";
                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@id", id);
                        using (SqlDataReader reader = command.ExecuteReader())

                        {
                            if (reader.Read())
                            {
                                Patient patient = new Patient();
                                patient.id = reader.GetInt32(0);
                                patient.firstName = reader.GetString(1);
                                patient.lastName = reader.GetString(2);
                                patient.contactNumber
                                 = reader.GetString(3); // Assuming contact number is at index

                                patient.height = reader.GetDecimal(5);
                                // patient.weight = reader.GetDecimal(5);
                                // Assuming height is at index 5
                                patient.address = reader.GetString(6);
                                patient.email = reader.GetString(7);
                                patient.city = reader.GetString(8);
                                patient.state = reader.GetString(9);
                                patient.postalCode = reader.GetString(10);



                                patient.gender = reader.GetString(12);
                                patient.maritalStatus = reader.GetString(13);

                                return patient;

                            }

                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception:" + ex.ToString());
            }

            return null;
        }

        public void CreatePatient(Patient patient)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string sql = "INSERT INTO NewClient (FirstName, LastName, ContactNumber, Weight, Height, Address, Email, City, State, PostalCode, DOB, Gender, MaritalStatus) VALUES (@FirstName, @LastName, @ContactNumber, @Weight, @Height, @Address, @Email, @City, @State, @PostalCode, @DOB, @Gender, @MaritalStatus)";

                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        // Declare variables and assign values

                        // Add parameters with values
                        command.Parameters.AddWithValue("@FirstName", patient.firstName);
                        command.Parameters.AddWithValue("@LastName", patient.lastName);
                        command.Parameters.AddWithValue("@ContactNumber", patient.contactNumber);
                        command.Parameters.AddWithValue("@Weight", patient.weight);
                        command.Parameters.AddWithValue("@Height", patient.height);
                        command.Parameters.AddWithValue("@Address", patient.address);
                        command.Parameters.AddWithValue("@Email", patient.email);
                        command.Parameters.AddWithValue("@City", patient.city);
                        command.Parameters.AddWithValue("@State", patient.state);
                        command.Parameters.AddWithValue("@PostalCode", patient.postalCode);
                        command.Parameters.AddWithValue("@DOB", patient.dob);
                        command.Parameters.AddWithValue("@Gender", patient.gender);
                        command.Parameters.AddWithValue("@MaritalStatus", patient.maritalStatus);

                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception:" + ex.ToString());

            }
        }

        public void UpdatePatient(Patient patient)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string sql = @"UPDATE NewClient SET 
                          FirstName = @FirstName, 
                          LastName = @LastName, 
                          ContactNumber = @ContactNumber, 
                          Weight = @Weight, 
                          Height = @Height, 
                          Address = @Address, 
                          Email = @Email, 
                          City = @City, 
                          State = @State, 
                          PostalCode = @PostalCode, 
                          DOB = @DOB, 
                          Gender = @Gender, 
                          MaritalStatus = @MaritalStatus WHERE PatientID = @id";
                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        // Declare variables and assign values
                        command.Parameters.AddWithValue("@id", patient.id);
                        // Add parameters with values
                        command.Parameters.AddWithValue("@FirstName", patient.firstName);
                        command.Parameters.AddWithValue("@LastName", patient.lastName);
                        command.Parameters.AddWithValue("@ContactNumber", patient.contactNumber);
                        command.Parameters.AddWithValue("@Weight", patient.weight);
                        command.Parameters.AddWithValue("@Height", patient.height);
                        command.Parameters.AddWithValue("@Address", patient.address);
                        command.Parameters.AddWithValue("@Email", patient.email);
                        command.Parameters.AddWithValue("@City", patient.city);
                        command.Parameters.AddWithValue("@State", patient.state);
                        command.Parameters.AddWithValue("@PostalCode", patient.postalCode);
                        command.Parameters.AddWithValue("@DOB", patient.dob);
                        command.Parameters.AddWithValue("@Gender", patient.gender);
                        command.Parameters.AddWithValue("@MaritalStatus", patient.maritalStatus);

                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception:" + ex.ToString());

            }

        }
        public void DeletePatient(int id)

        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string sql = "DELETE FROM NewClient WHERE PatientID=@id";
                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@id", id);
                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception:" + ex.ToString());

            }

        }
    }
}
