using System;
using System.Collections.Generic;
using System.Text;

namespace KriptoAlgoritmasi
{
    public abstract class Kripto
    {

        protected readonly string IslemSifre = ConstantsKripto.IslemSifre;
        protected readonly string IslemDesifre = ConstantsKripto.IslemDesifre;
        protected readonly string SezarKripto = ConstantsKripto.SezarKripto;
        protected readonly string VigenereKripto = ConstantsKripto.VigenereKripto;

        public abstract string Sifrele(string sifrelenecekMetin , string anahtar);
        public abstract string Desifrele(string desifrelenecekMetin , string anahtar);
    }
}
