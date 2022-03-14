using System;

namespace odev1
{
    class Soru3
    {
        static void Main(string[] args)
        {
            /* Bir konsol uygulamasında kullanıcıdan pozitif bir sayı girmesini isteyin (n). 
            Sonrasında kullanıcıdan n adet kelime girmesi isteyin. 
            Kullanıcının girişini yaptığı kelimeleri sondan başa doğru console'a yazdırın.
            */

            Console.WriteLine("Lütfen bir pozitif sayı giriniz:");
            int n = Convert.ToInt32(Console.ReadLine());
            string[] kelimeler = new string[n];
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Lütfen " + (i + 1) + ". kelimeyi giriniz:");
                kelimeler[i] = Console.ReadLine();
            }
            for (int i = n - 1; i >= 0; i--)
            {
                Console.WriteLine((i + 1) + ". kelime: " + kelimeler[i]);
            }

            Console.ReadLine();

        }
    }
}
