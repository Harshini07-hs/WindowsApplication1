namespace PatientManagementSystem_RollBased.Forms.Admin
{
    partial class AddNewPatient
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
            lblPatientName = new Label();
            lblAddress = new Label();
            lblContact = new Label();
            lblMedicalHistory = new Label();
            lblAge = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            btnAdd = new Button();
            btnBack = new Button();
            SuspendLayout();
            // 
            // lblPatientName
            // 
            lblPatientName.AutoSize = true;
            lblPatientName.Location = new Point(221, 58);
            lblPatientName.Name = "lblPatientName";
            lblPatientName.Size = new Size(117, 25);
            lblPatientName.TabIndex = 0;
            lblPatientName.Text = "Patient Name";
            // 
            // lblAddress
            // 
            lblAddress.AutoSize = true;
            lblAddress.Location = new Point(221, 129);
            lblAddress.Name = "lblAddress";
            lblAddress.Size = new Size(77, 25);
            lblAddress.TabIndex = 1;
            lblAddress.Text = "Address";
            // 
            // lblContact
            // 
            lblContact.AutoSize = true;
            lblContact.Location = new Point(221, 190);
            lblContact.Name = "lblContact";
            lblContact.Size = new Size(143, 25);
            lblContact.TabIndex = 2;
            lblContact.Text = "Contact Number";
            // 
            // lblMedicalHistory
            // 
            lblMedicalHistory.AutoSize = true;
            lblMedicalHistory.Location = new Point(221, 248);
            lblMedicalHistory.Name = "lblMedicalHistory";
            lblMedicalHistory.Size = new Size(135, 25);
            lblMedicalHistory.TabIndex = 3;
            lblMedicalHistory.Text = "Medical History";
            // 
            // lblAge
            // 
            lblAge.AutoSize = true;
            lblAge.Location = new Point(221, 323);
            lblAge.Name = "lblAge";
            lblAge.Size = new Size(44, 25);
            lblAge.TabIndex = 4;
            lblAge.Text = "Age";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(420, 52);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(228, 31);
            textBox1.TabIndex = 5;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(420, 123);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(228, 31);
            textBox2.TabIndex = 6;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(420, 187);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(228, 31);
            textBox3.TabIndex = 7;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(420, 252);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(228, 31);
            textBox4.TabIndex = 8;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(420, 320);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(228, 31);
            textBox5.TabIndex = 9;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(252, 393);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(112, 34);
            btnAdd.TabIndex = 10;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnBack
            // 
            btnBack.Location = new Point(431, 395);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(112, 34);
            btnBack.TabIndex = 11;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = true;
            // 
            // AddNewPatient
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnBack);
            Controls.Add(btnAdd);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(lblAge);
            Controls.Add(lblMedicalHistory);
            Controls.Add(lblContact);
            Controls.Add(lblAddress);
            Controls.Add(lblPatientName);
            Name = "AddNewPatient";
            Text = "AddNewPatient";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblPatientName;
        private Label lblAddress;
        private Label lblContact;
        private Label lblMedicalHistory;
        private Label lblAge;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private Button btnAdd;
        private Button btnBack;
    }
}