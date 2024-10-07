using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week_2._1ile120_arasındaki_tek_ve_öift_sayiların_toplamı
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 0; //while döngüsünde kullanmak için bir int değeri olusturuyoruz sonra while içinde kullanıyoruz
            int tek = 0; // tek sayılar toplamı icin int olusuturuyoruz
            int çift = 0; // çift sayılar toplamı icin int olusuturuyoruz
            while (a < 120)
            {
                a++;
                if (a % 2 == 0) // tek ve çift sayıları anlamak icin mod alma işlemi yapıyoruz
                {
                    çift = çift + a;
                }
                else
                {
                    tek=tek + a;
                }
            }
            Console.WriteLine("çift sayılar toplam : " + çift);
            Console.WriteLine("tek sayılar toplam : " + tek);
            Console.ReadKey();
        }
    }
}
