using KriptoAlgoritmasi.Abstracts;
using KriptoAlgoritmasi.Bases;
using KriptoAlgoritmasi.Kriptos;
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
            Yazdir(sk.Sifrele(".MeHmEd,FaTiH,tEmİz.", "-11"));
            Yazdir(sk.Desifrele(".DtYdTş,UöJaY,jTdAo.", "-11"));

            Yazdir(new SezarKripto().SifrelenmisMetninAnahtariniBul(".MeHmEd,FaTiH,tEmİz.", ".DtYdTş,UöJaY,jTdAo."));

            Yazdir(vk.Sifrele("HaMI.AYHAN", "fatih"));
            Yazdir(vk.Desifrele("MaHS.HDHTY", "fatih"));
            var bitisZamani = DateTime.Now;
            Yazdir(Environment.NewLine);
            Yazdir("Sistem bitiş zamanı " + string.Format("{0:dd/mm/yyyy HH:mm:ss fff}", bitisZamani));
            TimeSpan diff = bitisZamani - baslangicZamani;
            Yazdir("Calisma Suresi : " + diff.TotalMilliseconds + " msn");
            Durdur();
        }
    }
}
