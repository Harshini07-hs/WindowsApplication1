namespace PatientManagementSystem_RollBased.Forms.Admin
{
    partial class AppointmentActionForm
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
            dateTimePicker1 = new DateTimePicker();
            btnCancelAppointment = new Button();
            btnRescheduleAppointment = new Button();
            lblPatientName = new Label();
            lblCurrentStatus = new Label();
            btnClose = new Button();
            SuspendLayout();
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(166, 187);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(300, 31);
            dateTimePicker1.TabIndex = 0;
            // 
            // btnCancelAppointment
            // 
            btnCancelAppointment.Location = new Point(229, 267);
            btnCancelAppointment.Name = "btnCancelAppointment";
            btnCancelAppointment.Size = new Size(112, 34);
            btnCancelAppointment.TabIndex = 1;
            btnCancelAppointment.Text = "Cancel";
            btnCancelAppointment.UseVisualStyleBackColor = true;
            btnCancelAppointment.Click += btnCancelAppointment_Click;
            // 
            // btnRescheduleAppointment
            // 
            btnRescheduleAppointment.Location = new Point(472, 184);
            btnRescheduleAppointment.Name = "btnRescheduleAppointment";
            btnRescheduleAppointment.Size = new Size(112, 34);
            btnRescheduleAppointment.TabIndex = 2;
            btnRescheduleAppointment.Text = "Reschedule";
            btnRescheduleAppointment.UseVisualStyleBackColor = true;
            btnRescheduleAppointment.Click += btnRescheduleAppointment_Click;
            // 
            // lblPatientName
            // 
            lblPatientName.AutoSize = true;
            lblPatientName.Location = new Point(188, 59);
            lblPatientName.Name = "lblPatientName";
            lblPatientName.Size = new Size(117, 25);
            lblPatientName.TabIndex = 3;
            lblPatientName.Text = "Patient Name";
            // 
            // lblCurrentStatus
            // 
            lblCurrentStatus.AutoSize = true;
            lblCurrentStatus.Location = new Point(188, 104);
            lblCurrentStatus.Name = "lblCurrentStatus";
            lblCurrentStatus.Size = new Size(123, 25);
            lblCurrentStatus.TabIndex = 4;
            lblCurrentStatus.Text = "Current Status";
            // 
            // btnClose
            // 
            btnClose.Location = new Point(373, 311);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(112, 34);
            btnClose.TabIndex = 5;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // AppointmentActionForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnClose);
            Controls.Add(lblCurrentStatus);
            Controls.Add(lblPatientName);
            Controls.Add(btnRescheduleAppointment);
            Controls.Add(btnCancelAppointment);
            Controls.Add(dateTimePicker1);
            Name = "AppointmentActionForm";
            Text = "AppointmentActionForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DateTimePicker dateTimePicker1;
        private Button btnCancelAppointment;
        private Button btnRescheduleAppointment;
        private Label lblPatientName;
        private Label lblCurrentStatus;
        private Button btnClose;
    }
}