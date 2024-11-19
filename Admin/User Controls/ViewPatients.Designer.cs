namespace PatientManagementSystem_RollBased.Forms.Admin.User_Controls
{
    partial class ViewPatients
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
            dgvViewPatients = new DataGridView();
            btnAddPatient = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvViewPatients).BeginInit();
            SuspendLayout();
            // 
            // dgvViewPatients
            // 
            dgvViewPatients.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvViewPatients.Location = new Point(25, 297);
            dgvViewPatients.Name = "dgvViewPatients";
            dgvViewPatients.RowHeadersWidth = 62;
            dgvViewPatients.Size = new Size(1006, 425);
            dgvViewPatients.TabIndex = 0;
            // 
            // btnAddPatient
            // 
            btnAddPatient.Location = new Point(68, 37);
            btnAddPatient.Name = "btnAddPatient";
            btnAddPatient.Size = new Size(112, 34);
            btnAddPatient.TabIndex = 1;
            btnAddPatient.Text = "Add New";
            btnAddPatient.UseVisualStyleBackColor = true;
            btnAddPatient.Click += btnAddPatient_Click;
            // 
            // ViewPatients
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btnAddPatient);
            Controls.Add(dgvViewPatients);
            Name = "ViewPatients";
            Size = new Size(1069, 749);
            ((System.ComponentModel.ISupportInitialize)dgvViewPatients).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvViewPatients;
        private Button btnAddPatient;
    }
}
