using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yol_Arkadaşı
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int bodrum = 4000;   // maliyet hesabı icin şehirlerin fiyatlarını tanımladık
            int marmaris = 3000;
            int çeşme = 5000;
            int way1 = 1500;

        başlangıç:
            Console.WriteLine("sehir giriniz");
            Console.WriteLine("Bodrum (Paket başlangıç fiyatı 4000 TL)");
            Console.WriteLine("Marmaris (Paket başlangıç fiyatı 3000 TL)");
            Console.WriteLine("Çeşme (Paket başlangıç fiyatı 5000 TL)");
            string sehir = Console.ReadLine();
            string sehir2 = sehir.ToLower();  // büyük kücük harf farkını önledik
            if (sehir2 != "bodrum" && sehir2 != "marmaris" && sehir2 != "çeşme") // Verilen şehirlerden farklı bir şehir girilirse hatalı giriş oluğunu tanımladık
            {
                Console.WriteLine("hatalı giriş");
                goto başlangıç;  // hatalı giriş olunca başlaangıca dönmeye yarayan komut
            }

            Console.WriteLine("kaç kişilik tatil"); // tatile gidecek kişi sayısını tanımladık

            int number = Convert.ToInt32(Console.ReadLine());

            if (sehir2 == "bodrum")  // şehirlerdeki etkinlikleri tanımladık
            {
                Console.WriteLine("Bodrumda tekne turu ve yamaç paraşütü etkinliği");
            }
            else if (sehir2 == "marmaris")
            {
                Console.WriteLine("Marmariste koy gezileri etkinliği ve jetski");
            }
            else if (sehir2 == "çeşme")
            {
                Console.WriteLine("Çeşmede tüplü dalış ve tekne turu");
            }
        soru:
            Console.WriteLine("Hangi ulaşım yolunu kullanmak istersiniz"); // ulaşım yolunu belirledik
            Console.WriteLine("1 - Kara yolu ( Kişi başı ulaşım tutarı gidiş-dönüş 1500 TL )");
            Console.WriteLine("2 - Hava yolu ( Kişi başı ulaşım tutarı gidiş-dönüş 4000 TL)");
            Console.WriteLine("lütfen yukarıdaki seçeneklerden birini seçin");
            string way = Console.ReadLine();
            int yol = Convert.ToInt32(way);
            if (yol == 1)  // Masrafları hesaplamak icin ulaşım yollarının maliyetini belirledik
            {
                way = "kara yolu";
                way1 = 1500;
            }
            else if (yol == 2)
            {
                way = "Hava Yolu";
                way1 = 4000;
            }
            if (yol != 1 && yol != 2)  // farklı seçenek girilirse hatalı giriş olduğunu tanımladık ve seçime geri yönlendirdik
            {
                Console.WriteLine("hatalı giriş yaptınız"); 
                goto soru;
            }

            int toplam = 0; // toplam maliyeti belirlemek için kişi sayısı, gidilecek şehir ve ulaşım yolunun hesabını yaptık
            if (sehir2 == "marmaris")
            {
                toplam = (number * marmaris) + (way1 * number);

            }
            else if (sehir2 == "bodrum")
            {
                toplam = (number * bodrum) + (way1 * number);
            }
            else if (sehir2 == "çeşme")
            {
                toplam = (number * çeşme) + (way1 * number);
            }//   Toplam maliyeti yazdırdık alt satırda
            Console.WriteLine("Gidilecek yer :" + sehir2 + " kişi sayısı: " + number + " ulaşım aracı " + way + " Toplam tutar: " + toplam + "TL");
            Console.WriteLine("Başka bir tatil planlamak ister misiniz ?");
            string answer = Console.ReadLine();
            string answer2 = answer.ToLower();
            if (answer2 == "evet")
            {
                goto başlangıç;  // başka tatil planı yapılacaksa en başa döner cevabı evet-hayır şeklinde aldık
            }
            else if (answer2 == "hayır")
            {
                Console.WriteLine("İyi Günler Dileriz");
                Console.ReadKey();
            }
        }
    }
}
