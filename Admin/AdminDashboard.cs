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
using PatientManagementSystem_RollBased.Forms.Doctor.User_Controls;
using PatientManagementSystem_RollBased.Forms.Admin.User_Controls;

namespace PatientManagementSystem_RollBased.Forms.Admin
{
    public partial class AdminDashboard : Form
    {
        public AdminDashboard()
        {
            InitializeComponent();
            LoadControl();
        }

        private void linkLogout_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Main main = new Main();
            main.Show();
        }

        private void btnAppointment_Click(object sender, EventArgs e)
        {
            ViewAdminAppointmentsControl viewAdminAppointmentsControl = new ViewAdminAppointmentsControl();
            LoadControl(viewAdminAppointmentsControl);
        }

        private void LoadControl(UserControl control)
        {

            panel2.Controls.Clear();
            //panelContent.Controls.Clear(); // Clear existing content
            control.Dock = DockStyle.Fill; // Make the control fill the panel
            panel2.Controls.Add(control);
            /* panelContent.Controls.Add(control);*/ // Add the new control to the panel
        }


      private void btnPatients_Click(object sender,EventArgs e)
        {
            LoadControl(new ViewPatients());
        }

        private void btnDoctors_Click(object sender, EventArgs e)
        {
            LoadControl(new ViewDoctors());
        }

        private void addPatientsToolStripMenuItem_Click(object sender,EventArgs e)
        {
            this.Hide();
            AddNewPatient addNewPatient = new AddNewPatient();
            addNewPatient.Show();

        }

    }
}
