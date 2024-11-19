using PatientManagementSystem_RollBased.BLL;
using PatientManagementSystem_RollBased.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using PatientManagementSystem_RollBased.DAL;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace PatientManagementSystem_RollBased.Forms.Admin.User_Controls
{
    public partial class ViewAdminAppointmentsControl : UserControl
    {
        public ViewAdminAppointmentsControl()
        {
            InitializeComponent();
            LoadAppointments();
            //ShowAppointments();
        }

        private void LoadAppointments()

        {
            UserBLL userBLL = new UserBLL();

            DataTable dtAppointments = userBLL.GetAllAppointment();
            dgvAdminAppointments.DataSource = dtAppointments;
        }







        private void dgvAdminAppointments_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvAdminAppointments_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                // Check if the clicked column is the "btnCancel" column
                if (dgvAdminAppointments.Columns[e.ColumnIndex].Name == "btnCancel")
                {
                    try
                    {
                        // Retrieve the AppointmentID from the selected row
                        var appointmentIdCell = dgvAdminAppointments.Rows[e.RowIndex].Cells["AppointmentID"].Value;
                        var statusCell = dgvAdminAppointments.Rows[e.RowIndex].Cells["Status"].Value;

                        // Validate that the AppointmentID and Status cells are not null
                        if (appointmentIdCell == null || statusCell == null)
                        {
                            MessageBox.Show("Invalid appointment data. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }

                        int appointmentId = Convert.ToInt32(appointmentIdCell);
                        string status = statusCell.ToString();

                        // Check if the appointment is already cancelled
                        if (status.Equals("Cancelled", StringComparison.OrdinalIgnoreCase))
                        {
                            MessageBox.Show("This appointment has already been cancelled.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return;
                        }

                        // Confirm cancellation
                        DialogResult result = MessageBox.Show(
                            "Are you sure you want to cancel this appointment?",
                            "Cancel Appointment",
                            MessageBoxButtons.YesNo,
                            MessageBoxIcon.Warning);

                        if (result == DialogResult.Yes)
                        {
                            UserBLL userBLL = new UserBLL();
                            // Call the method to cancel the appointment
                            bool isCancelled = userBLL.CancelAppointment(appointmentId);

                            if (isCancelled)
                            {
                                MessageBox.Show("Appointment cancelled successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                LoadAppointments(); // Refresh the DataGridView
                            }
                            else
                            {
                                MessageBox.Show("Failed to cancel the appointment.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
}




