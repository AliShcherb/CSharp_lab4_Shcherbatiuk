using System;

namespace CSharp_lab4_Shcherbatiuk.Exceptions
{
    internal class InvalidEmailException: ArgumentException
    {
        public InvalidEmailException(string message) : base(message) { }
    }
}
