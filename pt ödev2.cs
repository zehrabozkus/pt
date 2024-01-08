using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bir sayı girin:");
            int sayi = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("TEK’leri mi ÇİFT’leri mi toplamak istersiniz? (TEK/ÇİFT)");
            string tercih = Console.ReadLine().ToUpper();

            int toplam = 0;

            if (tercih == "TEK")
            {
                for (int i = 1; i <= sayi; i += 2)
                {
                    toplam += i;
                }
            }
            else if (tercih == "ÇİFT")
            {
                for (int i = 2; i <= sayi; i += 2)
                {
                    toplam += i;
                }
            }
            else
            {
                Console.WriteLine("Geçersiz seçim yaptınız.");
                return;
            }

            Console.WriteLine($"1 ile {sayi} arasındaki {tercih} sayıların toplamı: {toplam}");
        }
    }
}
