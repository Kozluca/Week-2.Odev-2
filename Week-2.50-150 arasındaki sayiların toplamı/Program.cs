using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week_2._50_150_arasındaki_sayiların_toplamı
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 50; //while döngüsünde kullanmak için bir int değeri olusturuyoruz sonra while içinde kullanıyoruz
            int toplam = 0; // toplam değeri yazdırmak icin int değeri atıyoruz
            while (a < 150)
            {
                a++;
                toplam = toplam + a;
            }
            Console.WriteLine("50-150 arasındaki sayıların toplamı : " + toplam);
            Console.ReadKey();
        }
    }
}
