using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace metotlar
{
    internal class Program
    {
        static void EkranaDegerYaz(object a, int b)
        {
            //metoda gönderilen sayı kdar ekrana yazılacak olan bilgi
            for (; b > 0; b--)
            {
                if (b < 5)
                {
                    Console.WriteLine(a);
                }
                else
                {
                    Console.WriteLine("Belki bir gün kahve gelir serdar hoca");
                }
            }

        }
        static void Yaz1(object a, int b)
        {
            if (b > 10)
            {
                Console.WriteLine("10 değerinden büyük değer girdiniz");
                return; // metodu kapatır. hep en sona konur.
            }
            for (; b > 0; b--)
            {
                Console.WriteLine(b);
            }
        }
        static void Yaz3(int[] dizimetot)
        {
            string tek = "", çift = "";
            //dizinin iiçindeki değerler int olarak tanımlı i ye aktarılıyor
            //dizinin içindeki tek olan sayıları ekrana yazdırdık
            foreach (int i in dizimetot) // foreach döngüsüyle dizinin içini yazdırıyoruz
            {
                if (i % 2 == 1)
                {
                    tek = tek + i + ",";
                }
                else
                {
                    çift = çift + i + ",";
                }
                Console.WriteLine("Çift Sayılar: " + çift);
                Console.WriteLine("Tek Sayılar: " + tek);

            }
        }
        static void Yaz4(Array dizi)
        {
            foreach (object i in dizi)
            {
                Console.WriteLine(i);
            }
        }
        static void Degistir(int[] dizi)
        {
            for (int i = 0; i < dizi.Length; i++)
            {
                if (i < 3)
                {
                    dizi[i] = 10;
                }
                else
                {
                    dizi[i] = 1;
                }
            }
        }
        static void Yaz5(Array dizi)
        {
            foreach (object a in dizi)
            {
                Console.WriteLine(a);
            }
        }
        static void Degistir(int sayi)
        {
            sayi = 10;
        }
        static void Yaz6(int sayi)
        {
            Console.WriteLine(sayi);
        }
        static void Degistir2(ref int sayi)
        {
            sayi = 10;
        }
        static void Degistir3(ref int sayi)
        {
            sayi = 10;
        }
        // birden fazla parametre metoda gönderiyorsak params kelimesi kullanılır
        static int Islem(object islemtipi, params int[] sayilar)
        {
            if (islemtipi == "carp")
            {
                int carpim = 1;
                foreach (int i in sayilar)
                {
                    carpim*=i;
                }
                return carpim;
            }
            else if (islemtipi == "topla")
            {
                int toplam = 0;
                foreach (int i in sayilar)
                {
                    toplam+=i;
                }
                return toplam;
            }
            else if (islemtipi == "bolme")
            {
                if (sayilar[0] == 0)
                
                    return 0;
                
                int bolum = sayilar[0];
                // bolum= sayilar[0] / sayilar[1]
                //foreach (int i in sayilar)
                for (int i = 1; i < sayilar.Length; i++)
                {
                    if (sayilar.Length == 1)
                    {
                        return i;
                    }
                    //console.writeline("i:{0}",i);
                    if (sayilar[i] == 0)
                    {
                        return 0;
                    }
                    bolum /= sayilar[i];
                    //console.writeline("bolum:{0}",i);
                }
                return bolum;
            }
            else
                return 0;
        }
        int Topla(int a, int b)// metodumuzun ismi
        {
            return a + b; //geriye sonuç değerini döndürür
        }

        int Topla(int a, int b, int c)// metodumuzun ismi
        {
            return a + b + c; //geriye sonuç değerini döndürür
        }

        static int Toplaikikati(int a, int b)
        {
            return (a + b) * 2; //geriye sonuc değerini döndürür.
        }

        static void Main(string[] args)
        {
            #region Metot tanım
            //metotlar tip olarak ikiye ayrılır

            //1.Statik
            //2.Dinamik
            //Statik ve dinamik metotlar aynı sınıfta hiçbir farkları yoktur.
            //direkt isimleriyle eşleştirilebilirler.
            //Farkları başka sınıflardan çağırıldığında ortaya çıkar.
            //Statik metot başka sınıflardan direkt ismi ile çağırılırken 
            //Dinamik metot başka sınıftan nesne oluşturulup çağırılabilir.
            //Not: Aynı sınıftan statik metot içerisinde sinamik metot çağırılırken gene o sınıfa ait nesne oluşturmamı gerekir.
            //Örnek konsolda program sınıfımızda statik main metodumuzda dinamik metotlar için program sınıfınfan nesne türeterek dinamik metoda ulaşabiliriz.

            //Metotlar kullanım olarakta ikiye ayrılır.

            //1.Değer döndüren
            //2.Değer döndürmeyen


            #endregion

            #region ornek0 ilk metot staticsiz Dinamik hali
            //Metodun çağırıldığı ksım
            //Dinamik metot kullandığımda bulunduğu sınıftan nesne oluşturularak kullanabiliriz.
            //Ana programda istediğimizi çağırıp kullandığımız alt programlara metot denir.
            //Metotlar ikiye ayrılır dinamik ve statik olmak üzere
            //Aynı sınıfta iken nesne oluşturmaya gerek yoktur.
            // int a= Topla(2,5); bu şekilde kullanabiliyoruz.
            //Program nesne = new Program();
            //int a = nesne.Topla(2, 5);
            //int b = nesne.Topla(1,4,6);

            //Console.WriteLine(a);
            //Console.WriteLine(b);
            //Console.ReadLine();
            #endregion

            #region Ornek 01 ikinci metot statik hali
            //int c = Toplaikikati(2, 5); //f12 basınca metodun olduğu yere götürür.
            //Console.WriteLine(c);
            //Console.ReadLine();

            #endregion

            #region ornek 2 başka bir sınıftan static metot çağırma yöntemi
            //int a = Metotlar1.Topla(2,5);
            //Console.WriteLine(a);
            //Console.ReadLine();
            #endregion

            #region ornek 03 Dinamik başka bir metottan çağırma
            // Static metot olmadığından metot sınıfları metot1 nesnesi oluşturduk
            // Toplayeni metodu kullanmak için.

            Metotlar1 metotnesnesi = new Metotlar1();
            //dinamik metot kullanmak için metot1nesnesi oluşturduk
            //int a = metotnesnesi.Toplayeni(8, 9);

            //int b = metotnesnesi.Toplayeni(3, 9, 5);

            //Console.WriteLine(a);
            //Console.WriteLine(b);
            //metotnesnesi.sorucoz();
            //Console.ReadLine();

            #endregion

            #region ornek 7 param
            // param demek birden fazla parametreyi metotta kullanabilmek demektir.
            Console.WriteLine(Islem("topla",4,8,9,12,15));
            Console.WriteLine(Islem("carp",5,23,6));
            Console.WriteLine(Islem("carp",5));
            Console.WriteLine(Islem("bolme", 6, 3, 2));
            Console.WriteLine(Islem("bolme", 6, 3, 0)==0 ?"tanımsız":Islem("bolme",6,3,0).ToString());
            Console.ReadLine();
            #endregion 

            #region ornek 1 voidli metot
            EkranaDegerYaz("kahvesiz serdar hoca", 15);
            Console.ReadLine();

            #endregion

            #region ornek2 metot
            Yaz1("bu sınıftaki umutun durumu ne olacak", 15);
            #endregion

            #region ornek3 metodun içine dizi gönderiyorum
            //bu dizi tek boyutlu dizidir
            //birden fazla değerin tutulduğu kümeyi gönderiyoruz
            int[] dizi = { 1, 2, 4, 7, 9 };
            string sdizi = "";
            foreach (var item in dizi)
            {
                sdizi += item + " ,";
            }
            Console.WriteLine("Küme dizisi :{ "+sdizi+"}");
            Yaz3(dizi);
            Console.ReadLine();
            #endregion

            #region ornek4 her türlü diziyi metoda göndermek
            int[] dizitamsayi = { 1, 2, 4, 7, 9 };
            string[] dizimetin = { "Ne", "olacak", "bu", "kahve", "süt", "cikolata" };
            Yaz4(dizitamsayi);
            Console.WriteLine("---------------------------------------------------");
            Yaz4(dizimetin);
            Console.WriteLine("hosgeldin");
            Console.ReadLine();
            #endregion

        }
    }

    class Metotlar1
    {
        //erişim belirteçleri(public,private, protected, internalprotected)
        //public bir sınıf üyelerine başka sınıflar tarafından ulaşılabilir.
        //private bir sınıfın üyelerine sadece o sınıftan ulaşılabilir.
        //protected bir sınıfın üyelerine sadece o sınıftan türeyen sınıflar ulşabilir.
        //internal protected o sınıfın üyelerine sadece başka bir projeden o sınıftan türeyen sınıflar ulaşabiilir.
        public static int Topla(int a, int b) //sınıftan çağırabilmek için public kullanılır.
        {
            return a + b;
        }
        public int Toplayeni(int a, int b) //sınıftan çağırabilmek için public kullanılır.
        {
            return a + b;
        }
        public int Toplayeni(int a, int b, int c) //sınıftan çağırabilmek için public kullanılır.
        {
            return a + b + c;
        }
        public void sorucoz() //sınıftan çağırabilmek için public kullanılır.
        {
            Console.WriteLine("hello");
        }


    }
}
