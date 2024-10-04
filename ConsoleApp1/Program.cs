using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("**** CSharp Hava Yolları Yolcu Bilgisi ****");
            Console.WriteLine();

            string passengerName, passengerSurname, passengerDistrict, passengerCity, passengerAge, passengerIdentityNumber;

            Console.Write("Yolcu Adı:");

            passengerName = Console.ReadLine();

            Console.Write("Yolcu Soyadı: ");
            passengerSurname = Console.ReadLine();


            Console.WriteLine();

            Console.WriteLine("-------------------");
            Console.WriteLine("Yolcu: " + passengerName + " " + passengerSurname);
        }
    }
}
