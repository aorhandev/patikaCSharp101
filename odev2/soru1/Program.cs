using System;
using System.Collections;

namespace soru1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Klavyeden girilen 20 adet pozitif sayının asal ve asal olmayan olarak 2 ayrı listeye atın. (ArrayList sınıfını kullanara yazınız.)
            Negatif ve numeric olmayan girişleri engelleyin.
            Her bir dizinin elemanlarını büyükten küçüğe olacak şekilde ekrana yazdırın.
            Her iki dizinin eleman sayısını ve ortalamasını ekrana yazdırın.*/

            ArrayList sayilar = new ArrayList();

            for (int i = 0; i < 20; i++)
            {
                Console.Write("{0}. sayıyı giriniz: ", i + 1);

                try
                {
                    int girilenSayi = Convert.ToInt32(Console.ReadLine());
                    int kontrol = 0;
                    if (girilenSayi < 0)
                    {
                        Console.WriteLine("Girilen sayı 0'dan küçük, lütfen pozitif bir sayı giriniz.");
                        kontrol++;
                        if (kontrol > 0)
                        {
                            i--;
                        }
                        else
                        {
                            sayilar.Add(girilenSayi);
                            kontrol = 0;
                        }
                    }
                }
                catch
                {
                    Console.WriteLine("Girilen değere sayı değildir. Lütfen sayı giriniz.");
                    i--;
                }
            }

            ArrayList asalSayilar = new ArrayList();
            ArrayList asalOlmayanSayilar = new ArrayList();

            foreach (int item in sayilar)
            {
                if (item == 1)
                {
                    asalOlmayanSayilar.Add(item);
                }
                else if (item == 2)
                {
                    asalSayilar.Add(item);
                }
                else
                {
                    int primeNumber = 0;
                    for (int i = 2; i < item; i++)
                    {
                        if (item % i == 0)
                        {
                            primeNumber++;
                        }
                    }
                    if (primeNumber == 0)
                    {
                        asalSayilar.Add(item);
                    }
                    else
                    {
                        asalOlmayanSayilar.Add(item);
                    }
                }
            }

            asalSayilar.Sort();
            asalOlmayanSayilar.Sort();

            Console.WriteLine("Asal sayılar: ");
            foreach (int item in asalSayilar)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("**********************************************************");

            Console.WriteLine("Asal olmayan sayılar: ");
            foreach (int item in asalOlmayanSayilar)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("Asal sayıların sayısı: {0}", asalSayilar.Count);
            Console.WriteLine("Asal olmayan sayıların sayısı: {0}", asalOlmayanSayilar.Count);

            int asalSayilarToplam = 0;
            int asalOlmayanSayilarToplam = 0;

            foreach (int item in asalSayilar)
            {
                asalSayilarToplam += item;
            }

            foreach (int item in asalOlmayanSayilar)
            {
                asalOlmayanSayilarToplam += item;
            }

            Console.WriteLine("Asal sayıların toplamı: {0}", asalSayilarToplam);
            Console.WriteLine("Asal olmayan sayıların toplamı: {0}", asalOlmayanSayilarToplam);

            Console.WriteLine("Asal sayıların ortalaması: {0}", asalSayilarToplam / asalSayilar.Count);
            Console.WriteLine("Asal olmayan sayıların ortalaması: {0}", asalOlmayanSayilarToplam / asalOlmayanSayilar.Count);

            Console.ReadLine();

        }
    }
}
