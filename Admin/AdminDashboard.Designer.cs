namespace PatientManagementSystem_RollBased.Forms.Admin
{
    partial class AdminDashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminDashboard));
            panel1 = new Panel();
            toolStrip1 = new ToolStrip();
            toolStripDropDownButton1 = new ToolStripDropDownButton();
            addPatientsToolStripMenuItem = new ToolStripMenuItem();
            linkLogout = new LinkLabel();
            btnPatients = new Button();
            btnDoctors = new Button();
            btnAppointment = new Button();
            panel2 = new Panel();
            panel1.SuspendLayout();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(toolStrip1);
            panel1.Controls.Add(linkLogout);
            panel1.Controls.Add(btnPatients);
            panel1.Controls.Add(btnDoctors);
            panel1.Controls.Add(btnAppointment);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(776, 104);
            panel1.TabIndex = 0;
            // 
            // toolStrip1
            // 
            toolStrip1.ImageScalingSize = new Size(24, 24);
            toolStrip1.Items.AddRange(new ToolStripItem[] { toolStripDropDownButton1 });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(776, 34);
            toolStrip1.TabIndex = 4;
            toolStrip1.Text = "toolStrip1";
            // 
            // toolStripDropDownButton1
            // 
            toolStripDropDownButton1.DropDownItems.AddRange(new ToolStripItem[] { addPatientsToolStripMenuItem });
            toolStripDropDownButton1.Image = (Image)resources.GetObject("toolStripDropDownButton1.Image");
            toolStripDropDownButton1.ImageTransparentColor = Color.Magenta;
            toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            toolStripDropDownButton1.Size = new Size(118, 29);
            toolStripDropDownButton1.Text = "Options";
            // 
            // addPatientsToolStripMenuItem
            // 
            addPatientsToolStripMenuItem.Name = "addPatientsToolStripMenuItem";
            addPatientsToolStripMenuItem.Size = new Size(270, 34);
            addPatientsToolStripMenuItem.Text = "Add Patients";
            addPatientsToolStripMenuItem.Click += addPatientsToolStripMenuItem_Click;
            // 
            // linkLogout
            // 
            linkLogout.AutoSize = true;
            linkLogout.Location = new Point(671, 32);
            linkLogout.Name = "linkLogout";
            linkLogout.Size = new Size(69, 25);
            linkLogout.TabIndex = 3;
            linkLogout.TabStop = true;
            linkLogout.Text = "Logout";
            linkLogout.LinkClicked += linkLogout_LinkClicked;
            // 
            // btnPatients
            // 
            btnPatients.Location = new Point(446, 27);
            btnPatients.Name = "btnPatients";
            btnPatients.Size = new Size(143, 34);
            btnPatients.TabIndex = 2;
            btnPatients.Text = "View Patients";
            btnPatients.UseVisualStyleBackColor = true;
            btnPatients.Click += btnPatients_Click;
            // 
            // btnDoctors
            // 
            btnDoctors.Location = new Point(239, 27);
            btnDoctors.Name = "btnDoctors";
            btnDoctors.RightToLeft = RightToLeft.Yes;
            btnDoctors.Size = new Size(143, 34);
            btnDoctors.TabIndex = 1;
            btnDoctors.Text = "View Doctors";
            btnDoctors.UseVisualStyleBackColor = true;
            btnDoctors.Click += btnDoctors_Click;
            // 
            // btnAppointment
            // 
            btnAppointment.Location = new Point(17, 27);
            btnAppointment.Name = "btnAppointment";
            btnAppointment.Size = new Size(190, 34);
            btnAppointment.TabIndex = 0;
            btnAppointment.Text = "View Appointment";
            btnAppointment.UseVisualStyleBackColor = true;
            btnAppointment.Click += btnAppointment_Click;
            // 
            // panel2
            // 
            panel2.Location = new Point(12, 122);
            panel2.Name = "panel2";
            panel2.Size = new Size(776, 188);
            panel2.TabIndex = 1;
            // 
            // AdminDashboard
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "AdminDashboard";
            Text = "AdminMenu";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private LinkLabel linkLogout;
        private Button btnPatients;
        private Button btnDoctors;
        private Button btnAppointment;
        private Panel panel2;
        private ToolStrip toolStrip1;
        private ToolStripDropDownButton toolStripDropDownButton1;
        private ToolStripMenuItem addPatientsToolStripMenuItem;
    }
}