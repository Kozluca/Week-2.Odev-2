using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week_2._1_20arasındaki_çift_sayılar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 0;      // while dögüsünde kosul sağlamak icin int değeri atadık ve int değerini  while içinde kullandık.
            while (a < 21)
            {
                Console.WriteLine(a);
                a = a + 2; 
            }
            Console.ReadKey();
        }
    }
}
