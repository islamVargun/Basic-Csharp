using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace _02_variables
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region double and char
            //double variable

            // double number;
            // number = 4.89;
            // Console.WriteLine(number);

            // double applePrice = 21.25;
            //double strawberryPrice = 45.99;
            // double lemonPrice = 50.85;
            // double coconatPrice = 50.40;

            // Console.WriteLine("elma kg fiyatı: " + applePrice + " TL");
            // Console.WriteLine("çilek kg fiyatı: " + strawberryPrice + " TL");
            // Console.WriteLine("limon kg fiyatı: " + lemonPrice + " TL");
            // Console.WriteLine("coconat kg fiyatı: " + coconatPrice + " TL");
            // Console.WriteLine("-----------------------------------------------------------");


            // double appleGram = 2.5;
            // double strawberryGram = 1.250;
            // double lemonGram = 0.500;
            // double coconatGram = 4.475;

            // double totalApplePrice = appleGram * applePrice;
            // double totalStrawberryPrice = strawberryGram * strawberryPrice;
            // double totalLemonPrice = lemonGram * lemonPrice;
            // double totalCoconatPrice = coconatGram * coconatPrice;

            // Console.WriteLine(appleGram + " kilo elma aldınız. Toplam elma fiyatı: "+ totalApplePrice + " TL");
            // Console.WriteLine(strawberryGram + " kilo çilek aldınız. Toplam çilek fiyatı: " + totalStrawberryPrice + " TL");
            // Console.WriteLine(lemonGram + " kilo limon aldınız. Toplam limon fiyatı: " + totalLemonPrice + " TL");
            // Console.WriteLine(coconatGram + " kilo coconat aldınız. Toplam limon fiyatı: " + totalCoconatPrice + " TL");
            // Console.WriteLine("------------------------------------------------------------");

            // double shoppingTotalPrice = totalApplePrice + totalLemonPrice + totalStrawberryPrice + totalCoconatPrice;
            // Console.WriteLine("toplam manav siparişi tutarınız: " + shoppingTotalPrice + " Tl");


            //char sembol;
            //sembol = 'a';
            //Console.WriteLine(sembol);


            #endregion

            #region klavyeden veri giris

            // string ad,soyad;
            // Console.Write("yolcu isim: ");
            //ad = Console.ReadLine();
            // Console.Write("yolcu soyisim: ");
            // soyad = Console.ReadLine();
            // Console.WriteLine("--------------------");
            // Console.WriteLine("yolcu bilgileri: "+ ad + " " + soyad);


            #endregion

            #region klavyeden int girisler ve donusumler
            //double not1, not2, not3, ort;
            //Console.Write("not1: ");
            //not1 = double.Parse(Console.ReadLine());
            //Console.Write("not2: ");
            //not2 = double.Parse(Console.ReadLine());
            //Console.Write("not3: ");
            //not3  = double.Parse(Console.ReadLine());


            //Console.WriteLine("--");
            //Console.WriteLine("notlar:  " + not1 + "  " + not2 + "  " + not3);
            //ort =(not1 + not2 + not3)/3;
            //Console.WriteLine("ortalama: " + ort);

            #endregion

            #region if else and switch case



            //int exam1, exam2, exam3,result;

            //Console.Write("not 1: ");
            //exam1 = int.Parse(Console.ReadLine());

            //Console.Write("not 2: ");
            //exam2 = int.Parse(Console.ReadLine());

            //Console.Write("not 3: ");
            //exam3 = int.Parse(Console.ReadLine());

            //result=(exam1+exam2+exam3)/3;
            //Console.Write("ortalama: "+result);
            //Console.Write('\n');
            //if(result >= 85 )
            //{
            //    Console.Write("başarılısın dost");
            //}else if(result <= 49)
            //{
            //    Console.Write("you are very bad.");
            //}else
            //{
            //    Console.Write("ortalamasın");
            //}

            //string day1, day2, day3, day4, day5, day6, day7;
            //day1 = "Pazartesi";
            //day2 = "Salı";
            //day3 = "Çarşamba";
            //day4 = "Perşembe";
            //day5 = "Cuma";
            //day6 = "Cumartesi";
            //day7 = "Pazar";
            //int  days= int.Parse(Console.ReadLine());


            //switch (days)
            //{
            //    case 1: Console.Write("bugun pzt okulun ilk gunu sıkıcı dersler"); break;
            //    case 2: Console.Write("bugun salı database ders var"); break;
            //    case 3: Console.Write("bugun carsamba data mining var"); break;
            //    case 4: Console.Write("bugun persembe c# ve web var"); break;
            //    case 5: Console.Write("bugun cuma gorsel programlama var"); break;
            //    case 6: Console.Write("bugun cumartesi yatıs var"); break;
            //    case 7: Console.Write("bugun pazar mecbur ders var"); break;
            //}





            #endregion

            #region for dongusu ve if else ile kullanımı

            //int finishValue;
            //Console.Write("kaça tane yazdırmak istiyorsun: ");
            //finishValue = int.Parse(Console.ReadLine());
            //for (int i = 0; i <= finishValue; i++) {

            //    Console.WriteLine("sen kimsin la"+ " ");
            //}
            // int sayı;
            // Console.Write("son sayı ne olsun: ");
            //sayı=int.Parse(Console.ReadLine());
            // int count = 0;
            // Console.WriteLine(" ");
            // Console.WriteLine("Bölünenler");

            // for (int i = 1; i <= sayı; i++)
            // {
            //     if(i % 7 == 0)
            //     {
            //        count++;
            //        Console.Write(i+" ");
            //    }
            // }
            // Console.WriteLine(" ");
            // Console.WriteLine(" ");
            // Console.WriteLine("kac tane bolundu?");
            // Console.WriteLine(count);

            /*
                        int bakteri=1;
                        for (int i = 1; i <= 24; i++)
                        {
                            bakteri *= 2;
                           Console.WriteLine(i+ ". saatin sonundaki bakteri sayısı: " +bakteri);

                        }*/



            #endregion











        }
    }
}
