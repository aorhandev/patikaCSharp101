using System;

namespace odev1
{
    class Soru2
    {
        static void Main(string[] args)
        {
            /* Bir konsol uygulamasında kullanıcıdan pozitif iki sayı girmesini isteyin (n, m). 
            Sonrasında kullanıcıdan n adet pozitif sayı girmesini isteyin. 
            Kullanıcının girmiş olduğu sayılardan m'e eşit yada tam bölünenleri console'a yazdırın.
            */

            Console.WriteLine("Lütfen bir pozitif sayı giriniz:");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] sayilar = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Lütfen " + (i + 1) + ". sayıyı giriniz:");
                sayilar[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Lütfen ikinci bir pozitif sayı giriniz:");
            int m = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                if (sayilar[i] % m == 0 || sayilar[i] == m)
                {
                    Console.WriteLine((i + 1) + ". sayı: " + sayilar[i]);
                }

            }
            Console.ReadLine();

        }


    }
}
