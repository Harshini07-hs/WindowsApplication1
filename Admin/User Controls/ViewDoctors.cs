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
    public partial class ViewDoctors : UserControl
    {
        public ViewDoctors()
        {
            InitializeComponent();
            LoadDoctors();

        }
        private void LoadDoctors()

        {
            UserBLL userBLL = new UserBLL();

            DataTable dtDoctors = userBLL.GetAllDoctors();
            dgvViewDoctors.DataSource = dtDoctors;
        }
    }
}
