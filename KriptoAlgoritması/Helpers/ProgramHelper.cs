using KriptoAlgoritmasi.Abstracts;
using KriptoAlgoritmasi.Bases;
using System;
using System.Collections.Generic;
using System.Text;

namespace KriptoAlgoritmasi.Helpers
{
    public class ProgramHelper : HelperBase
    {
        public ProgramHelper()
        {
            Init();
        }

        private void Init()
        {
            var baslangicZamani = DateTime.Now;
            Yazdir("Sistem başlangıç zamanı " + string.Format("{0:dd/mm/yyyy HH:mm:ss fff}", baslangicZamani));
            Yazdir(Environment.NewLine);
            base.InitKriptoNesne();
            Yazdir(sk.Sifrele(".MeHmEd,FaTiH,tEmİz.", "11"));
            Yazdir(sk.Desifrele(".VnRvNm,OiEşR,eNvŞı.", "11"));

            Yazdir(new SezarKripto().SifrelenmisMetninAnahtariniBul(".MeHmEd,FaTiH,tEmİz.", ".VnRvNm,OiEşR,eNvŞı."));

            Yazdir(vk.Sifrele(".MeHmEd,FaTiH,tEmİz.", "key"));
            Yazdir(vk.Desifrele(".ZıGzIc,PeSuL,sÖrHj.", "key"));
            var bitisZamani = DateTime.Now;
            Yazdir(Environment.NewLine);
            Yazdir("Sistem bitiş zamanı " + string.Format("{0:dd/mm/yyyy HH:mm:ss fff}", bitisZamani));
            TimeSpan diff = bitisZamani - baslangicZamani;
            Yazdir("Calisma Suresi : " + diff.TotalMilliseconds + " msn");
            Durdur();
        }
    }
}
