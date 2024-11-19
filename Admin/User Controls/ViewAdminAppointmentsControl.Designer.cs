namespace PatientManagementSystem_RollBased.Forms.Admin.User_Controls
{
    partial class ViewAdminAppointmentsControl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dgvAdminAppointments = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvAdminAppointments).BeginInit();
            SuspendLayout();
            // 
            // dgvAdminAppointments
            // 
            dgvAdminAppointments.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAdminAppointments.Location = new Point(3, 23);
            dgvAdminAppointments.Name = "dgvAdminAppointments";
            dgvAdminAppointments.RowHeadersWidth = 62;
            dgvAdminAppointments.Size = new Size(1098, 565);
            dgvAdminAppointments.TabIndex = 0;
            dgvAdminAppointments.CellClick += dgvAdminAppointments_CellClick;
            dgvAdminAppointments.CellDoubleClick += dgvAdminAppointments_CellDoubleClick;
            // 
            // ViewAdminAppointmentsControl
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(dgvAdminAppointments);
            Name = "ViewAdminAppointmentsControl";
            Size = new Size(1119, 607);
            ((System.ComponentModel.ISupportInitialize)dgvAdminAppointments).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvAdminAppointments;
    }
}
