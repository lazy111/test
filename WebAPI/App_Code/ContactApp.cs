using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebAPI.Interface;
using WebAPI.Models;

namespace WebAPI.App_Code
{
    public class ContactApp : IContactApp
    {

        private List<Contact> contacts;
        public ContactApp()
        {
            contacts = new List<Contact>()
            {
                new Contact() { ID=1, Age=32, Birthday= Convert.ToDateTime("1977-05-30"),Name="杨过", Sex="男"},
                new Contact() { ID = 2, Age = 55, Birthday = Convert.ToDateTime("1937-05-30"), Name = "令狐冲", Sex = "男" },
                new Contact() { ID = 3, Age = 12, Birthday = Convert.ToDateTime("1987-05-30"), Name = "郭靖", Sex = "男" },
                new Contact() { ID = 4, Age = 18, Birthday = Convert.ToDateTime("1997-05-30"), Name = "黄蓉", Sex = "女" }
            };
        }

        public IEnumerable<Models.Contact> GetContacts()
        {
            return contacts;
        }

        public IEnumerable<Models.Contact> GetContactsBySex(string sex)
        {
            return contacts.Where(contact => contact.Sex == sex);
        }

        public Models.Contact GetContactsByID(int id)
        {
            return contacts.Find(contact => contact.ID == id);
        }

        public void AddContact(Models.Contact contact)
        {
            if (contacts.FindIndex(item => item.ID == contact.ID) == 0)
            {
                contacts.Add(contact);
            }
        }

        public void UpdateContact(Models.Contact contact)
        {
            if (contact != null)
            {

                Delete(contact.ID);
                contacts.Add(contact);
            }
        }

        public void Delete(int id)
        {
            contacts.RemoveAll(item => item.ID == id);
        }
    }
}