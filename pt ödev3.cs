using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("İKİ sayı girin:");
            int sayi1 = Convert.ToInt32(Console.ReadLine());
            int sayi2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("TEK’leri mi ÇİFT’leri mi toplamak istersiniz? (TEK/ÇİFT)");
            string secim = Console.ReadLine().ToUpper();

            int toplam = 0;

            if (secim == "TEK")
            {
                for (int i = Math.Min(sayi1, sayi2); i <= Math.Max(sayi1, sayi2); i++)
                {
                    if (i % 2 != 0)
                    {
                        toplam += i;
                    }
                }
                Console.WriteLine("Girilen aralıktaki TEK sayıların toplamı: " + toplam);
            }
            else if (secim == "ÇİFT")
            {
                for (int i = Math.Min(sayi1, sayi2); i <= Math.Max(sayi1, sayi2); i++)
                {
                    if (i % 2 == 0)
                    {
                        toplam += i;
                    }
                }
                Console.WriteLine("Girilen aralıktaki ÇİFT sayıların toplamı: " + toplam);
            }
            else
            {
                Console.WriteLine("Geçersiz seçim!");
            }
        }
    }
}