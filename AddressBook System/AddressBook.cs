using System;
using System.Collections.Generic;

namespace AddressBookSystem
{
    class AddressBook
    {
        private List<Contact> contacts = new List<Contact>();
        public void AddContact(Contact contact)
        {
            contacts.Add(contact);
            Console.WriteLine("Contact added successfully!");
        }
    }
}
