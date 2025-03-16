using System;
using AddressBookSystem;

class Program
{
    static void Main()
    {
        AddressBook addressBook = new AddressBook();
        bool exit = false;

        while (!exit)
        {
            Console.WriteLine("\nAddress Book System");
            Console.WriteLine("1. Add Contact");
            Console.WriteLine("2. Edit Contact");
            Console.WriteLine("3. Delete Contact");  
            Console.WriteLine("4. Display Contacts");
            Console.WriteLine("5. Exit");
            Console.Write("Choose an option: ");

            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    addressBook.AddContact();
                    break;
                case 2:
                    addressBook.EditContact();
                    break;
                case 3:
                    addressBook.DeleteContact(); 
                    break;
                case 4:
                    addressBook.DisplayContacts();
                    break;
                case 5:
                    exit = true;
                    Console.WriteLine("Exiting Address Book System.");
                    break;
                default:
                    Console.WriteLine("Invalid choice! Please enter again.");
                    break;
            }
        }
    }
}
