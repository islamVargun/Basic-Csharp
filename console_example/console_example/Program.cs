using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace console_example
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //message msg = new message();
            //msg.print();

            kisiler person = new kisiler();
            string ad;

            Console.Write("Adınızı giriniz: ");
            ad = Console.ReadLine();
            person.kisilistesi(ad);
            Console.Read();
        }
    }
}
