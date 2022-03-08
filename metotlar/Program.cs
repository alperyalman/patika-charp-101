using System;

namespace metotlar // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        // Referans olarak bir atama yapıldığında ise fonksiyona ilgili değişkenin bellekteki adresi gönderilmiş gibi düşünebilirsiniz. 
        // Dolayısıyla fonksiyon asıl değişken üzerinde değişiklik yapar. Fonksiyon içerisinde bir değişiklik yapıldığında çağırıldığı 
        // yerdeki değişken de değişikliğe uğramış olur. Yani değeri değişir. Bu nedenle ref anahtar kelimesini kullanırken çok dikkatli olunmalıdır.

        public static int ArttirVeTopla (int x, int y)
        {
            x+=1;
            y+=y;
            return (x+y);
        }

        //Ref kullanımı
        public static int ArttirVeToplaRef (ref int x, ref int y)
        {
            x+=1;
            y+=y;
            return (x+y);
        }

        // Method Overloading
        public static void EkranaYazdir(int deger)
        {
            Console.WriteLine(deger);
        }

        public static void EkranaYazdir(string deger)
        {
            Console.WriteLine(deger);
        }

        public static void EkranaYazdir(string deger1,string deger2)
        {
            Console.WriteLine(deger1 + deger2);
        }
        

        // Out kullanımı
        public static int Toplam (int a, int b,  out int toplam)
        {
            toplam = a+b;
            return toplam;
        }
        static void Main(string[] args)
        {
            int x = 3;
            int y = 4;  

            int sonuc = ArttirVeTopla (x, y);

            Console.WriteLine("x = {0}, y = {1}, Arttırılmış Toplam = {2}", x,y,sonuc);

            //Ref Kullanımının Özellikleri:
            // Referans olarak iletilmek istenen değişkenin önüne "ref" yazılmalıdır.
            // ref olarak metoda verilen değişkenin mutlaka bir başlangıç değeri olmak zorundadır.
            sonuc = ArttirVeToplaRef(ref x, ref y);
            Console.WriteLine("x = {0}, y = {1}, Arttırılmış Toplam = {2}", x,y,sonuc);


            Console.WriteLine("===== Metot Overloading ve Out Parametre Kullanımı =====");
            // Method overloading yani metotların aşırı yüklenmesi metot imzasının değiştirilerek aynı isimdeki metodun birden farklı versiyonun yaratılmasıdır.
            EkranaYazdir(12345);
            EkranaYazdir("abc");
            EkranaYazdir("abc-","def");


            Console.WriteLine("===== Out ve Ref Parametre Kullanımı =====");
            // Out anahtar kelimesi ref anahtar kelimesi ile aynı işi yapıyor diyebiliriz. Arada sadece bir kaç fark var.
            // Out Kullanımının Özellikleri:
            // Out olarak kullanılmak istenen değişken önüne mutlaka "out" yazılmalıdır.
            // out değişkeninin bir ilk değeri olmak zorunda değildir. Hatırlarsanız bu ref kullanırken zorunluydu.
            Console.WriteLine("a = 4, b = 8, Toplam = " + Toplam(4,8, out int toplam));
            Console.ReadLine();


        }

        
    }
}