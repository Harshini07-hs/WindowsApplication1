using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1.Model
{
    public class Patient
    {
        public  int id;
        public string firstName = "";
        public string lastName = "";
        public string contactNumber = "";
        public decimal weight = 0;
        public decimal height = 0;
        public string address = "";
        public string email = "";
        public string city = "";
        public string state = "";
        public string postalCode = "";
        public DateTime dob = DateTime.Now;
        public string gender = "";
        public string maritalStatus = "";
    }
}
