using System;
using System.Collections.Generic;
using System.Text;

namespace KriptoAlgoritmasi.Helper
{
    public class KriptoHelper
    {

        private static int yeniIndeks;
        private static string kriptoSonuc;
        private static List<string> alfabe;
        private static List<string> _kucukAlfabe = new List<string> { "a", "b", "c", "ç", "d", "e", "f", "g", "ğ", "h", "ı", "i", "j", "k", "l", "m", "n", "o", "ö", "p", "r", "s", "ş", "t", "u", "ü", "v", "y", "z" };
        private  static List<string> _buyukAlfabe = new List<string> { "A", "B", "C", "Ç", "D", "E", "F", "G", "Ğ", "H", "I", "İ", "J", "K", "L", "M", "N", "O", "Ö", "P", "R", "S", "Ş", "T", "U", "Ü", "V", "Y", "Z" };

        private static List<string> KucukAlfabe { get => _kucukAlfabe; set => _kucukAlfabe = value; }
        private static List<string> BuyukAlfabe { get => _buyukAlfabe; set => _buyukAlfabe = value; }

        public static int IndeksFonksiyon(string sifrelemeTuru, string kriptoTuru, int indeks = 0, int anahtar = 0, char metinChr = '\0', char genislemisAnahtarChr = '\0')
        {

            switch (kriptoTuru)
            {
                case ConstantsKripto.SezarKripto:
                    switch (sifrelemeTuru)
                    {
                        case ConstantsKripto.IslemDesifre:
                            yeniIndeks = ((indeks - anahtar + ConstantsKripto.AlfabeUzunlugu) % ConstantsKripto.AlfabeUzunlugu);
                            break;
                        case ConstantsKripto.IslemSifre:
                            yeniIndeks = ((indeks + anahtar + alfabe.Count) % alfabe.Count);
                            break;
                        default:
                            Console.WriteLine("Hatali şifreleme turu!");
                            break;
                    }
                    break;
                case ConstantsKripto.VigenereKripto:
                    switch (sifrelemeTuru)
                    {
                        case ConstantsKripto.IslemDesifre:
                            yeniIndeks = (alfabe.IndexOf(metinChr.ToString()) - BuyukAlfabe.IndexOf(genislemisAnahtarChr.ToString()) + ConstantsKripto.AlfabeUzunlugu) % ConstantsKripto.AlfabeUzunlugu;
                            break;
                        case ConstantsKripto.IslemSifre:
                            yeniIndeks = (alfabe.IndexOf(metinChr.ToString()) + BuyukAlfabe.IndexOf(genislemisAnahtarChr.ToString()) + ConstantsKripto.AlfabeUzunlugu) % ConstantsKripto.AlfabeUzunlugu;
                            break;
                        default:
                            Console.WriteLine("Hatali şifreleme turu!");
                            break;
                    }
                    break;
                default:
                    Console.WriteLine("Hatali kripto algoritmasi turu!");
                    break;
            }
            return yeniIndeks;
        }

        public static string Sifrele(string sifrelemeTuru, string kriptoTuru, string metin, string anahtar)
        {
            kriptoSonuc = "";
            switch (kriptoTuru)
            {
                case ConstantsKripto.SezarKripto:
                    int yeniAnahtar = Convert.ToInt32(anahtar) % ConstantsKripto.AlfabeUzunlugu;
                    for (int i = 0; i < metin.Length; i++)
                    {
                        if (char.IsLetter(metin[i]))
                        {
                            alfabe = char.IsUpper(metin[i]) ? BuyukAlfabe : KucukAlfabe;
                            int indeks = alfabe.IndexOf(metin[i].ToString());
                            int yeniIndeks = KriptoHelper.IndeksFonksiyon(sifrelemeTuru, ConstantsKripto.SezarKripto, indeks, yeniAnahtar);
                            kriptoSonuc += alfabe[yeniIndeks];
                        }
                        else
                            kriptoSonuc += metin[i];
                    }
                    break;
                case ConstantsKripto.VigenereKripto:
                    string genislemisAnahtar = AnahtariGenisletVigenere(metin, anahtar);
                    genislemisAnahtar = genislemisAnahtar.ToUpper();
                    for (var i = 0; i < metin.Length; i++)
                    {
                        if (char.IsLetter(metin[i]))
                        {
                            alfabe = char.IsUpper(metin[i]) ? BuyukAlfabe : KucukAlfabe;
                            int indeks = KriptoHelper.IndeksFonksiyon(sifrelemeTuru, ConstantsKripto.VigenereKripto, 0, 0, metin[i], genislemisAnahtar[i]);
                            kriptoSonuc += alfabe[indeks];
                        }
                        else
                            kriptoSonuc += metin[i];
                    }
                    break;
                default:
                    Console.WriteLine("Hatali kripto algoritmasi turu!");
                    break;
            }

            return kriptoSonuc;
        }

        public static int SifrelenmisMetninAnahtariniBulSezar(string metin, string sifrelenmisMetin)
        {
            int anahtar = 0;
            for (int i = 0; i < metin.Length; i++)
            {
                if (char.IsLetter(metin[i]))
                {
                    alfabe = char.IsUpper(metin[i]) ? BuyukAlfabe : KucukAlfabe;
                    int metinIndeks = alfabe.IndexOf(metin[i].ToString());
                    int sifrelenmisMetinIndeks = alfabe.IndexOf(sifrelenmisMetin[i].ToString());
                    anahtar = sifrelenmisMetinIndeks - metinIndeks % ConstantsKripto.AlfabeUzunlugu;
                    break;
                }
            }
            return anahtar;
        }

        private static string AnahtariGenisletVigenere(string metin, string anahtar)
        {
            string sonuc = string.Empty;
            int anahtarIndex = 0;
            for (var i = 0; i < metin.Length; i++)
            {
                if (char.IsLetter(metin[i]))
                {
                    if (anahtarIndex % anahtar.Length == 0)
                        anahtarIndex = 0;
                    if (char.IsLetter(anahtar[anahtarIndex]))
                        sonuc += anahtar[anahtarIndex];
                    anahtarIndex++;
                }
                else
                    sonuc += " ";
            }

            return sonuc;
        }
    }
}
