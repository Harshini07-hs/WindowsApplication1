using PatientManagementSystem_RollBased.BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PatientManagementSystem_RollBased.Forms.Admin.User_Controls
{
    public partial class ViewPatients : UserControl
    {
        public ViewPatients()
        {
            InitializeComponent();
            LoadPatients();
        }

        private void LoadPatients()

        {
            UserBLL userBLL = new UserBLL();

            DataTable dtPatients = userBLL.GetAllPatients();
            dgvViewPatients.DataSource = dtPatients;
        }

        private void btnAddPatient_Click(object sender, EventArgs e)
        {

        }
    }
}
