namespace PatientManagementSystem_RollBased.Forms.Admin.User_Controls
{
    partial class ViewDoctors
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
            dgvViewDoctors = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvViewDoctors).BeginInit();
            SuspendLayout();
            // 
            // dgvViewDoctors
            // 
            dgvViewDoctors.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvViewDoctors.Location = new Point(69, 43);
            dgvViewDoctors.Name = "dgvViewDoctors";
            dgvViewDoctors.RowHeadersWidth = 62;
            dgvViewDoctors.Size = new Size(857, 487);
            dgvViewDoctors.TabIndex = 0;
            // 
            // ViewDoctors
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(dgvViewDoctors);
            Name = "ViewDoctors";
            Size = new Size(975, 576);
            ((System.ComponentModel.ISupportInitialize)dgvViewDoctors).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvViewDoctors;
    }
}
