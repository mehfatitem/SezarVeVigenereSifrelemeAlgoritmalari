using KriptoAlgoritmasi.Interfaces;
using System;
using System.Collections.Generic;
using KriptoAlgoritmasi.Bases;

namespace KriptoAlgoritmasi.Helpers
{
    public class KriptoHelper : HelperBase, IKriptoHelper
    {

        #region "Degiskenler"
        private int yeniIndeks;
        private string kriptoSonuc;
        private List<string> alfabe;
        #endregion


        #region "Metotlar"
        public int IndeksFonksiyon(string sifrelemeTuru, string kriptoTuru, int indeks = 0, int anahtar = 0, char metinChr = '\0', char genislemisAnahtarChr = '\0')
        {

            switch (kriptoTuru)
            {
                case SezarKripto:
                    switch (sifrelemeTuru)
                    {
                        case IslemDesifre:
                            yeniIndeks = ((indeks - anahtar + AlfabeUzunlugu) % AlfabeUzunlugu);
                            break;
                        case IslemSifre:
                            yeniIndeks = ((indeks + anahtar + AlfabeUzunlugu) % AlfabeUzunlugu);
                            break;
                        default:
                            Console.WriteLine(HataliSifrelemeTuru);
                            break;
                    }
                    break;
                case VigenereKripto:
                    switch (sifrelemeTuru)
                    {
                        case IslemDesifre:
                            yeniIndeks = (alfabe.IndexOf(metinChr.ToString()) - BuyukAlfabe.IndexOf(genislemisAnahtarChr.ToString()) + AlfabeUzunlugu) % AlfabeUzunlugu;
                            break;
                        case IslemSifre:
                            yeniIndeks = (alfabe.IndexOf(metinChr.ToString()) + BuyukAlfabe.IndexOf(genislemisAnahtarChr.ToString()) + AlfabeUzunlugu) % AlfabeUzunlugu;
                            break;
                        default:
                            Console.WriteLine(HataliKriptoAlgoritmaTuru);
                            break;
                    }
                    break;
                default:
                    Console.WriteLine(HataliKriptoAlgoritmaTuru);
                    break;
            }
            return yeniIndeks;
        }

        public string Sifrele(string sifrelemeTuru, string kriptoTuru, string metin, string anahtar)
        {
            kriptoSonuc = "";
            switch (kriptoTuru)
            {
                case SezarKripto:
                    if (!ValidationHelper.IsSignedInteger(anahtar))
                    {
                        Yazdir(UyumsuzAnahtarSezar);
                        return "";
                    }   
                    int yeniAnahtar = Convert.ToInt32(anahtar) % AlfabeUzunlugu;
                    for (int i = 0; i < metin.Length; i++)
                    {
                        if (char.IsLetter(metin[i]))
                        {
                            alfabe = char.IsUpper(metin[i]) ? BuyukAlfabe : KucukAlfabe;
                            int indeks = alfabe.IndexOf(metin[i].ToString());
                            int yeniIndeks = IndeksFonksiyon(sifrelemeTuru, SezarKripto, indeks, yeniAnahtar);
                            kriptoSonuc += alfabe[yeniIndeks];
                        }
                        else
                            kriptoSonuc += metin[i];
                    }
                    break;
                case VigenereKripto:
                    if (!ValidationHelper.IsOnlyLetters(anahtar)){
                        Yazdir(UyumsuzAnahtarVigenere);
                        return "";
                    }
                    string genislemisAnahtar = AnahtariGenisletVigenere(metin, anahtar);
                    genislemisAnahtar = genislemisAnahtar.ToUpper();
                    for (var i = 0; i < metin.Length; i++)
                    {
                        if (char.IsLetter(metin[i]))
                        {
                            alfabe = char.IsUpper(metin[i]) ? BuyukAlfabe : KucukAlfabe;
                            int indeks = IndeksFonksiyon(sifrelemeTuru, VigenereKripto, 0, 0, metin[i], genislemisAnahtar[i]);
                            kriptoSonuc += alfabe[indeks];
                        }
                        else
                            kriptoSonuc += metin[i];
                    }
                    break;
                default:
                    Console.WriteLine(HataliKriptoAlgoritmaTuru);
                    break;
            }

            return kriptoSonuc;
        }

        public int SifrelenmisMetninAnahtariniBulSezar(string metin, string sifrelenmisMetin)
        {
            int anahtar = 0;
            for (int i = 0; i < metin.Length; i++)
            {
                if (char.IsLetter(metin[i]))
                {
                    alfabe = char.IsUpper(metin[i]) ? BuyukAlfabe : KucukAlfabe;
                    int metinIndeks = alfabe.IndexOf(metin[i].ToString());
                    int sifrelenmisMetinIndeks = alfabe.IndexOf(sifrelenmisMetin[i].ToString());
                    anahtar = sifrelenmisMetinIndeks - metinIndeks % AlfabeUzunlugu;
                    break;
                }
            }
            return anahtar;
        }

        private string AnahtariGenisletVigenere(string metin, string anahtar)
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
        #endregion
    }
}
