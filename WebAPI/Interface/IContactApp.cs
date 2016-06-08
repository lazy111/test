using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebAPI.Models;

namespace WebAPI.Interface
{
    public interface IContactApp
    {
        IEnumerable<Contact> GetContacts();
        IEnumerable<Contact> GetContactsBySex(string sex);
        Contact GetContactsByID(int id);
        void AddContact(Contact contact);
        void UpdateContact(Contact contact);
        void Delete(int id);
    }
}
