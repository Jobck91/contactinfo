using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactInfo
{
    public class ContactManager : IContactManager
    {
        private List<Contact> contacts = new List<Contact>();

        public bool CreateContact(Contact contact)
        {
            contacts.Add(contact);
            return true;
        }

        public List<Contact> GetAllContacts()
        {
            return contacts;
        }

        public Contact GetContact(int id)
        {
            return null;
        }

        public Contact RemoveContact(int id)
        {
            return contacts.FirstOrDefault();
        }
    }
}
