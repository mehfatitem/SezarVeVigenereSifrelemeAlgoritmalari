using KriptoAlgoritmasi.Abstracts;
using KriptoAlgoritmasi.Constants;

namespace KriptoAlgoritmasi
{
    public class SezarKripto : Kripto
    {
        public override string Sifrele(string sifrelenecekMetin, string anahtar)
        {
            return kh.Sifrele(IslemSifre, SezarKripto, sifrelenecekMetin, anahtar);
        }
        public override string Desifrele(string desifrelenecekMetin, string anahtar)
        {
            return kh.Sifrele(IslemDesifre, SezarKripto, desifrelenecekMetin, anahtar);
        }

        public int SifrelenmisMetninAnahtariniBul(string metin, string anahtar)
        {
            return kh.SifrelenmisMetninAnahtariniBulSezar(metin, anahtar);
        }
    }
}
