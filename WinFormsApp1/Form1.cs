using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using WinFormsApp1.Model;
using WinFormsApp1.Repo;
using WinFormsApp1;
using WinFormsApp1.Properties;



namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        //private DataGridView dataGridView1;

        public Form1()
        {
            InitializeComponent();
            
            
            this.DialogResult = DialogResult.Cancel;
        }



        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }





        private void button2_Click(object sender, EventArgs e)
        {
            
            PatientRepo patientRepo = new PatientRepo();
            //var val = this.dataGridView1.SelectedRows[0].Cells[0].Value.ToString();

            Patient patient = patientRepo.GetPatient(patientId);

           
            patient.firstName = this.textBox1.Text;
            patient.lastName= this.textBox8.Text;
            patient.email= this.textBox6.Text;
            patient.contactNumber= this.textBox2.Text;
            patient.address= this.textBox5.Text;
            //patient.height= this.textBox4.Text;
            //patient.weight= this.textBox3.Text;
            patient.height = decimal.Parse(this.textBox4.Text);
            patient.weight = decimal.Parse(this.textBox3.Text);
            patient.gender= this.comboBox1.Text;
            patient.city= this.textBox7.Text;
            patient.state= this.textBox9.Text; 
            patient.postalCode= this.textBox10.Text; 
            patient.maritalStatus= this.comboBox2.Text;
            patient.dob = this.dateTimePicker1.Value;


           

            var repo = new PatientRepo();
            if (patient.id == 0)
            {
                repo.CreatePatient(patient);
            }
           else
            {
                repo.UpdatePatient(patient);
            }


            this.DialogResult = DialogResult.OK;


        }

        private int patientId = 0;
        public void EditPatient(Patient patient)
        {
            this.textBox11.Text = "" + patient.id;
            this.textBox1.Text=patient.firstName;
           this.textBox8.Text = patient.lastName ;
           this.textBox6.Text = patient.email;
             this.textBox2.Text = patient.contactNumber;
           this.textBox5.Text = patient.address ;
            //this.textBox4.Text = patient.height ;
            //this.textBox3.Text = patient.weight ;
            this.textBox4.Text = patient.height.ToString();
            this.textBox3.Text = patient.weight.ToString();
            this.comboBox1.Text = patient.gender ;
          this.textBox7.Text = patient.city ;
           this.textBox9.Text = patient.state  ;
           this.textBox10.Text = patient.postalCode ;
           this.comboBox2.Text = patient.postalCode ;
            // this.dateTimePicker1.Text = patient.dob;
            this.dateTimePicker1.Text = patient.dob.ToString("dd/MM/yyyy"); // Formatted date

            this.patientId = patient.id;



            


        }

     
       

       
        private void button1_Click(object sender, EventArgs e)
        {
            //Patient patient = new Patient();

            //patient.id = this.patientId; 
            //patient.firstName = this.textBox1.Text;
            //patient.lastName = this.textBox8.Text;
            //patient.email = this.textBox6.Text;
            //patient.contactNumber = this.textBox2.Text;
            //patient.address = this.textBox5.Text;
            //patient.height = decimal.Parse(this.textBox4.Text);
            //patient.weight = decimal.Parse(this.textBox3.Text);
            //patient.gender = this.comboBox1.Text;
            //patient.city = this.textBox7.Text;
            //patient.state = this.textBox9.Text; ;
            //patient.postalCode = this.textBox10.Text;
            //patient.maritalStatus = this.comboBox2.Text;
            //patient.dob = this.dateTimePicker1.Value;


            //var repo = new PatientRepo();
            //if(patient.id==0)
            //{
            //    repo.CreatePatient(patient);
            //}
            //else
            //{
            //    repo.UpdatePatient(patient);
            //}
            

            this.DialogResult = DialogResult.OK;
        }
    }
}


