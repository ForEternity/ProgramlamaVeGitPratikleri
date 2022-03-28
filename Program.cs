using System;
using System.IO;

namespace DegiskenlerVeVeriTipleri
{
    class Program
    {
        static void Main(string[] args)
        {

            //değişken tipleri 
            // int = integer  N kümesini alır  maximum alabileceği değerler -2147483648 2147483647.
            System.Console.WriteLine( "int türünün alabileceği değerler");
            System.Console.WriteLine(int.MaxValue);
            System.Console.WriteLine(int.MinValue);

            System.Console.WriteLine("uint veri tipinin alabileceği değer");

            // uint N+ Kümesini alır. ve alabileceği min ve maksimum değer  0 ile 4294967295 arasındadır. : 
            System.Console.WriteLine(uint.MinValue);
            System.Console.WriteLine(uint.MaxValue);
            //int64 veri tipinin alabileceği min ve maksimum değer
            System.Console.WriteLine("long veri tipinin alabilceği değer -9223372036854775808 - 9223372036854775807 arasındadır ");
            System.Console.WriteLine(long.MinValue);
            System.Console.WriteLine( long.MaxValue);

            // ulong tipininde alabileceği değer 0 ile 18446744073709551615 arasındadır. 
            System.Console.WriteLine( "ulong veri tipinin alabilceği min ve maksimum değer");
            System.Console.WriteLine(ulong.MinValue);
            System.Console.WriteLine( ulong.MaxValue);

         // int ptr görelim bende bilmiyorum ilk defa gördüm :)
         System.Console.WriteLine("**** int ptr varmış neymiş ki bu ");
            System.Console.WriteLine(UIntPtr.MaxValue);


            // string tanımlama
            string Ad = "";
            string OrtaAd = string.Empty;
            string Soyad = "Ekinci";

            //string birleştirme
            Ad = "Fahreddin";
            OrtaAd = "Kadir";

            // string birleştirme 

            string TamAd = string.Concat(Ad, OrtaAd, Soyad);
            System.Console.WriteLine(TamAd);
            // integer tanımlama : 

            ushort Yas;
            Yas = 33;
            Console.WriteLine(Yas);
            // toplama işlemi 

            int a = 5,
             b = 8,
             c = a * b;
            System.Console.WriteLine($"Çarpılan : {a}");
            System.Console.WriteLine($"Çarpan : {b}");
            System.Console.WriteLine($"Çarpma Sonucu : {c}");

            // Tür dönüşümleri 
            Console.WriteLine(
            b.ToString() +
            c.ToString()
            );

            System.Console.Write("toplama işlemi için birinci sayıyı giriniz : ");
            int x, y, z;
            x = int.Parse(Console.ReadLine());
            System.Console.Write("toplama işlemi için ikinci sayıyı giriniz : ");
            y = Convert.ToInt32(Console.ReadLine());
            z = x + y;

            System.Console.WriteLine("girilen sayıların toplamı : {0}", z);

            // sayı çift mi tek mi 
            if (a % 2 == 0)
                Console.WriteLine("girilen sayı çift bir sayıdır, girilen sayı :{0}", a);
            else
                Console.WriteLine("girilen sayı tek sayılardan bir sayıdır, girilen sayı :{0}", a);

            if (b % 2 == 0)
                Console.WriteLine("girilen sayı çift bir sayıdır, girilen sayı :{0}", b);
            else
                Console.WriteLine("girilen sayı tek sayılardan bir sayıdır, girilen sayı :{0}", b);

            if (c % 2 == 0)
                Console.WriteLine("girilen sayı çift bir sayıdır, girilen sayı :{0}", c);
            else
                Console.WriteLine("girilen sayı tek sayılardan bir sayıdır, girilen sayı :{0}", c);

            // DateTime Tarih işlemleri 

            DateTime BuGun = DateTime.Now;
            System.Console.WriteLine(BuGun);
            // tarih gösterim formatını değiştirme
            Console.WriteLine(BuGun.ToString("dd.MM.yyyy"));
            // aynı format işlemini farklı bir string değişken atayarakta yapabiliriz. 
            string bgn = BuGun.ToString("dd:MM:yyyy");
            // sadece saati alma işlemi 

            DateTime SaatVeDakika = DateTime.Now;
            System.Console.WriteLine(SaatVeDakika.ToString("HH:mm"));


            //sınıf örneği

             Kisi kisi = new();
             kisi.Ad ="fahreddin";
             kisi.SoyAd ="ekinci";

               System.Console.WriteLine(kisi.Ad);
               System.Console.WriteLine(kisi.SoyAd);
               System.Console.WriteLine(TamAd);





        }
    }
}
