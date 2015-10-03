using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactInfo
{
    public interface IContactManager
    {
        /// <summary>
        /// Add the contact to the repository
        /// </summary>
        /// <param name="contact"></param>
        /// <returns>True if successful</returns>
        bool CreateContact(Contact contact);

        /// <summary>
        /// Removes the contact from the repository.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Contact RemoveContact(int id);

        List<Contact> GetAllContacts();

        Contact GetContact(int id);
    }
}
