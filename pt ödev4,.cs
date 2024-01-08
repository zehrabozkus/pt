using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zehra
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kaç adet sayı girmek istersiniz?");
            int adet = Convert.ToInt32(Console.ReadLine());

            int toplam = 0;
            double ortalama = 0;

            for (int i = 1; i <= adet; i++)
            {
                Console.WriteLine($"{i}. sayıyı girin:");
                int sayi = Convert.ToInt32(Console.ReadLine());
                toplam += sayi;
            }

            ortalama = (double)toplam / adet;

            Console.WriteLine($"Girilen {adet} adet sayının toplamı: {toplam}");
            Console.WriteLine($"Girilen {adet} adet sayının ortalaması: {ortalama}");
        }
    }
}
