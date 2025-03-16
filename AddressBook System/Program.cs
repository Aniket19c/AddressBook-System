using System;

namespace AddressBookSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            AddressBook addressBookSystem = new AddressBook();
            bool exit = false;

            while (!exit)
            {
                Console.WriteLine("\n===== Address Book System Menu =====");
                Console.WriteLine("1. Create a new Address Book");
                Console.WriteLine("2. Select an Address Book");
                Console.WriteLine("3. Add a Contact");
                Console.WriteLine("4. Display Contacts");
                Console.WriteLine("5. Exit");
                Console.Write("Enter your choice: ");

                string choice = Console.ReadLine();
                switch (choice)
                {
                    case "1":
                        Console.Write("Enter Address Book Name: ");
                        string bookName = Console.ReadLine();
                        addressBookSystem.AddAddressBook(bookName);
                        break;
                    case "2":
                        Console.Write("Enter Address Book Name to select: ");
                        string selectBook = Console.ReadLine();
                        addressBookSystem.SelectAddressBook(selectBook);
                        break;
                    case "3":
                        addressBookSystem.AddContact();
                        break;
                    case "4":
                        addressBookSystem.DisplayContacts();
                        break;
                    case "5":
                        exit = true;
                        Console.WriteLine("Exiting Address Book System.");
                        break;
                    default:
                        Console.WriteLine("Invalid choice! Please enter a valid option.");
                        break;
                }
            }
        }
    }
}
