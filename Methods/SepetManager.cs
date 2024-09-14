using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    internal class SepetManager
    {
        public void Ekle(Urun urun)
        {
            Console.WriteLine( " tebrikler sepete eklendi : " +urun.Adi);
        }

        public void Ekle2(string urunAdi, string Aciklama, double fiyat, int stokadedi)
        {
            Console.WriteLine( "tebrikler, sepete ekledi : " +urunAdi);
        }
    }
}
