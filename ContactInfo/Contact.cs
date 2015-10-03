using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactInfo
{
    public class Contact
    {
        string firstName;
        string lastName;
        string mobileNumber;
        string description;
        int id;


        public string FirstName
        {
            get { return firstName; }
        }
        public string LastName
        {
            get { return lastName; }
        }
        public string MobileNumber
        {
            get { return mobileNumber; }
        }
        public string Description
        {
            get { return description; }
        }
        public int Id
        {
            get { return id; }
        }


    }
}
