using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebAPI.App_Code;
using WebAPI.Interface;
using WebAPI.Models;

namespace WebAPI.Controllers
{
    public class ContactController : ApiController
    {

        IContactApp app = new ContactApp();

        public IEnumerable<Contact> GetContacts()
        {
            return app.GetContacts();
        }

        public IEnumerable<Contact> GetContactsBySex(string sex) {
            return app.GetContactsBySex(sex);
        }
        public Contact GetContactByID(int id) {

            return app.GetContactsByID(id);
        }

        [HttpPut]
        public void Update(Contact contact) {
             app.UpdateContact(contact);
        }
        [HttpPost]
        public void Remove(int id) {
            app.Delete(id);
        }

        [NonAction]
        public int GetAge(int id) {
            return 0;
        }

        [AcceptVerbs()]
        public Contact GetContactByName(string name) {
            return null;
        }


    }
}
