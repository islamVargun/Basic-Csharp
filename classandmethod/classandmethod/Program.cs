using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classandmethod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //islem isl = new islem();
            // isl.topla(2, 4);
            // isl.topla(3, 5);
            // isl.topla(6, 7);
            // isl.kare(5);
            // isl.kup(3);
            // isl.kup(4);
            //student st = new student();
            kimlik km = new kimlik();
            Console.WriteLine(km.AD);
            Console.WriteLine(km.SOYAD);
            Console.WriteLine(km.MEMLEKET);
            Console.WriteLine(km.YAS);
            Console.WriteLine(km.CINSIYET);
            Console.ReadKey();
        }
    }
}
