using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactInfo
{
    public class ContactManagerTemporary : IContactManager
    {
        private List<Contact> _contacts;

        public ContactManagerTemporary()
        {
            _contacts = new List<Contact>();
        }

        public bool CreateContact(Contact contact)
        {
            _contacts.Add(contact);
            return true;
        }

        public Contact RemoveContact(int id)
        {

            return null;
        }

        public List<Contact> GetAllContacts()
        {
            return _contacts;
        }

        public Contact GetContact(int id)
        {
            return _contacts.FirstOrDefault();
        }
    }
}
