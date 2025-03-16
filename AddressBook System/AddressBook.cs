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
                Console.Write("Enter ZIP Code: ");
                string zipInput = Console.ReadLine();
                if (Contact.IsValidZip(zipInput))
                {
                    newContact.Zip = zipInput;
                    break;
                }
                Console.WriteLine("Invalid ZIP Code! Must be 5 digits or ZIP+4 format.");
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
                Console.WriteLine("Invalid Email! Please enter a valid email format.");
            }

            contacts.Add(newContact);
            Console.WriteLine("Contact added successfully!");
        }

        public void DisplayContacts()
        {
            foreach (var contact in contacts)
            {
                Console.WriteLine(contact);
            }
        }

        public void DeleteContact()
        {
            Console.Write("Enter the first name of the contact to delete: ");
            string firstName = Console.ReadLine();
            Contact contactToDelete = contacts.Find(c => c.FirstName.Equals(firstName, StringComparison.OrdinalIgnoreCase));

            if (contactToDelete != null) 
            {
                contacts.Remove(contactToDelete);
                Console.WriteLine("Contact deleted successfully!");
            }
            else
            {
                Console.WriteLine("Contact not found!");
            }
        }

        public void EditContact()
        {
            Console.Write("Enter First Name of the contact to edit: ");
            string firstName = Console.ReadLine();
            Console.Write("Enter Last Name of the contact to edit: ");
            string lastName = Console.ReadLine();

            Contact contactToEdit = contacts.Find(c => c.FirstName.Equals(firstName, StringComparison.OrdinalIgnoreCase) &&
                                                       c.LastName.Equals(lastName, StringComparison.OrdinalIgnoreCase));

            if (contactToEdit == null)
            {
                Console.WriteLine("Contact not found!");
                return;
            }

            Console.WriteLine("Editing contact: " + contactToEdit);

            Console.Write("Enter new Address (press Enter to keep existing): ");
            string newAddress = Console.ReadLine();
            if (!string.IsNullOrEmpty(newAddress)) contactToEdit.Address = newAddress;

            Console.Write("Enter new City (press Enter to keep existing): ");
            string newCity = Console.ReadLine();
            if (!string.IsNullOrEmpty(newCity)) contactToEdit.City = newCity;

            Console.Write("Enter new State (press Enter to keep existing): ");
            string newState = Console.ReadLine();
            if (!string.IsNullOrEmpty(newState)) contactToEdit.State = newState;

            while (true)
            {
                Console.Write("Enter new ZIP Code (press Enter to keep existing): ");
                string newZip = Console.ReadLine();
                if (string.IsNullOrEmpty(newZip) || Contact.IsValidZip(newZip))
                {
                    if (!string.IsNullOrEmpty(newZip)) contactToEdit.Zip = newZip;
                    break;
                }
                Console.WriteLine("Invalid ZIP Code! Must be 5 digits or ZIP+4 format.");
            }

            Console.Write("Enter new Phone Number (press Enter to keep existing): ");
            string newPhoneNumber = Console.ReadLine();
            if (!string.IsNullOrEmpty(newPhoneNumber)) contactToEdit.PhoneNumber = newPhoneNumber;

            while (true)
            {
                Console.Write("Enter new Email (press Enter to keep existing): ");
                string newEmail = Console.ReadLine();
                if (string.IsNullOrEmpty(newEmail) || Contact.IsValidEmail(newEmail))
                {
                    if (!string.IsNullOrEmpty(newEmail)) contactToEdit.Email = newEmail;
                    break;
                }
                Console.WriteLine("Invalid Email! Please enter a valid email format.");
            }

            Console.WriteLine("Contact updated successfully!");
        }
    }
}
