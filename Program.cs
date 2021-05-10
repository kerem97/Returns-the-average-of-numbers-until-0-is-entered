using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample7
{
    class Program
    {
        static void Main(string[] args)
        {
            int toplam = 0, sayi;
            int sayac = 0;
            double ort = 0;
            do
            {
                Console.Write("Sayı girin : ");
                sayi = int.Parse(Console.ReadLine());
                toplam += sayi;
                sayac++;
                ort = (double)toplam / sayac;


            } while (sayi != 0);
            Console.WriteLine("Toplam={0}", toplam);
            Console.WriteLine("ORtalama={0}", ort);
            Console.ReadKey();
        }
    }
}
