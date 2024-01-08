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
            int toplam = 0;
            int girilenSayi;

            do
            {
                Console.Write("Bir sayı girin: ");
                girilenSayi = Convert.ToInt32(Console.ReadLine());
                toplam += girilenSayi;
            } while (girilenSayi != 83);

            Console.WriteLine($"Toplam={toplam}");
        }
    }
}
