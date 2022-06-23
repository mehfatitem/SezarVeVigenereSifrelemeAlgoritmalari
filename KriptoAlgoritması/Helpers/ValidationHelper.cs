using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace KriptoAlgoritmasi.Helpers
{
    public static class ValidationHelper
    {
        private static readonly string regxIsOnlyLettersStr = @"^[a-zA-Z]+$";

        public static bool IsLetter(char chr)
        {
            return char.IsLetter(chr);
        }

        public static bool IsUpper(char chr)
        {
            return char.IsUpper(chr);
        }

        public static bool IsLower(char chr)
        {
            return char.IsLower(chr);
        }

        public static bool IsOnlyLetters(string str)
        {
            return Regex.IsMatch(str, regxIsOnlyLettersStr);

        }
    }
}
