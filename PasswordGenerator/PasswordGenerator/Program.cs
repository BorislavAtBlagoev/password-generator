using System;
using System.Text;

namespace PasswordGenerator
{
    class Program
    {

        //public int passwordLenght;

        static void Main(string[] args)
        {
            int passwordLenght = 0;
            int charsFromCapitalLetters = 2;
            int charsFromSmallLetters = 2;
            int charsFromDigits = 2;
            int charsFromSpecialChars = 2;
            int remainingLenght = 0;

            Random rd = new Random();
            Random rm = new Random();
            StringBuilder sb = new StringBuilder();

            while (!(passwordLenght >= 8 && passwordLenght <= 20))
            {
                Console.Write("Please, insert password lenght:");
                passwordLenght = int.Parse(Console.ReadLine());
            }



            // getting random char from CapitalLetters
            for (int j = 0; j < charsFromCapitalLetters; j++)
            {
                int randomIndexFromString = rd.Next(0, CharsForPassword.CapitalLetters.Length);
                char randomChar = CharsForPassword.CapitalLetters[randomIndexFromString];
                sb.Append(randomChar);
            }
            // getting random char from SmallLetters
            for (int k = 0; k < charsFromSmallLetters; k++)
            {
                int randomIndexFromString = rd.Next(0, CharsForPassword.SmallLetters.Length);
                char randomChar = CharsForPassword.SmallLetters[randomIndexFromString];
                int randomIndex = rm.Next(0, sb.Length);
                sb.Insert(randomIndex, randomChar);
            }
            // getting random char from Digits
            for (int l = 0; l < charsFromDigits; l++)
            {
                int randomIndexFromString = rd.Next(0, CharsForPassword.Digits.Length);
                char randomChar = CharsForPassword.Digits[randomIndexFromString];
                int randomIndex = rm.Next(0, sb.Length);
                sb.Insert(randomIndex, randomChar);
            }
            // getting random char from SpecialChars
            for (int h = 0; h < charsFromSpecialChars; h++)
            {
                int randomIndexFromString = rd.Next(0, CharsForPassword.SpecialChars.Length);
                char randomChar = CharsForPassword.SpecialChars[randomIndexFromString];
                int randomIndex = rm.Next(0, sb.Length);
                sb.Insert(randomIndex, randomChar);
            }
            remainingLenght = passwordLenght - sb.Length;
            for (int g = 0; g < remainingLenght; g++)
            {
                int randomIndexFromString = rd.Next(0, CharsForPassword.AllChars.Length);
                char randomChar = CharsForPassword.AllChars[randomIndexFromString];
                int randomIndex = rm.Next(0, sb.Length);
                sb.Insert(randomIndex, randomChar);
            }
            

            Console.WriteLine(sb);
        }
    }
}

