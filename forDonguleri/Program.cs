using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace forDonguleri
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region baklava 
            //Console.Write("Bir sayı girin: ");
            //int sayi = int.Parse(Console.ReadLine());
            //for (int i = 1; i <= sayi; i++)
            //{
            //    if (i > 9)
            //    {
            //        for (int j = sayi; j > i; j--)
            //        {
            //            Console.Write("  ");
            //        }
            //        for (int k = 1; k <= i; k++)
            //        {
            //            Console.Write(" " + i + " ");
            //        }
            //    }
            //    else
            //    {
            //        for (int j = sayi; j > i; j--)
            //        {
            //            Console.Write("  ");
            //        }
            //        for (int k = 1; k <= i; k++)
            //        {
            //            Console.Write("  " + i + " ");
            //        }
            //    }

            //    Console.WriteLine();
            //}

            //for (int x = 1; x <= sayi - 1; x++)
            //{
            //    if (x > 9)
            //    {
            //        for (int y = 1; y <= x; y++)
            //        {
            //            Console.Write("  ");
            //        }
            //        for (int m = sayi - 1; m >= x; m--)
            //        {
            //            Console.Write(" " + x + " ");
            //        }
            //    }
            //    else
            //    {
            //        for (int y = 1; y <= x; y++)
            //        {
            //            Console.Write("  ");
            //        }
            //        for (int m = sayi - 1; m >= x; m--)
            //        {
            //            Console.Write("  " + x + " ");
            //        }
            //    }

            //    Console.WriteLine();
            //}

            //Console.ReadLine();
            #endregion

            #region ornek2
            //1-1000 e kadar olan sayıların içinde 5 e tam bölünen 7 ye tam bölünmeyen sayıları alt alta listeleyen bu 
            //sayıların kaç tane olduğunu ve toplamını yazdıran program

            //int toplam = 0, secim = 0;

            //for (int i = 1; i <= 1000; i++)
            //{
            //    if (i % 5 == 0 && i % 7 != 0)
            //    {
            //        Console.WriteLine(i + (secim++));

            //        toplam += i;
            //    }
            //}
            //Console.WriteLine("5'e tam bölünen ve 7'ye tam bölünemeyen sayıların toplamı: " + toplam);
            //Console.WriteLine("5'e tam bölünen ve 7'ye tam bölünemeyen sayıların adedi: " + secim);

            //Console.ReadLine();
            #endregion

            #region ornek3 binary        

            //string mod = "";

            //Console.Write("Lütfen bir sayı girin: ");
            //string mod1 = Console.ReadLine();
            //int b = Convert.ToInt16(mod1);
            //for (; b > 0; b /= 2) 
            //{
            //    mod = b % 2 + mod;
            //}
            //Console.Write("2'lik sistemde karşılığı: " + mod);
            //Console.ReadLine();

            #endregion

            #region for döngüsünde continue kısmı
            ////!=
            ////Bu örnekte tek sayılar listelenir
            //for (byte aa = 0; aa< 51; aa++)
            //{
            //    if (aa % 2 == 0) 
            //    {
            //        continue; //döngüyü başa alır
            //    }
            //    Console.WriteLine(aa);
            //}
            //Console.ReadLine();
            #endregion

            #region odev üs değiştirme
            // üslü sayı üs girecek sayı girecek sonuç bulunacak

            //Console.Write("Lütfen bir sayı girin: ");
            //int sayi = int.Parse(Console.ReadLine());
            //Console.Write("Lütfen almak istediğiniz üssü girin: ");
            //int us = int.Parse(Console.ReadLine());

            //int sonuc = 1, sayi2;
            //if (sayi == 5 && us == 8)
            //{
            //    Console.Write("Sayılar yer değiştirilsin mi? e/h ");
            //    string secim = Console.ReadLine();
            //    if (secim == "e" || secim == "E")
            //    {
            //        sayi2=sayi;
            //        sayi = us;
            //        us = sayi2;
            //        for (int i = 0; i < us; i++)
            //        {
            //            sonuc = sayi * sonuc;
            //        }
            //    }
            //    else
            //    {
            //        for (int i = 0; i < us; i++)
            //        {
            //            sonuc = sayi * sonuc;
            //        }
            //    }
            //}
            //else
            //{
            //    for (int i = 0; i < us; i++)
            //    {
            //        sonuc = sayi * sonuc;
            //    }
            //}
            

            //Console.Write(sayi + " üzeri " + us + " = " + sonuc);
            //Console.ReadLine();
            #endregion



        }
    }
}

