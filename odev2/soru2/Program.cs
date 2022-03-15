using System;
using System.Collections;

namespace soru2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Klavyeden girilen 20 adet sayının en büyük 3 tanesi ve en küçük 3 tanesi bulan, 
            her iki grubun kendi içerisinde ortalamalarını alan ve bu ortalamaları ve 
            ortalama toplamlarını console'a yazdıran programı yazınız. (Array sınıfını kullanarak yazınız.)*/

            int[] sayilar = new int[20];

            for (int i = 0; i < 20; i++)
            {
                Console.WriteLine("Lütfen {0}. sayıyı giriniz.", i + 1);
                sayilar[i] = Convert.ToInt32(Console.ReadLine());
            }

            Array.Sort(sayilar);

            int ilkUcToplam = 0;
            for (int i = 0; i < 3; i++)
            {
                ilkUcToplam = ilkUcToplam + sayilar[i];
            }

            Console.WriteLine("İlk üç toplam:" + ilkUcToplam);

            int sonUcToplam = 0;

            for (int i = 17; i < 20; i++)
            {
                sonUcToplam = sonUcToplam + sayilar[i];
            }

            Console.WriteLine("İlk Üç Sayının Ortalaması: " + (ilkUcToplam / 3));
            Console.WriteLine("Son Üç Sayının Ortalaması: " + (sonUcToplam / 3));

            Console.WriteLine("Ortalamaların Toplamları: " + ((sonUcToplam + ilkUcToplam) / 3));

            Console.ReadLine();

        }
    }
}
