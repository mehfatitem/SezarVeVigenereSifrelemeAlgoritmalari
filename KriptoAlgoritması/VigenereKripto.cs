using System;
using System.Collections.Generic;
using System.Text;

namespace KriptoAlgoritmasi
{
    public class VigenereKripto : Kripto
    {
        private int indeks;
        private string sonuc;
        private List<string> alfabe;

        public override string Sifrele(string sifrelenecekMetin, string anahtar)
        {
            return this.Sifrele(sifrelenecekMetin, anahtar, "sifre");
        }
        public override string Desifrele(string desifrelenecekMetin, string anahtar)
        {
            return this.Sifrele(desifrelenecekMetin, anahtar, "desifre");
        }
        private string AnahtariGenislet(string metin, string anahtar)
        {
            string sonuc = string.Empty;
            int anahtarIndex = 0;
            for (var i = 0; i < metin.Length; i++)
            {
                if(char.IsLetter(metin[i]))
                {
                    if (anahtarIndex % anahtar.Length == 0)
                        anahtarIndex = 0;
                    if (char.IsLetter(anahtar[anahtarIndex]))
                        sonuc += anahtar[anahtarIndex];
                    anahtarIndex++;
                } else
                {
                    sonuc += " ";
                }
            }

            return sonuc;
        }
        private string Sifrele(string metin, string anahtar, string sifrelemeTuru)
        {
            sonuc = String.Empty;
            string genislemisAnahtar = this.AnahtariGenislet(metin, anahtar);
            genislemisAnahtar = genislemisAnahtar.ToUpper();


            for (var i = 0; i < metin.Length; i++)
            {
                if (char.IsLetter(metin[i]))
                {

                    if (char.IsUpper(metin[i]))
                    {
                        alfabe = BuyukAlfabe;
                    }
                    else if (char.IsLower(metin[i]))
                    {
                        alfabe = KucukAlfabe;
                    }
                    switch (sifrelemeTuru)
                    {
                        case "desifre":
                            indeks = (alfabe.IndexOf(metin[i].ToString()) - BuyukAlfabe.IndexOf(genislemisAnahtar[i].ToString()) + alfabeUzunlugu) % alfabeUzunlugu;
                            break;
                        case "sifre":
                            indeks = (alfabe.IndexOf(metin[i].ToString()) + BuyukAlfabe.IndexOf(genislemisAnahtar[i].ToString()) + alfabeUzunlugu) % alfabeUzunlugu;
                            break;
                        default:
                            Console.WriteLine("Hatali şifreleme turu!");
                            break;
                    }

                    sonuc += alfabe[indeks];
                }
                else
                {
                    sonuc += metin[i];
                }
            }
            return sonuc;
        }
    }
}
