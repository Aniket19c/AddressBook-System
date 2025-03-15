using System;

namespace AddressBookSystem
{
    class AddressBookMain
    {
        public static void Run()
        {
            AddressBook addressBook = new AddressBook();

            while (true)
            {
                Console.WriteLine("\n1. Add Contact\n2. Display Contacts\n3. Exit");
                Console.Write("Choose an option: ");
                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        addressBook.AddContact();
                        break;
                    case 2:
                        addressBook.DisplayContacts();
                        break;
                    case 3:
                        Console.WriteLine("Exiting Address Book...");
                        return;
                    default:
                        Console.WriteLine("Invalid choice. Try again.");
                        break;
                }
            }
        }
    }
}
