using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Variables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Double Değişkenler

            //double number;

            //number = 4.85;

            //Console.WriteLine(number);



            //Console.WriteLine("***** Fiyat Listesi *****");


            //Console.WriteLine();

            //double applePrice, orangePrice, strawberryPrice, potatoPrice, tomatoPrice;

            //applePrice = 14.85;
            //orangePrice = 20.95;
            //strawberryPrice = 45;
            //potatoPrice = 9.74;
            //tomatoPrice = 6.88;

            //Console.WriteLine("---- Elma Birim Fiyatı:" + applePrice + " TL");
            //Console.WriteLine("---- Portakal Birim Fiyatı:" + orangePrice + " TL");
            //Console.WriteLine("---- Çilek Birim Fiyatı:" + strawberryPrice + " TL");
            //Console.WriteLine("---- Patates Birim Fiyatı:" + potatoPrice + " TL");
            //Console.WriteLine("---- Domates Birim Fiyatı:" + tomatoPrice + " TL");

            //Console.WriteLine();
            //Console.WriteLine();

            //double appleGram, orangeGram, strawberryGram,potatoGram, tomatoGram;

            //appleGram = 1.245;
            //orangeGram = 2.650;
            //strawberryGram = 0.750;
            //potatoGram = 4.859;
            //tomatoGram = 3.745;

            //double appleTotalPrice = applePrice * appleGram;
            //double orangeTotalPrice = orangePrice * orangeGram;
            //double strawberryTotalPrice = strawberryPrice * strawberryGram;
            //double potatoTotalPrice = potatoPrice * potatoGram;
            //double tomatoTotalPrice = tomatoPrice * tomatoGram;

            //Console.WriteLine("Alınan Ürün:Elma-"+"Birim Fiyat:"+applePrice+"- Gramaj:"+appleGram+" - Toplam Tutar:"+appleTotalPrice);

            //Console.WriteLine("Alınan Ürün:Portakal-" + "Birim Fiyat:" + orangePrice + "- Gramaj:" + orangeGram + " - Toplam Tutar:" + orangeTotalPrice);

            //Console.WriteLine("Alınan Ürün:Çilek-" + "Birim Fiyat:" + strawberryPrice + "- Gramaj:" + strawberryGram + " - Toplam Tutar:" + strawberryTotalPrice);

            //Console.WriteLine("Alınan Ürün:Patates-" + "Birim Fiyat:" + potatoPrice + "- Gramaj:" + potatoGram + " - Toplam Tutar:" + potatoTotalPrice);

            //Console.WriteLine("Alınan Ürün:Domates-" + "Birim Fiyat:" + tomatoPrice + "- Gramaj:" + tomatoGram + " - Toplam Tutar:" + tomatoTotalPrice);


            //double shoppingTotalPrice = appleTotalPrice + orangeTotalPrice + strawberryTotalPrice + potatoTotalPrice + tomatoTotalPrice;

            //Console.WriteLine();
            //Console.WriteLine();

            //Console.WriteLine("Alışveriş Toplam Tutar:" + shoppingTotalPrice + " TL"); 












            Console.Read();


            #endregion


            #region Char Değişkenler

            //ABCDEFGH
            //DEF...
            //TOPLANTI SAAT 20.00'DE
            //" '

            //    char symbol;


            //    symbol = 'a' ;

            //    Console.WriteLine(symbol);





            //Console.Read();
            #endregion


            #region Klavyeden Veri Girişleri String Değişkenler

            Console.WriteLine("****CSharp Hava Yolları Yolcu Bilgisi ****");
            Console.WriteLine();

            string passengerName, passengerSurname, passengerDistrict, passengerCity, passengerAge, passengerIdentityNumber;

            Console.Write("Yolcu Adı: ");

            passengerName = Console.ReadLine();

            Console.Write("Yolcu Soyadı: ");
            passengerSurname = Console.ReadLine();

            Console.WriteLine();

            Console.WriteLine("-------------------");

            Console.WriteLine("Yolcu: " + passengerName + " " + passengerSurname);














            #endregion

            Console.Read();







        }
    }
}
