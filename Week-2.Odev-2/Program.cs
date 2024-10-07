using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week_2.Odev_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 0;   // while komutu ile 10 kere isim yazdırmak icin bir int değeri oluşturduk ve budeğeri while içinde kosul  sağlanana kadar arttırdık
            while (a<10)   
            {
                Console.WriteLine("Kendimeinanıyorum yazılım işini hallederim");
                a++;
            }
            Console.ReadKey();
        }
    }
}
