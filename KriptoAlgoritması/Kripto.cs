using System;
using System.Collections.Generic;
using System.Text;

namespace KriptoAlgoritmasi
{
    public abstract class Kripto
    {
        protected const int alfabeUzunlugu = 29;

        private List<string> _kucukAlfabe = new List<string> { "a","b","c","ç","d","e","f","g","ğ","h","ı","i","j","k","l","m","n","o","ö","p","r","s","ş","t","u","ü","v","y","z"};
        private List<string> _buyukAlfabe = new List<string> { "A", "B", "C", "Ç", "D", "E", "F", "G", "Ğ", "H", "I", "İ", "J", "K", "L", "M", "N", "O", "Ö", "P", "R", "S", "Ş", "T", "U", "Ü", "V", "Y", "Z" };

        protected List<string> KucukAlfabe { get => _kucukAlfabe; set => _kucukAlfabe = value; }
        protected List<string> BuyukAlfabe { get => _buyukAlfabe; set => _buyukAlfabe = value; }

        public abstract string Sifrele(string sifrelenecekMetin , string anahtar);
        public abstract string Desifrele(string desifrelenecekMetin , string anahtar);
    }
}
