using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCD_ParticalClassNedir
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri m1 = new Musteri();
            m1.id = 1;
            m1.isim = "Gamze";
            m1.soyisim = "Kural";
            m1.emailAdres = "gamzekural98@gmail.com";

            int sonuc = m1.yeniKayit(m1);
            if (sonuc>0)
            {
                Console.WriteLine("database yeni kayıt eklendi");
            }


            ogrenci o1 = new ogrenci();
            o1.id = 1;
            int ogrenciKayitSonuc = o1.yeniKayit(o1);
            if (ogrenciKayitSonuc==71777000)
            {

            }
            else if (ogrenciKayitSonuc == 71777001)
            {

            }
            else if (ogrenciKayitSonuc == 71777002)
            {

            }
            else if (ogrenciKayitSonuc == 71777003)
            {

            }
            else if (ogrenciKayitSonuc == 71777004)
            {

            }
            else
            {

            }

            Console.ReadLine();
        }
    }
}
