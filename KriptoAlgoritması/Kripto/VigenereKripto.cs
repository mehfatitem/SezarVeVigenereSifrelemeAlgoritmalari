using KriptoAlgoritmasi.Helper;
using System;
using System.Collections.Generic;
using System.Text;

namespace KriptoAlgoritmasi
{
    public class VigenereKripto : Kripto
    {
        public override string Sifrele(string sifrelenecekMetin, string anahtar)
        {
            return KriptoHelper.Sifrele(IslemSifre, VigenereKripto, sifrelenecekMetin, anahtar);
        }
        public override string Desifrele(string desifrelenecekMetin, string anahtar)
        {
            return KriptoHelper.Sifrele(IslemDesifre, VigenereKripto, desifrelenecekMetin, anahtar);
        }
    }
}
