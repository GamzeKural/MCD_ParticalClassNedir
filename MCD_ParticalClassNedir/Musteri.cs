using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCD_ParticalClassNedir
{
    public class Musteri
    {
        #region Fields

        public int id { get; set; }
        public string isim { get; set; }
        public string soyisim { get; set; }
        public string emailAdres { get; set; }

        #endregion


        #region Metot

        public int yeniKayit(Musteri m)
        {
            Console.WriteLine("database kayıt işlemi tamamlandı.");
            return 1;
        }

        public int kayitGuncelle(Musteri m)
        {
            Console.WriteLine("müşteri kaydı güncellendi.");
            return 1;
        }

        public int kayitSil(Musteri m)
        {
            Console.WriteLine("müşteri kaydı silindi.");
            return 1;
        }

        #endregion
    }
}
