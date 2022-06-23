using KriptoAlgoritmasi.Helper;
using System;
using System.Collections.Generic;
using System.Text;

namespace KriptoAlgoritmasi
{
    public class SezarKripto : Kripto
    {

        public override string Sifrele(string sifrelenecekMetin, string anahtar)
        {
            return KriptoHelper.Sifrele(ConstantsKripto.IslemSifre, ConstantsKripto.SezarKripto, sifrelenecekMetin, anahtar);
        }
        public override string Desifrele(string desifrelenecekMetin, string anahtar)
        {
            return KriptoHelper.Sifrele(ConstantsKripto.IslemDesifre, ConstantsKripto.SezarKripto, desifrelenecekMetin, anahtar);
        }

        public  int SifrelenmisMetninAnahtariniBul(string metin , string anahtar)
        {
            return KriptoHelper.SifrelenmisMetninAnahtariniBulSezar(metin, anahtar);
        }
    }
}
