using KriptoAlgoritmasi.Abstracts;

namespace KriptoAlgoritmasi.Kriptos
{
    public class VigenereKripto : Kripto
    {
        public override string Sifrele(string sifrelenecekMetin, string anahtar)
        {
            return kh.Sifrele(IslemSifre, VigenereKripto, sifrelenecekMetin, anahtar);
        }
        public override string Desifrele(string desifrelenecekMetin, string anahtar)
        {
            return kh.Sifrele(IslemDesifre, VigenereKripto, desifrelenecekMetin, anahtar);
        }
    }
}
