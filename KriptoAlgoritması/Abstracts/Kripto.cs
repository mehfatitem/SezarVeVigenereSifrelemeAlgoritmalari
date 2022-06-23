using KriptoAlgoritmasi.Constants;
using KriptoAlgoritmasi.Helpers;

namespace KriptoAlgoritmasi.Abstracts
{
    public abstract class Kripto
    {

        #region "Helper nesneler"
        protected KriptoHelper kh = new KriptoHelper();
        #endregion

        #region "Sabitler"
        protected readonly string IslemSifre = ConstantsKripto.IslemSifre;
        protected readonly string IslemDesifre = ConstantsKripto.IslemDesifre;
        protected readonly string SezarKripto = ConstantsKripto.SezarKripto;
        protected readonly string VigenereKripto = ConstantsKripto.VigenereKripto;
        #endregion

        #region "Ana metotlar"
        public abstract string Sifrele(string sifrelenecekMetin, string anahtar);
        public abstract string Desifrele(string desifrelenecekMetin, string anahtar);
        #endregion
    }
}
