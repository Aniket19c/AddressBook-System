using System;
using System.Collections.Generic;

namespace AddressBookSystem
{
    class AddressBook
    {
        private List<Contact> contacts = new List<Contact>();

        public void AddContact()
        {
            Contact newContact = new Contact();

            Console.Write("Enter First Name: ");
            newContact.FirstName = Console.ReadLine();

            Console.Write("Enter Last Name: ");
            newContact.LastName = Console.ReadLine();

            Console.Write("Enter Address: ");
            newContact.Address = Console.ReadLine();

            Console.Write("Enter City: ");
            newContact.City = Console.ReadLine();

            Console.Write("Enter State: ");
            newContact.State = Console.ReadLine();

            Console.Write("Enter ZIP Code: ");
            newContact.Zip = Console.ReadLine();

            Console.Write("Enter Phone Number: ");
            newContact.PhoneNumber = Console.ReadLine();

            Console.Write("Enter Email: ");
            newContact.Email = Console.ReadLine();

            contacts.Add(newContact);
            Console.WriteLine("Contact added successfully!");
        }

        public void DisplayContacts()
        {
            if (contacts.Count == 0)
            {
                Console.WriteLine("No contacts found.");
                return;
            }

            Console.WriteLine("\nAddress Book Contacts:");
            foreach (var contact in contacts)
            {
                Console.WriteLine(contact);
            }
        }
    }
}
