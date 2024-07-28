using System;
using System.Collections.Generic;
using System.DirectoryServices;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignerClientApplication
{
    public class ContactManager
    {
        private List<Contact> contacts;

        public ContactManager()
        {
            contacts = new List<Contact>();
        }

        public Contact GetContact(int index)
        {
            if (CheckIndex(index))
            {
                return contacts[index];
            }
            else
            {
                return null;
            }
               
        }

        public bool AddContact(Contact currContact)
        {
            bool ok = false;

            if(currContact != null)
            {
                Contact contact = new Contact(currContact);
                contacts.Add(contact);
                ok = true;
            }

            return ok;
        }

        public bool CheckIndex(int index)
        {
           return index >= 0 && index < contacts.Count;
        }

        public string[] GetClientInfoString()
        {
            string[] clientInfo = new string[contacts.Count];

            int i = 0;

            foreach (Contact clientObj in contacts)
            {
                clientInfo[i++] = clientObj.FullName();
            }

            return clientInfo;
        }

        public string[] GetImage()
        {
            string[] clientImage = new string[contacts.Count];

            int i = 0;

            foreach (Contact imageObj in contacts)
            {
                clientImage[i++] = imageObj.FullName();
            }

            return clientImage;
        }

        public void DeleteContact(int index)
        {
            if(CheckIndex(index))
                contacts.Remove(contacts[index]);
        }

        public void ChangeContact(Contact contact, int index)
        {

            if (CheckIndex(index) && contact != null)
            {
                contacts[index] = contact;
            }

        }


    }
}
