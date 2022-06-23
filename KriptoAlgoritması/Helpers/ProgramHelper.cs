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
            base.InitKriptoNesne();
            Yazdir(sk.Sifrele(".MeHmEd,FaTiH,tEmİz.", "11"));
            Yazdir(sk.Desifrele(".VnRvNm,OiEşR,eNvŞı.", "11"));

            Yazdir(new SezarKripto().SifrelenmisMetninAnahtariniBul(".MeHmEd,FaTiH,tEmİz.", ".VnRvNm,OiEşR,eNvŞı."));

            Yazdir(vk.Sifrele(".MeHmEd,FaTiH,tEmİz.", "key"));
            Yazdir(vk.Desifrele(".ZıGzIc,PeSuL,sÖrHj.", "key"));

            Durdur();
        }
    }
}
