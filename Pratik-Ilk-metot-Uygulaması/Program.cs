using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Pratik_Ilk_metot_Uygulaması
{
    internal class Program
    {
        static public void SARKI()
        {
            Console.WriteLine("    YILDIZLAR YERİNDE GÜZEL BIRAK DURSUN     ");
        }
        static public int Kalan()
        {
            Random rnd = new Random();
            int rastgele = rnd.Next(100);
            Console.WriteLine("RASTGELE SAYI: " + (rastgele));
            Console.WriteLine("Kalan sayı :" + (rastgele / 2));
            return rastgele / 2;
        }
        static public int Carpma(int a, int b)
        {
            Console.WriteLine("ÇARPMA: " + (a * b));
            return a * b;
        }
        static public void Isimsoyisimyaz(string isim, string soyisim)
        {

            Console.WriteLine("İsim: " + isim + " Soy isim: " + soyisim);
        }
        static void Main(string[] args)
        {
            SARKI();
            Kalan();
            Carpma(15, 5);
            Isimsoyisimyaz("ÖMER", "KOZLUCA");
            Console.ReadKey ();
        }
    }

}
