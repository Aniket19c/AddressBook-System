using System;
using System.Text.RegularExpressions;

namespace AddressBookSystem
{
    class Contact
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }

        public override string ToString()
        {
            return $"Name: {FirstName} {LastName}, Address: {Address}, {City}, {State}, {Zip}, Phone: {PhoneNumber}, Email: {Email}";
        }

   
        public override bool Equals(object obj)
        {
            if (obj is Contact contact)
            {
                return this.FirstName.Equals(contact.FirstName, StringComparison.OrdinalIgnoreCase) &&
                       this.LastName.Equals(contact.LastName, StringComparison.OrdinalIgnoreCase);
            }
            return false;
        }

  
        public override int GetHashCode()
        {
            return FirstName.ToLower().GetHashCode() ^ LastName.ToLower().GetHashCode();
        }

        public static bool IsValidEmail(string email)
        {
            string emailPattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";
            return Regex.IsMatch(email, emailPattern);
        }

        public static bool IsValidZip(string zip)
        {
            string zipPattern = @"^\d{5}(-\d{4})?$";
            return Regex.IsMatch(zip, zipPattern);
        }
    }
}
