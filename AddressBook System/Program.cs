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
                Console.WriteLine("5. View Contacts by City");
                Console.WriteLine("6. View Contacts by State");
                Console.WriteLine("7. Count Contacts by City");
                Console.WriteLine("8. Count Contacts by State");
                Console.WriteLine("9. Sort Contacts Alphabetically");
                Console.WriteLine("10. Sort Contacts by City");
                Console.WriteLine("11. Sort Contacts by State");
                Console.WriteLine("12. Sort Contacts by Zip Code");


                Console.WriteLine("13. Exit");
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
                        Console.Write("Enter City Name: ");
                        string city = Console.ReadLine();
                        addressBookSystem.ViewContactsByCity(city);
                        break;
                    case "6":
                        Console.Write("Enter State Name: ");
                        string state = Console.ReadLine();
                        addressBookSystem.ViewContactsByState(state);
                        break;
                    case "7":
                        addressBookSystem.CountContactsByCity();
                        break;
                    case "8":
                        addressBookSystem.CountContactsByState();
                        break;
                    case "9":
                        addressBookSystem.SortContactsByName();
                        break;
                    case "10":
                        addressBookSystem.SortContactsByCity();
                        break;
                    case "11":
                        addressBookSystem.SortContactsByState();
                        break;
                    case "12":
                        addressBookSystem.SortContactsByZip();
                        break;


                    case "13":
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
