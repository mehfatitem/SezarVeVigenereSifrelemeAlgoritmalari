using KriptoAlgoritmasi.Abstracts;
using KriptoAlgoritmasi.Constants;
using System;
using System.Collections.Generic;
using System.Text;

namespace KriptoAlgoritmasi.Bases
{
    public class HelperBase
    {
        #region "Kripto nesneler"
        protected Kripto sk;
        protected Kripto vk;
        #endregion

        #region "Degiskenler"
        private List<string> _kucukAlfabe = new List<string> { "a", "b", "c", "ç", "d", "e", "f", "g", "ğ", "h", "ı", "i", "j", "k", "l", "m", "n", "o", "ö", "p", "r", "s", "ş", "t", "u", "ü", "v", "y", "z" };
        private List<string> _buyukAlfabe = new List<string> { "A", "B", "C", "Ç", "D", "E", "F", "G", "Ğ", "H", "I", "İ", "J", "K", "L", "M", "N", "O", "Ö", "P", "R", "S", "Ş", "T", "U", "Ü", "V", "Y", "Z" };
        #endregion

        #region "Özellikler"
        protected List<string> KucukAlfabe { get => _kucukAlfabe; set => _kucukAlfabe = value; }
        protected List<string> BuyukAlfabe { get => _buyukAlfabe; set => _buyukAlfabe = value; }
        #endregion

        #region "Sabitler"
        protected const string IslemSifre = ConstantsKripto.IslemSifre;
        protected const string IslemDesifre = ConstantsKripto.IslemDesifre;
        protected const string SezarKripto = ConstantsKripto.SezarKripto;
        protected const string VigenereKripto = ConstantsKripto.VigenereKripto;
        protected readonly int AlfabeUzunlugu = ConstantsKripto.AlfabeUzunlugu;
        protected readonly string HataliSifrelemeTuru = ConstantsKripto.HataliSifrelemeTuru;
        protected readonly string HataliKriptoAlgoritmaTuru = ConstantsKripto.HataliKriptoAlgoritmaTuru;
        #endregion

        #region "Kurucu"
        public HelperBase()
        {
        }
        #endregion

        #region "Init Kripto Nesne"
        protected void InitKriptoNesne()
        {
            sk = new SezarKripto();
            vk = new VigenereKripto();
        }
        #endregion 

        #region "Yardimci metotlar"
        protected void Yazdir(object obj)
        {
            Console.WriteLine(obj);
        }
        protected void Durdur()
        {
            Console.ReadLine();
        }
        #endregion
    }
}
