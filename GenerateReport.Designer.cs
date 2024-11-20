namespace PatientManagementSystem_RollBased.Forms.Reports
{
    partial class GenerateReport
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblFromDate = new Label();
            lblToDate = new Label();
            dtpFromDate = new DateTimePicker();
            dtpToDate = new DateTimePicker();
            lblItemStatus = new Label();
            cmbItemStatus = new ComboBox();
            btnGenerateReport = new Button();
            btnExportToExcel = new Button();
            dgvReportPreview = new DataGridView();
            btnExportToCSV_Click = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvReportPreview).BeginInit();
            SuspendLayout();
            // 
            // lblFromDate
            // 
            lblFromDate.AutoSize = true;
            lblFromDate.Location = new Point(170, 37);
            lblFromDate.Name = "lblFromDate";
            lblFromDate.Size = new Size(96, 25);
            lblFromDate.TabIndex = 0;
            lblFromDate.Text = "From Date";
            // 
            // lblToDate
            // 
            lblToDate.AutoSize = true;
            lblToDate.Location = new Point(170, 116);
            lblToDate.Name = "lblToDate";
            lblToDate.Size = new Size(72, 25);
            lblToDate.TabIndex = 1;
            lblToDate.Text = "To Date";
            // 
            // dtpFromDate
            // 
            dtpFromDate.Location = new Point(295, 32);
            dtpFromDate.Name = "dtpFromDate";
            dtpFromDate.Size = new Size(300, 31);
            dtpFromDate.TabIndex = 2;
            // 
            // dtpToDate
            // 
            dtpToDate.Location = new Point(295, 110);
            dtpToDate.Name = "dtpToDate";
            dtpToDate.Size = new Size(300, 31);
            dtpToDate.TabIndex = 3;
            // 
            // lblItemStatus
            // 
            lblItemStatus.AutoSize = true;
            lblItemStatus.Location = new Point(170, 195);
            lblItemStatus.Name = "lblItemStatus";
            lblItemStatus.Size = new Size(101, 25);
            lblItemStatus.TabIndex = 4;
            lblItemStatus.Text = "Item Status";
            // 
            // cmbItemStatus
            // 
            cmbItemStatus.FormattingEnabled = true;
            cmbItemStatus.Location = new Point(295, 187);
            cmbItemStatus.Name = "cmbItemStatus";
            cmbItemStatus.Size = new Size(300, 33);
            cmbItemStatus.TabIndex = 5;
            cmbItemStatus.SelectedIndexChanged += cmbItemStatus_SelectedIndexChanged;
            // 
            // btnGenerateReport
            // 
            btnGenerateReport.Location = new Point(92, 646);
            btnGenerateReport.Name = "btnGenerateReport";
            btnGenerateReport.Size = new Size(165, 34);
            btnGenerateReport.TabIndex = 6;
            btnGenerateReport.Text = "Generate Report";
            btnGenerateReport.UseVisualStyleBackColor = true;
            btnGenerateReport.Click += btnGenerateReport_Click;
            // 
            // btnExportToExcel
            // 
            btnExportToExcel.Location = new Point(311, 646);
            btnExportToExcel.Name = "btnExportToExcel";
            btnExportToExcel.Size = new Size(154, 34);
            btnExportToExcel.TabIndex = 7;
            btnExportToExcel.Text = "Export to Excel";
            btnExportToExcel.UseVisualStyleBackColor = true;
            btnExportToExcel.Click += btnExportToExcel_Click;
            // 
            // dgvReportPreview
            // 
            dgvReportPreview.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvReportPreview.Location = new Point(31, 268);
            dgvReportPreview.Name = "dgvReportPreview";
            dgvReportPreview.RowHeadersWidth = 62;
            dgvReportPreview.Size = new Size(743, 318);
            dgvReportPreview.TabIndex = 8;
            // 
            // btnExportToCSV_Click
            // 
            btnExportToCSV_Click.Location = new Point(525, 646);
            btnExportToCSV_Click.Name = "btnExportToCSV_Click";
            btnExportToCSV_Click.Size = new Size(207, 34);
            btnExportToCSV_Click.TabIndex = 9;
            btnExportToCSV_Click.Text = "Generate CSV Report";
            btnExportToCSV_Click.UseVisualStyleBackColor = true;
            btnExportToCSV_Click.Click += btnExportToCSV_Click_Click;
            // 
            // GenerateReport
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 715);
            Controls.Add(btnExportToCSV_Click);
            Controls.Add(dgvReportPreview);
            Controls.Add(btnExportToExcel);
            Controls.Add(btnGenerateReport);
            Controls.Add(cmbItemStatus);
            Controls.Add(lblItemStatus);
            Controls.Add(dtpToDate);
            Controls.Add(dtpFromDate);
            Controls.Add(lblToDate);
            Controls.Add(lblFromDate);
            Name = "GenerateReport";
            Text = "GenerateReport";
            ((System.ComponentModel.ISupportInitialize)dgvReportPreview).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblFromDate;
        private Label lblToDate;
        private DateTimePicker dtpFromDate;
        private DateTimePicker dtpToDate;
        private Label lblItemStatus;
        private ComboBox cmbItemStatus;
        private Button btnGenerateReport;
        private Button btnExportToExcel;
        private DataGridView dgvReportPreview;
        private Button btnExportToCSV_Click;
    }
}