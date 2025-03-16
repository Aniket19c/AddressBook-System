using System;

namespace AddressBookSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            AddressBook addressBook = new AddressBook();

            while (true)
            {
                Console.WriteLine("\nAddress Book Menu:");
                Console.WriteLine("1. Add Contact");
                Console.WriteLine("2. Display Contacts");
                Console.WriteLine("3. Edit Contact");
                Console.WriteLine("4. Delete Contact");
                Console.WriteLine("5. Exit");
                Console.Write("Enter your choice: ");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        addressBook.AddContact();
                        break;
                    case "2":
                        addressBook.DisplayContacts();
                        break;
                    case "3":
                        addressBook.EditContact();
                        break;
                    case "4":
                        addressBook.DeleteContact();
                        break;
                    case "5":
                        Console.WriteLine("Exiting Address Book. Goodbye!");
                        return;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
            }
        }
    }
}
