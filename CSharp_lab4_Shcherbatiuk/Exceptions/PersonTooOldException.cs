using System;

namespace CSharp_lab4_Shcherbatiuk.Exceptions
{
    internal class PersonTooOldException: ArgumentException
    {
        public PersonTooOldException(string message) : base(message) { }
    }
}
