using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerdarHocaDiziler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Diziler01
            ////birden fazla değişkenleri yönetebilen kümelere dizi denir.
            ////Dizinin başlangıç indeks değeri 0 dan başlar.
            ////20 elemanlı tamsayı dizisi oluşturduk
            ////Dizilerde boyut(eleman sayısı)ve tip olma zorunluluğu vardır.
            //int[] dizi = new int[20];
            ////dizinin 6. elemanı 30 değerini atadı1k
            //dizi[5] = 30;
            ////dizinin 7. elemanı 20 değerini atadık
            //dizi[6] = 20;
            //Console.WriteLine("Dizinin 1.elemanı :{0}\n Dizinin 2.elemanı :{1}", dizi[0], dizi[1]);
            //Console.WriteLine($"Dizinin 6.elemanı :{dizi[5]}\n Dizinin 7.elemanı :{dizi[6]}");
            //Console.ReadLine();

            #endregion

            #region diziuygulaması
            ////dizinin boyutu içine değer atılınca otomatik olarak oluşu
            ////4 tane farklı dizi tanımladık
            //string[] dizi1 = { "bir", "iki", "üç" };
            //int[] dizi2 = { 2, -4, 6 };
            //float[] dizi3 = { 2f, 1.2f, 7f };
            //double[] dizi4 = { 2d, 5.5d, 66.9d, 99.7d };
            ////ödev: 5 adet dersler olacak ders adı ve yanında süreleri şeklinde ders dizisi tanımla
            #region ödev

            #endregion
            ////dizi1 in 1.elemanı
            //Console.WriteLine($"dizi1 in 1.elemanı{dizi1[0]}");
            ////dizi2 in 2.elemanı
            //Console.WriteLine($"dizi2 in 2.elemanı{dizi2[1]}");
            ////dizi3 ün 3.elemanı
            //Console.WriteLine($"dizi3 ün 3.elemanı{dizi3[2]}");
            ////dizi4 ün 4.elemanı
            //Console.WriteLine($"dizi4 ün 4.elemanı{dizi4[3]}");
            //Console.ReadLine();
            #endregion

            #region mükemmel sayı
            //Console.Write("Lütfen bir sayı girin: ");
            //int sayi=int.Parse(Console.ReadLine());
            //int toplam = 0,mukSayi;
            //mukSayi = sayi * 2;
            //for (int i = 1; i <sayi; i++)
            //{
            //    if (sayi % i == 0)
            //    {
            //        Console.WriteLine(i);
            //        toplam = toplam + i;
            //    }
            //}
            //if ((toplam*2) == mukSayi)
            //{
            //    Console.WriteLine("Girdiğiniz sayi mükemmel sayıdır.");
            //}
            //else
            //{
            //    Console.WriteLine("Mükemmel sayı değildir.");
            //}
            //Console.ReadLine();
            #endregion

            #region Diziler03 diziye veri atmak
            //basadon:
            //Console.Write("Dizinin eleman sayısını giriniz: ");
            //int sayi = Convert.ToInt32(Console.ReadLine());
            //if (sayi>0)
            //{
            //    int[] dizi = new int[sayi];
            //    for (int i = 0; i < sayi; i++)
            //    {
            //        if ((sayi - 1) == i) //dizinin son elemanı
            //        {
            //            dizi[sayi - 1] = 30;
            //        }
            //        else
            //        {
            //            dizi[i] = i; //dizinin diğer elemanları
            //        }                //dizinin son elemanına 30 değeri atanıyor
            //        Console.WriteLine("dizinin "+(i+1)+". elemanı değeri: " + dizi[i]);
            //    }
            //    Console.WriteLine("Yeni işlem yapmak istiyor musunuz ? e/h");
            //    string cevap = Console.ReadLine();  
            //    if (cevap == "e")
            //    {
            //        Console.Clear();
            //        goto basadon;
            //    }
            //    else if(cevap == "h")
            //    {
            //        //Environment.Exit(0);
            //        Console.Clear();
            //        Console.WriteLine("Görüşmek üzere");
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("Lütfen dizinin eleman sayısını sıfırdan büyük giriniz.");
            //    goto basadon;
            //}
            //Console.ReadLine();
            #endregion

            #region dersleri gir ve listele ödev**
            //basadon:
            //Console.Write("Dizinin eleman sayısını çift sayı olarak girin: ");
            //int sayi = Convert.ToInt32(Console.ReadLine());
            //if (sayi%2==0)
            //{
            //    #region diziye veri almak
            //    string[] dersler = new string[sayi];
            //    int dersadedi = 1;
            //    for (int i = 0;i < dersler.Length; i = i + 2)
            //    {
            //        Console.Write("Lüfen {0}. ders adı girin. ", dersadedi);
            //        dersadedi++;
            //        dersler[i]=Console.ReadLine();
            //        Console.Write("Lütfen dersin dakika cinsinden değerini girin. ",i);
            //        dersler[i+1]=Console.ReadLine();
            //    }
            //    #endregion
            //    Soru:
            //    #region diziyi listelemek
            //    Console.Write("Listelemek istiyor musunuz e/h ");
            //    string cevap=Console.ReadLine();
            //    if (cevap=="e"||cevap=="E")
            //    {
            //        for (int i = 0; i<dersler.Length; i=i+2)
            //        {
            //            Console.WriteLine($"{dersler[i]} dersin süresi {dersler[i+1]} dk dır.");
            //        }
            //    }
            //    else if (cevap == "h" || cevap == "H")
            //    {
            //        Console.Clear();
            //        Console.WriteLine("bye");
            //    }
            //    else
            //    {
            //        goto Soru;
            //    }
            //    #endregion
            //    Console.ReadLine();
            //}
            //else
            //{
            //    Console.WriteLine("Lütfen çift bir sayı giriniz");
            //    goto basadon;
            //}
            //Console.ReadLine();

            #endregion

            #region 3 elemanlı diziye bilgiler girip ortalama yazdıran program
            //int[] dizi = new int[3];
            //int ortalama=0, toplam=0;
            //for (int i = 0; i <dizi.Length; i++)
            //{
            //    Console.Write("Lütfen dizinin elemanlarını giriniz: ");
            //    int sayi = int.Parse(Console.ReadLine());
            //    dizi[i] = sayi;
            //    toplam += dizi[i];
            //    ortalama = toplam / dizi.Length;
            //}
            //for (int i = 0; i < dizi.Length; i++)
            //{
            //    Console.WriteLine($"sayı {i+1} {dizi[i]}"); 
            //}          
            //Console.WriteLine($"Sayıların ortalaması: {ortalama}");
            //Console.ReadLine();
            #endregion

            #region diziler05
            //int toplam = 0;
            //int[] sayilar = { 1, 2, 3, 4, 5 };
            //Console.WriteLine("ForEach Listesi");
            //Console.WriteLine();
            ////foreach döngüsü sadece okuma işlemi yapar;
            ////foreach döngüsü her türlü kümeleri listelemede kullanılır. (koleksiyonlar, diziler, nesneler)
            //foreach (int sayi in sayilar)
            //{
            //    Console.WriteLine(sayi);
            //    toplam += sayi;
            //}
            //Console.WriteLine("For listesi");
            //Console.WriteLine();
            //// for döngüsü hem okuma hem yazma işlemi yapar.
            //int toplamfor = 0;
            //for (int i = 0; i < 5; i++)
            //{
            //    sayilar[3] = 25;
            //    Console.WriteLine(sayilar[i]);
            //    toplamfor+=sayilar[i];
            //}
            ////foreach sadece okuma yapar..
            ////foreach döngüsü for döngüsünden daha hızlıdır.
            //Console.WriteLine();
            //Console.WriteLine("Dizideki sayıların toplamı= "+toplam);
            //Console.WriteLine("Dizideki sayıların toplamı= {0} ",toplam);
            //Console.ReadLine();
            #endregion

            #region diziler06
            //string nosayi = "", nsayi = "", posayi = "", ucsayi = "", bessayi = "";
            //int csayi = 0, tsayi = 0;
            //int[] sayilar = { 2, 2, 3, 4, 5, -5, -6, 0 };
            //foreach (int sayi in sayilar)
            //{
            //    if (sayi<0)
            //    {
            //        //nsayi = nsayi + sayi.ToString();
            //        nsayi += sayi.ToString();
            //        nsayi += ",";
            //        //nsayi = nsayi + ",";
            //    }
            //    if (sayi>0)
            //    {
            //        posayi += sayi.ToString();
            //        posayi += ",";
            //    }
            //    if (sayi==0)
            //    {
            //        nosayi += sayi.ToString();
            //    }
            //    if (sayi%2 == 0)
            //    {
            //        csayi++;
            //    }
            //    else
            //    {
            //        tsayi++;
            //    }
            //    if (sayi % 3 == 0 && sayi != 0)
            //    {
            //        ucsayi+=sayi.ToString();
            //        ucsayi += ",";
            //    }
            //    if (sayi % 5 == 0 && sayi != 0)
            //    {
            //        bessayi+=sayi.ToString();
            //        bessayi += ",";
            //    }
            //}
            //Console.WriteLine("Negatif Sayılar: " + nsayi);
            //Console.WriteLine("Pozitif Sayılar: " + posayi);
            //Console.WriteLine("Çift Sayı Adedş: " + csayi);
            //Console.WriteLine("Tek Sayı Adedş: " + csayi);
            //Console.WriteLine("Negatif Sayılar: " + tsayi);
            //Console.WriteLine("Nörtr Sayı: " + nosayi);
            //Console.WriteLine("3e Bölünen Sayılar: " + ucsayi);
            //Console.WriteLine("5e Bölünen Sayılar: " + bessayi);
            ////dizi komple silindi.
            //Array.Clear(sayilar, 0, sayilar.Length);
            //foreach (var item in sayilar)
            //{
            //    Console.WriteLine(item);
            //}
            //// 5 veya 3 e bölünen sayıları ekran da gösteriniz
            //Console.ReadLine();
            #endregion

            #region Diziler07 merakla beklenen ödev
            //string sonuc = "";
            ////isim adında metin dizisi tanımladık
            //string[] isim = { "berkay", "onur", "tugce", "fatih" };
            //int sayac = 0;
            //Console.WriteLine("Foreach döngüsü ile listeleme");
            //foreach (string uyeler in isim)
            //{
            //    sayac++;
            //    Console.WriteLine(sayac + "-)" + uyeler);
            //}
            //Console.Write("İsmini değiştirmek istediğiniz üye numarasını girin: ");
            //int index = int.Parse(Console.ReadLine());
            //Console.Write("İsmini değiştirmek istediğiniz üyenin yeni ismini girin: ");
            //string uyead = Console.ReadLine();
            //Console.WriteLine("-------------------------");
            //Console.WriteLine("For döngüsüyle listeleme");
            //for (int i = 0; i < 4; i++)
            //{
            //    if (i == index - 1)
            //    {
            //        isim[i] = uyead;
            //    }
            //    Console.WriteLine(isim[i]);
            //    //sonuc += isim[i] + ",";
            //}
            //Console.WriteLine();
            //Console.WriteLine("Foreach döngüsü ile dizinin listelenmesi");
            //foreach(string uyeler in isim)
            //{
            //    Console.WriteLine(uyeler);
            //}
            //Console.WriteLine(sonuc);
            //Console.ReadLine();

            #endregion

            #region diziler08

            #region Değişken Tanımlama
            //int toplam = 0;
            //int ort = 0;
            //int[] sayilar = new int[5];
            //int val;
            //string s1 = "";
            #endregion

            #region Veri girişi
            //for (int i = 0; i < 5; i++)
            //{
            #region veri girişi
            //Console.WriteLine("{0}. sayıyı giriniz: ", i + 1);
            //Console.WriteLine($"{i+1}. sayıyı girdiniz:");
            //basadon:
            //    s1 = Console.ReadLine();

            #endregion

            #region Veri kontrolü
            //girilen sayı olmadığı durum kontrolü
            //if (!Int32.TryParse(s1, out val))
            //{
            //    Console.WriteLine("Yanlış değer girdiniz lütfen tekrar {0}. sayıyı giriniz: ", i + 1);
            //    //Console.WriteLine("val:"+val);
            //    goto basadon;
            //}
            //else
            //{
            //    sayilar[i] = Convert.ToInt32(s1);
            //}
            #endregion

            #region toplam işlemi yapmak
            //toplam += sayilar[i];
            #endregion

            //ort = toplam / 5;
            #endregion

            #region Ekrana değer yazma
            //Console.WriteLine("Girilen sayıların ortalaması: "+ort);
            #endregion

            #endregion

            #region Diziler10
            #region tanımlamalar
            //int index = 0, uzunluk = 0;
            //string enuzunmetin = "", enuzunmetinler = "";
            ////dizinin içini doldurduk metinlerle
            //string[] metin = new string[6];
            #endregion
            #region diziye veri girişi
            //for (int i = 0; i < 6; i++)
            //{
            //    Console.Write("{0}.elemanı giriniz: ",i+1);
            //    metin[i] =Console.ReadLine();
            //}
            #endregion
            #region Dizideki verileri ekranda gösterdik
            //Console.WriteLine("----------------------");
            ////dizinin içini listeledik
            //foreach(var item in metin)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion
            #region Dizideki en uzun metni bulduk
            //for (int i = 0; i < 6; i++)
            //{
            //    if (metin[i].Length>uzunluk)
            //    {
            //        uzunluk = metin[i].Length;
            //        enuzunmetin = metin[i];
            //        index = i;
            //    }
            //}
            #endregion
            #region aynı uzunlukta birden fazla olan metinleri bulduk
            //int sayac = 0;
            //for (int i = 0; i < 6; i++)
            //{
            //    if (metin[index].Length==metin[i].Length)
            //    {
            //        enuzunmetinler = enuzunmetinler + metin[i] + ",";
            //        sayac++;
            //    }
            //}
            #endregion
            #region Bulduğumuz en uzun metinlerin bilgilerini ekranda gösterdik
            //if (sayac>1)
            //{
            //    Console.WriteLine("Dizi içindeki en uzun metinler: " + enuzunmetinler);
            //}
            //else
            //{
            //    Console.WriteLine("Dizi içindeki en uzun metin: " + enuzunmetinler.Substring(0, (enuzunmetinler.Length) - 1));
            //}

            //Console.WriteLine("Dizi içindeki en uzun metin index numarası:"+index);
            //Console.WriteLine("Dizi içindeki en uzun metin karakter sayısı:"+uzunluk);
            //Console.ReadLine();
            #endregion
            #endregion

            #region diziler12
            //int sayac1 = 0;
            //int adet1 = 0;
            //int adet2 = 0;
            //int [] sayi = new int[10];
            //string besebolunenler = "", yediyebolunenler = "";
            //for (int i = 0; i < sayi.Length; i++)
            //{
            //    Console.WriteLine("{0}. sayıyı giriniz: ", i + 1);
            //    sayi[i] = Convert.ToInt32(Console.ReadLine());

            //    if (sayi[i] % 5 == 0)
            //    {
            //        //5 bölünenlerin sayısını sayac1 de tutuyorum
            //        sayac1++;
            //        besebolunenler = besebolunenler + sayi[i] + ",";
            //    }
            //    if (sayi[i] % 7 == 0)
            //    {
            //        yediyebolunenler = yediyebolunenler + sayi[i] + ",";
            //        //7 bölünenlerin sayısını sayac2 de tutuyorum
            //        adet1++;
            //        if (sayi[i] % 5 == 0)
            //        {
            //            adet2++;
            //        }
            //        // 7 ve 5 bölünenlerin sayısını sayac3 ile tutuyorum
            //    }
            //    //if (sayi[i] % 5 == 0 && sayi[i] % 7 == 0)
            //    //{
            //    //    sayac3++;
            //    //}
            //}
            //Console.WriteLine("5'e bölünen sayıların adedi: " + sayac1);
            //Console.WriteLine("5'e bölünen sayılar: " + besebolunenler);
            //Console.WriteLine("7'ye bölünen sayıların adedi: " + adet1);
            //Console.WriteLine("7'ye bölünen sayılar: " + yediyebolunenler);
            //Console.WriteLine("Hem 5'e hem 7'ye bölünen sayıların adedi: " + adet2);
            //Console.ReadLine();
            #endregion

            #region diziler13
            //basadon:
            //Console.Clear();
            //int sayac1 = 0;
            //int sayac2 = 0;
            //int sayac3 = 0;
            //int k = 0;
            ////Random sınıfından ras nesnesi oluşturduk.
            //Random rast=new Random();
            ////sayi dizisinde normal sayi değerlerini tuttuk
            //int[] sayi=new int[10];
            ////sayi1 dizininde 5e bölünebilen sayıları tuttul.
            //int[] sayi1 = new int[10];
            //Console.WriteLine("Rastgele sayıları listeledik");
            //for (byte i = 0; i < sayi.Length; i++)
            //{
            //    //rast nesnesinden next metoduyla rastgele 1 ile 100 arasında sayılar atadık
            //    sayi[i] = rast.Next(1, 100);
            //    Console.WriteLine((i + 1).ToString() + "-)" + sayi[i] + "\n");
            //    //5 e bölünebilen sayıları listelemek için sayi1 dizisine aktardık
            //    if (sayi[i]%5==0)
            //    {
            //        sayac1++;
            //        sayi1[k]=sayi1[i];
            //        k++;
            //    }
            //    //5 e bölünebilen ve 7 ye bölünebilen sayı adetlerini buluyoruz
            //    if (sayi[i]%7==0)
            //    {
            //        sayac2++;
            //    }
            //    if (sayi[i] % 5 == 0 && sayi[i] % 7 == 0)
            //    {
            //        sayac3++;
            //    }
            //}
            //Console.WriteLine("5 e bölünen sayıların listesi");
            //for (byte ii = 0; ii < sayi.Length; ii++)
            //{
            //    if (sayi1[ii]!=0)
            //    {
            //        Console.WriteLine("5 e bölünen sayılar:{0}", sayi1[ii]);
            //    }
            //}
            //Console.WriteLine("5 e bölünen sayıların adedi: " + sayac1);
            //Console.WriteLine("7 ye bölünen sayıların adedi: " + sayac2);
            //Console.WriteLine("Hem 5 e hem 7 ye bölünen sayıların adedi: " + sayac3);
            //Console.ReadKey();
            //Console.WriteLine("Tekrar aynı işlem yapılsın mı e/h");
            //string cevap = "";
            //if (cevap=="e"||cevap=="E")
            //{
            //    goto basadon;
            //}
            //else
            //{
            //    Environment.Exit(0);
            //}
            //Console.ReadLine();

            #endregion

            #region ascii koda çevirme

            //Console.Write("0-255 Arasında bir sayi giriniz: ");
            //int girilensayi = int.Parse(Console.ReadLine());
            //if (girilensayi < 0 || girilensayi > 255)
            //{
            //    Console.WriteLine("Sayi İstenilen Değerler Arasında Değil");
            //}
            //else
            //{

            //    Console.WriteLine(Convert.ToChar(girilensayi));
            //}
            //Console.ReadLine();
            #endregion

            #region diziler14
            //    bool buldumu = false;
            //    string[] isim = new string[5];
            //    //5 adet isim girişi yaptık
            //    for (int i = 0; i < isim.Length; i++)
            //    {
            //    isimgir:
            //        Console.Write("{0}. isim giriniz: ", i + 1);
            //        string aynisim = Console.ReadLine();
            //        foreach (string s in isim)
            //        {
            //            if (aynisim == s)
            //            {
            //                Console.WriteLine("Aynı ismi iki kez giremezsiniz");
            //                goto isimgir;
            //            }
            //        }
            //        isim[i] = aynisim;
            //        Console.WriteLine();
            //        Console.Clear();
            //    }


            //basadon:
            //    Console.Write("Aramak istediğiniz ismi girin: ");
            //    string aranan = Console.ReadLine();
            //    for (int j = 0; j < isim.Length; j++)
            //    {
            //        if (aranan == isim[j])
            //        {
            //            buldumu = true;
            //            Console.WriteLine("Aramak istediğiniz isim {0}. sırada bulundu.", j + 1);
            //            break;
            //        }
            //    }
            //    //kayıt bukunmaz ise if blogu çalışır
            //    if (!buldumu)
            //    {
            //        Console.WriteLine("Böyle bir kayıt bulunamadı.");
            //    }
            //    Console.Write("Tekrar arama yapmak ister misiniz e/h ");
            //    string cevap = Console.ReadLine();
            //    if (cevap == "e" || cevap == "E")
            //    {
            //        goto basadon;
            //    }
            //    else
            //    {
            //        Environment.Exit(0);
            //    }
            #endregion

            #region diziler18

            //iki boyutlu diziler
            //2 satır 3 sütunluk diziler
            //Köşeli parantez içindeki tek virgül iki boyutlu dizi anlamına gelir
            //2 adet virgülde 3 boyutlu dizi olur
            #region tanımlar
            //int[,] dizi1 = new int[2, 3];
            //int[,] dizi2 = new int[2, 3];
            //int[,] dizi3 = new int[2, 3];

            #endregion
            #region veri girişi
            ////dizi1 giriş durumu
            //Console.WriteLine("Dizi1 olan A matrisinin elemanlarını giriniz.");
            ////dizi1 ile dizi2 dizisinin dışarıdan alınan değerlerle doldurduk
            //for (int i = 0; i < 2; i++) //satır
            //    for (int y = 0; y < 3; y++)
            //    {
            //        Console.WriteLine("A matrisinin {0}. satır {1}. sütun değerini giriniz: ", i + 1, y + 1);
            //        dizi1[i, y] = Convert.ToInt32(Console.ReadLine());
            //        //dizi[satır,sutün];
            //    }
            ////dizi[0,0]=textbox1.text;
            ////dizi giriş durumu
            //Console.WriteLine("Dizi2 olan B matrisinin elemanlarını giriniz.");
            //for (int k = 0; k < 2; k++)
            //{
            //    for (int j = 0; j < 3; j++)
            //    {
            //        Console.WriteLine("B matrisinin {0}. satır {1}. sütun değerini giriniz: ", k + 1, j + 1);
            //        dizi2[k, j] = Convert.ToInt32(Console.ReadLine());
            //    }
            //}
            //Console.WriteLine();

            #endregion
            #region dizi1 ekrana yazdır
            //Console.WriteLine("Dizi1 isimli iki boyutlu dizinin içeriği:");
            //for (int i = 0; i < 2; i++)
            //{
            //    for (int z = 0; z < 3; z++)
            //    {
            //        //sütun bazında
            //        Console.WriteLine(dizi1[i,z]+"\t");
            //    }
            //    //satır bazında
            //    Console.WriteLine();
            //}
            //Console.WriteLine();
            #endregion
            // Console.WriteLine("Dizi2 isimli iki boyutlu dizinin içeriği:");
            #region Dizi2 ekrana yazdır
            //for (int i = 0; i < 2; i++)
            //{
            //    for (int z = 0; z < 3; z++)
            //    {
            //        //sütun bazında
            //        Console.WriteLine(dizi2[i, z] + "\t");
            //    }
            //    //satır bazında
            //    Console.WriteLine();
            //}
            //Console.WriteLine();
            #endregion
            // 2 matris toplanmıştır
            //Console.WriteLine("Dizi1 ve Dizi2 isimli iki boyutlu dizinin toplanmış hali:");
            #region dizi3 oluştur
            //for (int i = 0; i < 2; i++)
            //{
            //    for (int j = 0; j < 3; j++)
            //    {
            //        //dizi1 ve dizi2 toplanıp dizi3 e  aktarıldı
            //        dizi3[i, j] = dizi1[i, j] + dizi2[i, j];
            //        //dizi3 ekrana yazıldı
            //        Console.WriteLine(dizi3[i,j]+"\t");

            //    }
            //    Console.WriteLine();
            //}
            #endregion
            #endregion
        

        }
    }
}
