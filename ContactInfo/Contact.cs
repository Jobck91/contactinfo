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

        public Contact(string firstname, string lastname, string mobilenumber, string description)
        {
            FirstName = firstname;
            LastName = lastname;
            MobileNumber = mobilenumber;
            Description = description;

        }

        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }
        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }
        public string MobileNumber
        {
            get { return mobileNumber; }
            set { mobileNumber = value; }
        }
        public string Description
        {
            get { return description; }
            set { description = value; }
        }
        public int Id
        {
            get { return id; }
        }


    }
}
