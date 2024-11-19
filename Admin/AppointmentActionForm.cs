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
    public partial class AppointmentActionForm : Form
    {
        private int _appointmentID;

        public AppointmentActionForm(int appointmentID, string patientName, string currentStatus)
        {
            InitializeComponent();
            _appointmentID = appointmentID;
            lblPatientName.Text = $"Patient: {patientName}";
           lblCurrentStatus.Text = $"Current Status: {currentStatus}";
        }
        public AppointmentActionForm()
        {
            InitializeComponent();
        }

        private void btnCancelAppointment_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("Are you sure you want to cancel this appointment?",
                                                "Confirm Cancellation",
                                                MessageBoxButtons.YesNo,
                                                MessageBoxIcon.Question);

            if (confirmResult == DialogResult.Yes)
            {
                // Call the stored procedure to cancel the appointment
                UpdateAppointmentStatus(_appointmentID, null, "Cancelled");
            }
        }

        private void btnRescheduleAppointment_Click(object sender, EventArgs e)
        {
            if (dateTimePicker1.Value.Date < DateTime.Now.Date)
            {
                MessageBox.Show("Please select a valid future date.", "Invalid Date", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Call the stored procedure to update the appointment date
            UpdateAppointmentStatus(_appointmentID, dateTimePicker1.Value, null);
        }
       
        private void UpdateAppointmentStatus(int appointmentID, DateTime? newDate, string newStatus)
        {
            string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=PatientRegister;Integrated Security=True;";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand("UpdateAppointmentStatus", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        // Add parameters
                        command.Parameters.AddWithValue("@AppointmentID", appointmentID);
                        command.Parameters.AddWithValue("@NewDate", (object)newDate ?? DBNull.Value);
                        command.Parameters.AddWithValue("@NewStatus", (object)newStatus ?? DBNull.Value);

                        // Execute the stored procedure
                        command.ExecuteNonQuery();

                        MessageBox.Show("Appointment updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error updating appointment: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

