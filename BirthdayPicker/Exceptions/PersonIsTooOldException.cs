using System;

namespace BirthdayPicker.Exceptions
{
    internal class PersonIsTooOldException : Exception
    {
        public PersonIsTooOldException(string message) : base(message)
        { }
        public PersonIsTooOldException(string message, Exception inner) : base(message, inner)
        { }
    }
}
