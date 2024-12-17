using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Params_ile_Sinirsiz_Sayida_Parametre_Alarak_OrtHesaplama
{
    internal class Program
    {
        static void Main(string[] args)
        {

            double ortalama1 = OrtalamaHesapla(111.86, 16, 418,851);
            Console.WriteLine("Ortalama 1: " + ortalama1);

            double ortalama2 = OrtalamaHesapla();  //Boş değer gönderilmesi durumu
            Console.WriteLine("Ortalama 2: " + ortalama2);

            double ortalama3 = OrtalamaHesapla(716, 41, 108);
            Console.WriteLine("Ortalama 3: " + ortalama3);

            Console.ReadKey();

        }
        static double OrtalamaHesapla(params double[] sayilar)
        {
            if (sayilar.Length == 0) //Eğer hiç parametre gönderilmezse
            {
                Console.Write("Ortalama 2de Hesaplanacak Değer Yoktur. || ");
                return 0;
            }

            double toplam = 0;

            foreach (double sayi in sayilar)
            {
                toplam += sayi;
            }

            return toplam / sayilar.Length;

        }
    }
}