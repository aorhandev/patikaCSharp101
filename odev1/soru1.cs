using System;

namespace odev1
{
    class Soru1
    {
        static void Main(string[] args)
        {
            /* Bir konsol uygulamasında kullanıcıdan pozitif bir sayı girmesini isteyin(n). 
            Sonrasında kullanıcıdan n adet pozitif sayı girmesini isteyin. 
            Kullanıcının girmiş olduğu sayılardan çift olanlar console'a yazdırın.
            */

            Console.WriteLine("Lütfen bir pozitif sayı giriniz:");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] sayilar = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Lütfen " + (i + 1) + ". sayıyı giriniz:");
                sayilar[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (int i = 0; i < n; i++)
            {
                if (sayilar[i] % 2 == 0)
                {
                    Console.WriteLine((i + 1) + ". sayı: " + sayilar[i]);
                }
            }
            Console.ReadLine();

        }
    }
}
