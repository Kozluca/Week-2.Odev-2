using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week_2._1_20arasındaki_sayilar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 0; // while döngüsünde şartı sağlamak icin bir int değeri oluşturduk ,while icinde kosula kadar int değerini arttırdık
            while (a<21)
            {
                Console.WriteLine(a);
                a++;
            }
            Console.ReadKey();
        }
    }
}
