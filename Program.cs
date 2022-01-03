using System;
using System.Collections;
using System.Collections.Generic;

namespace koleksiyon_soruları_3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Klavyeden girilen cümle içerisindeki sesli harfleri bir dizi içerisinde saklayan ve dizinin elemanlarını sıralayan programı yazınız.
            List<char> SesliHarfler = new();
            List<char> Girdi = new();

            SesliHarfler.Add('a');
            SesliHarfler.Add('e');
            SesliHarfler.Add('ı');
            SesliHarfler.Add('i');
            SesliHarfler.Add('o');
            SesliHarfler.Add('ö');
            SesliHarfler.Add('u');
            SesliHarfler.Add('ü');
            SesliHarfler.Add('A');
            SesliHarfler.Add('E');
            SesliHarfler.Add('I');
            SesliHarfler.Add('İ');
            SesliHarfler.Add('O');
            SesliHarfler.Add('Ö');
            SesliHarfler.Add('U');
            SesliHarfler.Add('Ü');
            Console.WriteLine("Lütfen bir cümle giriniz");
            char[] Cumle =Console.ReadLine().ToCharArray();
            int sayac = 0;
            for (int i = 0; i < Cumle.Length; i++)
            {
                bool test = SesliHarfler.Contains(Cumle[i]);
                if (test)
                {
                    sayac++;
                }
            }
            char[] CumleIciSesliHarfler = new char[sayac];
            int sayac2 = -1;
            for (int i = 0; i <Cumle.Length; i++)
            {
                bool test = SesliHarfler.Contains(Cumle[i]);
                if (test)
                {
                    sayac2++;
                    CumleIciSesliHarfler[sayac2]=Cumle[i];
                }
            }
            Array.Sort(CumleIciSesliHarfler);
            foreach (var item in CumleIciSesliHarfler)
            {
                Console.WriteLine(item);
            }

        }
    }
}
