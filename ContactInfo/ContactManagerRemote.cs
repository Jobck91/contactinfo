using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Net;
using System.Net.Sockets;

namespace ContactInfo
{
    public class ContactManagerRemote : IContactManager
    {
        public ContactManagerRemote()
        {
            TcpClient client = new TcpClient("192.168.0.112", 1337);
        }

        public bool CreateContact(Contact contact)
        {

            //Convert object to proper format 
            String contactStr = "{ 'title' : '" + contact.

            return true;
        }

        public Contact RemoveContact(int id)
        {
            return null;
        }

        public List<Contact> GetAllContacts()
        {
            return null;
        }

        public Contact GetContact(int id)
        {
            return null;
        }
    }
}
