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

            while (true)
            {
                Console.Write("Enter ZIP Code (5 digits or ZIP+4 format): ");
                string zipInput = Console.ReadLine();
                if (Contact.IsValidZip(zipInput))
                {
                    newContact.Zip = zipInput;
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid ZIP Code! Please enter a valid format (e.g., 12345 or 12345-6789).");
                }
            }

            Console.Write("Enter Phone Number: ");
            newContact.PhoneNumber = Console.ReadLine();

            while (true)
            {
                Console.Write("Enter Email: ");
                string emailInput = Console.ReadLine();
                if (Contact.IsValidEmail(emailInput))
                {
                    newContact.Email = emailInput;
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid Email! Please enter a valid format (e.g., example@mail.com).");
                }
            }

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
