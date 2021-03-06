﻿using System;

namespace BirthdayPicker.Exceptions
{
    internal class BirthdayInFutureException: Exception
    {
        public BirthdayInFutureException(string message) : base(message)
        { }
        public BirthdayInFutureException(string message, Exception inner) : base(message, inner)
        { }
    }
}
