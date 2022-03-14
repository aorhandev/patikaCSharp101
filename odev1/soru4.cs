using System;

namespace odev1
{
    class Soru4
    {
        static void Main(string[] args)
        {
            /* Bir konsol uygulamasında kullanıcıdan bir cümle yazması isteyin. 
            Cümledeki toplam kelime ve harf sayısını console'a yazdırın.
            */

            Console.WriteLine("Lütfen bir cümle giriniz:");
            string cumle = Console.ReadLine();
            int kelimeSayisi = 0;
            int harfSayisi = 0;
            for (int i = 0; i < cumle.Length; i++)
            {
                if (cumle[i] == ' ')
                {
                    kelimeSayisi++;
                }
                else
                {
                    harfSayisi++;
                }
            }
            kelimeSayisi++;
            Console.WriteLine("Cümledeki kelime sayısı: " + kelimeSayisi);
            Console.WriteLine("Cümledeki harf sayısı: " + harfSayisi);

            Console.ReadLine();

        }
    }
}
