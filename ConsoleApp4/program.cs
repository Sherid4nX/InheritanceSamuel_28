using System;

namespace GameInheritanceDemo
{
    class Program
    {
        static void Main(String[] agrs)
        {
            Console.WriteLine("--- DEMO INHERITANCE ---\n");

            Console.WriteLine("1. Membuat objek Suki (dengan konstruktor berparameter)");
            Suki suki = new Suki(50, "Liar-001", "HamJab", 100, "Rongawi");
            suki.DisplayData();

            Console.WriteLine("\n2. Membuat objek Dukun (dengan konstruktor berparameter)");
            Dukun dukun = new Dukun(80, "WM-001", "IqAs", 90, "Cimahi");
            dukun.DisplayData();

            Console.WriteLine("\n3. Membuat objek Sunda (dengan konstruktor berparameter)");
            Sunda sunda = new Sunda(120, 80, "SG-777", "Ujang", 110, "Jawa Barat");
            sunda.DisplayData1();
            


            Console.ReadKey();
        }
    }
}