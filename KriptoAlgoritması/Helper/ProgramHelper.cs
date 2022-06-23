using System;
using System.Collections.Generic;
using System.Text;

namespace KriptoAlgoritmasi.Helper
{
    public class ProgramHelper
    {
        private Kripto sk;
        private Kripto vk;

        public ProgramHelper()
        {
            Init();
        }

        private void Init()
        {
            sk = new SezarKripto();
            vk = new VigenereKripto();

            Yazdir(sk.Sifrele(".MeHmEd,FaTiH,tEmİz.", "11"));
            Yazdir(sk.Desifrele(".VnRvNm,OiEşR,eNvŞı.", "11"));

            Yazdir(new SezarKripto().SifrelenmisMetninAnahtariniBul(".MeHmEd,FaTiH,tEmİz.", ".VnRvNm,OiEşR,eNvŞı."));

            Yazdir(vk.Sifrele(".MeHmEd,FaTiH,tEmİz.", "key"));
            Yazdir(vk.Desifrele(".ZıGzIc,PeSuL,sÖrHj.", "key"));

            Durdur();
        }

        private void Yazdir(object obj)
        {
            Console.WriteLine(obj);
        }
        private void Durdur()
        {
            Console.ReadLine();
        }
    }
}
