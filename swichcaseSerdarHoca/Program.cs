using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace swichcaseSerdarHoca
{
    internal class Program
    {
        static void Main(string[] args)
        {


        #region switchcase basit örnek
        //basadon1:
        //    Console.Write("Lütfen 1.Sayıyı Girin: ");
        //    int sayi1 = int.Parse(Console.ReadLine());

        //    Console.Write("Lütfen 2.Sayıyı Girin: ");
        //    int sayi2 = int.Parse(Console.ReadLine());
        //islem:
        //    Console.Write("Lütfen işlem tipini Giriniz +,/,-,* ");
        //    char islemTipi = char.Parse(Console.ReadLine());
        //    Console.Write("Metot tipini seçiniz: 1-if/ 2-Switch Case ");
        //    string cevap = Console.ReadLine();
        //    if (cevap == "1")
        //    {
        //        #region ifli metot
        //        if (islemTipi == '+')
        //        {
        //            Console.WriteLine("Sonuc: " + (sayi1 + sayi2));
        //        }
        //        else if (islemTipi == '-')
        //        {
        //            Console.WriteLine("Sonuc: " + (sayi1 - sayi2));
        //        }
        //        else if (islemTipi == '*')
        //        {
        //            Console.WriteLine("Sonuc: " + (sayi1 * sayi2));
        //        }
        //        else if (islemTipi == '/')
        //        {
        //            Console.WriteLine("Sonuc: " + (sayi1 / sayi2));
        //        }
        //        else
        //        {
        //            Console.WriteLine("Lütfen işlem tipi olarak  +,/, -, * birini giriniz.");
        //            goto islem;
        //        }

        //        #endregion
        //    }
        //    else
        //    {
        //        #region SwitchCase
        //        switch (islemTipi)
        //        {
        //            case '+':
        //                Console.WriteLine("Sonuc: " + (sayi1 + sayi2));
        //                //Break ile switchten çıkıyor
        //                break;
        //            case '-':
        //                Console.WriteLine("Sonuc: " + (sayi1 - sayi2));
        //                break;
        //            case '*':
        //                Console.WriteLine("Sonuc: " + (sayi1 * sayi2));
        //                break;
        //            case '/':
        //                Console.WriteLine("Sonuc: " + (sayi1 / sayi2));
        //                break;
        //            default:
        //                Console.WriteLine("Lütfen doğru bir işlem tipi giriniz.");
        //                break;
        //        }
        //        #endregion
        //    }
        //    Console.ReadLine();
        //    Console.WriteLine("Yeni bir işlem yapmak istiyor musunuz ? e/h ");
        //    char devam = char.Parse(Console.ReadLine());
        //    if (devam == 'e' || devam == 'E')
        //    {
        //        Console.Clear();
        //        goto basadon1;
        //    }
        //    else
        //    {
        //        Environment.Exit(0);
        //    }
        #endregion

        #region while dongusu1
        ////while döngüsünde başlangıç ve bitiş yoktur. koşuldoğru olduğu sürece devam eder.
        //int i = 1;
        //while (i < 10)
        //{
        //    Console.WriteLine($"i değişkeninin değeri: {i}");
        //    i++;
        //}
        //Console.ReadLine();
        #endregion

        #region while dongusu2 5e bölünen 7ye bölnmeyen
        //Console.WriteLine("1 ile 1000 arasında 5'e bölünen, 7'ye bölünemeyen sayıları yazdıran program ");
        //Console.ReadLine();
        //int i = 1,toplam=0,adet=0;
        //while (i <= 1000)
        //{
        //    if (i % 5 == 0 && i % 7 != 0)
        //    {
        //        Console.WriteLine(i);
        //        toplam += i;
        //        adet++;
        //    }
        //    i++;
        //}
        //Console.WriteLine("Toplam: " + toplam);
        //Console.WriteLine("Adet: " + adet);
        //Console.ReadLine();
        #endregion

        #region while dongusu 3
        //int x = 0;
        //while (x++ < 10) 
        //{
        //    Console.WriteLine($"i nin değeri {x}");
        //}
        //Console.ReadLine();
        #endregion

        #region while dongusu 4
        //int z = 2;
        //while (++z < 6)
        //{
        //    Console.WriteLine($"i nin değeri {z}");
        //}
        //Console.ReadLine();
        #endregion

        #region while dongusu 5 faktoriyel
        //int faktoriyel = 1;
        //menu:
        //Console.Write("Lütfen faktoriyel sayısını giriniz: ");
        //int sayi=int.Parse(Console.ReadLine());

        //Console.WriteLine("1-For \n2-While");
        //Console.Write("Lütfen yöntem seçiniz: ");
        //string secim=Console.ReadLine();

        //switch (secim)
        //{
        //    case "1":
        //        {
        //            for (int i = 1; i <= sayi; i++)
        //            {
        //                faktoriyel=faktoriyel* i;
        //            }
        //            Console.WriteLine("Faktoriyel sonucu: "+faktoriyel);
        //        }
        //        break;

        //        case "2":
        //        {
        //            int x = 1;
        //            while (x<=sayi)
        //            {
        //                faktoriyel = faktoriyel * x;
        //                x++;
        //            }
        //            Console.WriteLine("Faktoriyel sonucu: " + faktoriyel);
        //        }
        //        break;
        //}

        //Console.Write("\nTekrar denemek ister misiniz ? e/h ");
        //string secim1 = Console.ReadLine();
        //if (secim1=="e"||secim1=="E")
        //{
        //    goto menu;
        //}
        //else
        //{
        //    Environment.Exit(0);
        //}

        //Console.ReadLine();
        #endregion

        #region klavyeden girilen sayının basamak değerlerini toplayan program
        //Console.Write("Lütfen bir sayı girin: ");
        //string sayi = Console.ReadLine();
        //int sayi1 = 0, toplam = 0;
        //int basamak = sayi.Length;
        //sayi1 = Convert.ToInt16(sayi);

        //for (int i = 0; i < basamak; i++)
        //{
        //    toplam += sayi1 % 10;
        //    sayi1 = sayi1 / 10;
        //}
        //Console.WriteLine(basamak);
        //Console.WriteLine(toplam);
        //Console.ReadLine();

        #endregion

        #region do while
        //Koşula bakmadan her durumda 1 kere döngü içi çalıştırılır
        //int i = 1, n = 5, sonuc1;
        //do
        //{
        //    sonuc1 = n = i;
        //    Console.WriteLine("{0}*{1}={2}", n, i, sonuc1);
        //    i++; 
        //} while (i<=10);
        //Console.ReadLine();
        #endregion

        #region kosu uygulaması

        //basadon:
        //    int toplam = 0;
        //    bool devamet = true;
        //    while (devamet)
        //    {
        //        int toplamkosu = 0;
        //        //Kullanıcıdan egzersiz için dakika girişi
        //        Console.WriteLine("Egzersiz için dakikayı giriniz lütfen, çıkmak için\"cikis\":");
        //        string giris = Console.ReadLine();
        //        if (giris == "cikis")
        //        {
        //            devamet = false;
        //            Environment.Exit(0);
        //        }
        //        else
        //        {
        //            int val;
        //            if (!Int32.TryParse(giris, out val))
        //            {
        //                Console.Clear();
        //                Console.WriteLine("Lütfen Sayı Girişi Yapınız.");

        //                goto basadon;
        //            }
        //            //toplam egzersize dakika ekle
        //            int dakika = int.Parse(giris);
        //            if (dakika < 10) //10dan küçükse
        //            {
        //                Console.WriteLine("\nhiç yoktan iyi değil mi?\n");
        //            }
        //            else if (dakika < 30) //10 dan büyük 30 dan küçükse
        //            {
        //                Console.WriteLine("\nher şey yolundan\n");
        //            }
        //            else if (dakika < 60) //30 dan büyük 60 dan küçükse
        //            {
        //                Console.WriteLine("\nBu koşuyla bir ninja gibi olursun!\n ");
        //            }
        //            else // 60 tan büyükse
        //            {
        //                Console.WriteLine("\nSüpersin\n");
        //            }
        //            toplamkosu = toplamkosu + dakika;
        //            //Ekrana yapılan egzersiz koşunun toplam süresi yazılması
        //            Console.WriteLine("Yapılan egzersiz süresi: " + toplamkosu + " dakika.\n");
        //        }
        //        //Kullanıcı çıkış yazana kadar kod çalışır
        //    }
        //    Console.WriteLine("Görüşürüz");
        //    Console.ReadLine();
            #endregion


        }
    }
}
