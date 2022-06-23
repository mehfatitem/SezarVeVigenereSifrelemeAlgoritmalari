using System;
using System.Collections.Generic;
using System.Text;

namespace KriptoAlgoritmasi.Helpers
{
    public static class ValidationHelper
    {

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


    }
}
