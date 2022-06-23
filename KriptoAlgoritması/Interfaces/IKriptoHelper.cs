using System;
using System.Collections.Generic;
using System.Text;

namespace KriptoAlgoritmasi.Interfaces
{
    public interface IKriptoHelper
    {
        public  int IndeksFonksiyon(string sifrelemeTuru, string kriptoTuru, int indeks , int anahtar , char metinChr , char genislemisAnahtarChr);

        public  string Sifrele(string sifrelemeTuru, string kriptoTuru, string metin, string anahtar);

        public  int SifrelenmisMetninAnahtariniBulSezar(string metin, string sifrelenmisMetin);
    }
}
