using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace inheritance
{
    public class BaseKisi
    {
        public string Ad;
        public string Soyad;

       void AdSoyad()
        {
            Console.WriteLine(Ad + Soyad);
        }
    }

    public class ogrenci : BaseKisi
    {
        public string ogrenciNo;
        
        void ogrenciBilgi ()
        {
            Console.WriteLine(Ad + Soyad + ogrenciNo);
        }
    }

    public class ogretmen : BaseKisi
    {
        public string Maas;

        void ogretmenBilgi()
        {
            Console.WriteLine(Ad + Soyad + Maas);
        }

    }
}
