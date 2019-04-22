using System;
using System.Collections.Generic;
using System.Text;

namespace PasswordGenerator
{
    class CharsForPassword 
    {

        public const string CapitalLetters = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";

        public const string SmallLetters = "abcdefghijklmnopqrstuvwxyz";

        public const string Digits = "0123456789";

        public const string SpecialChars = "~!@#$%^&*()_+={}[]<>/|;:.,";

        public const string AllChars = CapitalLetters + SmallLetters + Digits + SpecialChars;



    }
}
