using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Hello World!");
            // öğrencinin notu 50 den küçükse kaldı 50 den büyük ise geçti , not 100 e eşit ise onur belgesi aldı.

            git:
            Console.WriteLine("Öğrencinin Notunu Giriniz");
            byte not = Convert.ToByte(Console.ReadLine());
            if (not < 50 && not > 0)
            {
                Console.WriteLine("Kaldı");
            }
            else if (not == 100)
            {
                Console.WriteLine("Onur Belgesi Aldı");
            }
            else if (not > 100 || not < 0)
            {
                Console.WriteLine("Hatalı Not Girişi 0-100 arasında bir not giriniz");
                goto git;
            }
            else
            {
                Console.WriteLine("Geçti");
            }
        }
    }
}