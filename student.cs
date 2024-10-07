using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fyp_mid_project
{
    class student
    {
       
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Contact { get; set; }
        public string DateOfBirth { get; set; }
        public string Gender { get; set; }
        public string RegistrationNo { get; set; }
        public student(string FirstName,string lastname, string email, string contact,string dateOfBirth,string gender,string registrationNo)
        {
            this.FirstName = FirstName; 
            this.LastName = LastName;   
            this.Contact = Contact;
            this.Email= Email;
            this.DateOfBirth= dateOfBirth;  
            this.Gender = gender;
            this.RegistrationNo = registrationNo;
        }

            





    }
}
