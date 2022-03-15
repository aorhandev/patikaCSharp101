using System;
using System.Collections;

namespace soru3
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Klavyeden girilen cümle içerisindeki sesli harfleri bir dizi içerisinde saklayan ve dizinin elemanlarını sıralayan programı yazınız.*/

            string cumle = "";
            Console.WriteLine("Lütfen bir cümle yazınız.");
            cumle = Console.ReadLine();

            string sesliHarfler = "aAeEıIiİoOöÖ";

            ArrayList secilenHarfler = new ArrayList();

            for (int i = 0; i < cumle.Length; i++)
            {
                if (sesliHarfler.Contains(cumle[i]))
                {
                    secilenHarfler.Add(cumle[i]);
                }
                else
                {
                    continue;
                }
            }
            secilenHarfler.Sort();

            foreach (var item in secilenHarfler)
            {
                Console.Write(item + " ");
            }

            Console.ReadLine();



        }
    }
}
