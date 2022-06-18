using System;
using System.Collections.Generic;
using System.Text;

namespace KriptoAlgoritmasi
{
    public class SezarKripto : Kripto
    {
        private int indeks;
        private int yeniIndeks;
        private int yeniAnahtar;
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
        private string Sifrele(string metin, string anahtar, string sifrelemeTuru)
        {
            sonuc = String.Empty;
            yeniAnahtar = Convert.ToInt32(anahtar) % alfabeUzunlugu;
            for (int i = 0; i < metin.Length; i++)
            {
                if (char.IsLetter(metin[i]))
                {
                    if (char.IsLower(metin[i]))
                    {
                        alfabe = KucukAlfabe;
                    }
                    else if (char.IsUpper(metin[i]))
                    {
                        alfabe = BuyukAlfabe;
                    }

                    indeks = alfabe.IndexOf(metin[i].ToString());

                    switch (sifrelemeTuru)
                    {
                        case "desifre":
                            yeniIndeks = ((indeks - yeniAnahtar + alfabeUzunlugu) % alfabeUzunlugu);
                            break;
                        case "sifre":
                            yeniIndeks = ((indeks + yeniAnahtar + alfabeUzunlugu) % alfabeUzunlugu);
                            break;
                        default:
                            Console.WriteLine("Hatali şifreleme turu!");
                            break;
                    }

                    sonuc += alfabe[yeniIndeks];

                }
                else
                {
                    sonuc += metin[i];
                }
            }
            return sonuc;
        }
        public int SifrelenmisMetninAnahtariniBul(string metin, string sifrelenmisMetin)
        {
            int anahtar = 0;
            for (int i = 0; i < metin.Length; i++)
            {
                if (char.IsLetter(metin[i]))
                {
                    if (char.IsLower(metin[i]))
                    {
                        alfabe = KucukAlfabe;

                    }
                    else if (char.IsUpper(metin[i]))
                    {
                        alfabe = BuyukAlfabe;
                    }
                    int metinIndeks = alfabe.IndexOf(metin[i].ToString());
                    int sifrelenmisMetinIndeks = alfabe.IndexOf(sifrelenmisMetin[i].ToString());
                    anahtar = sifrelenmisMetinIndeks - metinIndeks % alfabeUzunlugu;
                    break;
                }
            }
            return anahtar;
        }
    }
}
