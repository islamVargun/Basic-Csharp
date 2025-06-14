using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classandmethod
{
    internal class islem
    {
        public int topla(int sayi1, int sayi2)
        {
            int sonuc = sayi1 + sayi2;
            Console.WriteLine("toplam: " +sonuc);
            return sonuc;
        }
        public int kare(int sayi)
        {
            int sonuc = sayi * sayi;
            Console.WriteLine("karesi: " + sonuc);
            return sonuc;
        }
        public int kup(int sayi)
        {
            int sonuc = sayi * sayi * sayi;
            Console.WriteLine("küpü: " + sonuc);
            return sonuc;
        }

    }
}
