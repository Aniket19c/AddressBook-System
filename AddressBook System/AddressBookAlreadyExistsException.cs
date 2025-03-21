using System;

namespace AddressBookSystem
{
    public class AddressBookAlreadyExistsException : Exception
    {
        public AddressBookAlreadyExistsException(string message) : base(message) { }
    }
}
