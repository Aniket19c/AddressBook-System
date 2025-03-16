# Address Book System

## Overview
The Address Book System is a console-based C# application that allows users to manage multiple address books, store contact details, and perform various operations such as adding, searching, viewing, and counting contacts based on city or state.

## Features Implemented (Up to UC10)

### UC1: Create a Contact
- Allows users to create a contact with details like First Name, Last Name, Address, City, State, ZIP Code, Phone Number, and Email.

### UC2: Add New Contact to Address Book
- Stores the created contact in an Address Book.

### UC3: Edit Existing Contact
- Users can update existing contact details.

### UC4: Delete a Contact
- Provides the ability to delete a specific contact from the Address Book.

### UC5: Add Multiple Persons to Address Book
- Users can add multiple contacts.
- Uses a Collection Class to manage contacts.

### UC6: Add Multiple Address Books
- Each Address Book has a unique name.
- Maintains a dictionary mapping Address Book names to contacts.

### UC7: Prevent Duplicate Entries
- Ensures no duplicate entries exist in the same Address Book.
- Uses collection methods to check for duplicates based on the person’s name.
- Overrides `Equals` method for duplicate checking.

### UC8: Search a Person by City or State Across Multiple Address Books
- Allows searching for contacts across all Address Books by city or state.

### UC9: View Persons by City or State
- Maintains a dictionary of City-Person and State-Person mappings.
- Uses collection methods to store and retrieve contacts based on location.

### UC10: Count Contacts by City or State
- Displays the count of contacts in each city or state.

## Technologies Used
- **Language:** C#
- **Framework:** .NET Core
- **IDE:** Visual Studio Community
- **Concepts Implemented:**
  - Object-Oriented Programming (Encapsulation, Inheritance, Polymorphism, Abstraction)
  - Collections and Dictionaries
  - File Handling (To be implemented in later versions)
  - Regex Validation for Email and ZIP Code
  - Console Input and Output

## How to Run the Project
1. Clone the repository:
   ```sh
   git clone <repository-url>
   ```
2. Open the project in Visual Studio.
3. Build and Run the project (`Ctrl + F5`).
4. Follow the menu options to interact with the Address Book System.


