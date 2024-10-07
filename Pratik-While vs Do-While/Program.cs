using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pratik_While_vs_Do_While
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region yontem 1
            Console.Write("Lütfen bir limit değeri giriniz: ");
            string limit = Console.ReadLine(); // kullanıcıdan limit sayısı aldık
            int limit2 = Convert.ToInt32(limit);// aldığımız değeri int e çevirdik
            int sayac = 0; // While komutu için int değeri atadık
            while (sayac <= limit2)  // while şartını yazdık
            {
                Console.WriteLine("Ben bir patikalıyım");
                sayac++;
            }
            Console.ReadKey();
            #endregion
            #region yontem2
            Console.Write("lütfen bir sayi girin: ");
            string limit3 = Console.ReadLine(); // kullanıcıdan limit sayısı aldık
            int limit4 = Convert.ToInt32(limit3);// aldığımız değeri int e çevirdik
            int sayac2 = 0;
            do
            {
                Console.WriteLine("BEN BİR PATİKALIYIM");
                sayac2++;

            } while (sayac2 <= limit4);
            Console.ReadKey();
            // WHİLE KOŞUL YANLIŞ İSE ÇALIŞMAZ    DO-WHİLE KOŞUL YANLIŞ OLSA BİLE 1 KERE ÇALIŞIR ÇÜNKÜ KOŞUL SONDA YER ALIR.
            #endregion
        }
    }
}
