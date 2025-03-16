﻿using System;
using System.Collections.Generic;

namespace AddressBookSystem
{
    class AddressBook
    {
        private Dictionary<string, List<Contact>> addressBooks = new Dictionary<string, List<Contact>>();
        private string currentAddressBook = null;

       
        public void AddAddressBook(string name)
        {
            if (!addressBooks.ContainsKey(name))
            {
                addressBooks[name] = new List<Contact>();
                Console.WriteLine($"Address Book '{name}' created successfully!");
            }
            else
            {
                Console.WriteLine("An Address Book with this name already exists!");
            }
        }

       
        public void SelectAddressBook(string name)
        {
            if (addressBooks.ContainsKey(name))
            {
                currentAddressBook = name;
                Console.WriteLine($"Switched to Address Book '{name}'.");
            }
            else
            {
                Console.WriteLine("Address Book not found!");
            }
        }

        public void AddContact()
        {
            if (currentAddressBook == null)
            {
                Console.WriteLine("No Address Book selected! Please select an Address Book first.");
                return;
            }

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
            string zipInput = Console.ReadLine();
            while (!Contact.IsValidZip(zipInput))
            {
                Console.Write("Invalid ZIP! Enter a valid 5-digit ZIP or ZIP+4: ");
                zipInput = Console.ReadLine();
            }
            newContact.Zip = zipInput;

            Console.Write("Enter Phone Number: ");
            newContact.PhoneNumber = Console.ReadLine();

            Console.Write("Enter Email: ");
            string emailInput = Console.ReadLine();
            while (!Contact.IsValidEmail(emailInput))
            {
                Console.Write("Invalid Email! Enter a valid email address: ");
                emailInput = Console.ReadLine();
            }
            newContact.Email = emailInput;
            
            addressBooks[currentAddressBook].Add(newContact);
            Console.WriteLine("Contact added successfully!");
        }

        public void DisplayContacts()
        {
            if (currentAddressBook == null)
            {
                Console.WriteLine("No Address Book selected! Please select an Address Book first.");
                return;
            }

            Console.WriteLine($"\nContacts in Address Book '{currentAddressBook}':");
            if (addressBooks[currentAddressBook].Count == 0)
            {
                Console.WriteLine("No contacts found.");
                return;
            }

            foreach (var contact in addressBooks[currentAddressBook])
            {
                Console.WriteLine(contact);
            }
        }
    }
}
