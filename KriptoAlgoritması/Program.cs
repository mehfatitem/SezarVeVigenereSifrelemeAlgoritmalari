using System;

namespace KriptoAlgoritmasi
{
    class Program
    {
        static void Main(string[] args)
        {
            Kripto sk = new SezarKripto();
            Kripto vk = new VigenereKripto();

            Console.WriteLine(sk.Sifrele(".MeHmEd,FaTiH,tEmİz.", "11"));
            Console.WriteLine(sk.Desifrele(".VnRvNm,OiEşR,eNvŞı.", "11")); 

            Console.WriteLine(new SezarKripto().SifrelenmisMetninAnahtariniBul(".MeHmEd,FaTiH,tEmİz.", ".VnRvNm,OiEşR,eNvŞı."));

            Console.WriteLine(vk.Sifrele(".MeHmEd,FaTiH,tEmİz.", "key"));
            Console.WriteLine(vk.Desifrele(".ZıGzIc,PeSuL,sÖrHj.", "key"));


            Console.ReadLine();
        }
    }
}
