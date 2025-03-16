using System;
using System.Collections.Generic;
using System.Linq;

namespace AddressBookSystem
{
    class AddressBook
    {
        private Dictionary<string, List<Contact>> addressBooks = new Dictionary<string, List<Contact>>();
        private string currentAddressBook = null;

        private Dictionary<string, List<Contact>> cityToContacts = new Dictionary<string, List<Contact>>();
        private Dictionary<string, List<Contact>> stateToContacts = new Dictionary<string, List<Contact>>();

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

        private bool IsDuplicateContact(string firstName, string lastName)
        {
            if (currentAddressBook == null || !addressBooks.ContainsKey(currentAddressBook))
            {
                return false;
            }

            return addressBooks[currentAddressBook]
                   .Any(contact => contact.FirstName.Equals(firstName, StringComparison.OrdinalIgnoreCase) &&
                                   contact.LastName.Equals(lastName, StringComparison.OrdinalIgnoreCase));
        }

        public void AddContact()
        {
            if (currentAddressBook == null)
            {
                Console.WriteLine("No Address Book selected! Please select an Address Book first.");
                return;
            }

            Console.Write("Enter First Name: ");
            string firstName = Console.ReadLine();

            Console.Write("Enter Last Name: ");
            string lastName = Console.ReadLine();

            if (IsDuplicateContact(firstName, lastName))
            {
                Console.WriteLine("This contact already exists! Duplicate contacts are not allowed.");
                return;
            }

            Contact newContact = new Contact
            {
                FirstName = firstName,
                LastName = lastName
            };

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

         
            if (!cityToContacts.ContainsKey(newContact.City))
            {
                cityToContacts[newContact.City] = new List<Contact>();
            }
            cityToContacts[newContact.City].Add(newContact);

       
            if (!stateToContacts.ContainsKey(newContact.State))
            {
                stateToContacts[newContact.State] = new List<Contact>();
            }
            stateToContacts[newContact.State].Add(newContact);

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

        public void ViewPersonsByCityOrState()
        {
            Console.Write("Enter City or State to search for persons: ");
            string searchInput = Console.ReadLine();

            List<Contact> contactsInCity = cityToContacts.ContainsKey(searchInput) ? cityToContacts[searchInput] : new List<Contact>();
            List<Contact> contactsInState = stateToContacts.ContainsKey(searchInput) ? stateToContacts[searchInput] : new List<Contact>();

            HashSet<Contact> uniqueContacts = new HashSet<Contact>(contactsInCity.Concat(contactsInState));

            if (uniqueContacts.Count == 0)
            {
                Console.WriteLine($"No persons found in City/State: {searchInput}");
            }
            else
            {
                Console.WriteLine($"Persons found in City/State '{searchInput}':");
                foreach (var contact in uniqueContacts)
                {
                    Console.WriteLine(contact);
                }
            }
        }
    }
}
