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
            
            //Recursive - Özyinelemeli Fonksiyonlar
            //3^4 = 3*3*3*3 
            Console.WriteLine("===== Recusrsive Fonksiyon =====");

            int sonuc2 = 1;
            for (int i = 1; i < 5; i++)
            {
                sonuc2 = sonuc2*3;
            }
            Console.WriteLine("3^4 = " + sonuc2);   

            Islemler instance = new Islemler();
            Console.WriteLine("3^4 = " + instance.Expo(3,4));

            Console.WriteLine("===== Extension Metotlar =====");
            string ifade = "Alper Alper Alper Alper";
            bool isSpaced = ifade.CheckSpaces();
            Console.WriteLine(isSpaced);
            if(isSpaced)
                Console.WriteLine(ifade.RemoveWhiteSpaces());
            
            Console.WriteLine(ifade.MakeUpperCase());
            Console.WriteLine(ifade.MakeLowerCase());
            

            int[] dizi = {1,3,5,4,6,8,6,2};
            Console.WriteLine("Dizi: ");
            dizi.EkranaYazdir();

            
            Console.WriteLine("Sıralı Dizi: ");
            dizi.SortArray().EkranaYazdir();

            Console.ReadLine();
 
        }
        
    }

    public class Islemler 
    {
        public int Expo(int sayi, int us)
        {
            if(us<2)
                return sayi;
            return  sayi*Expo(sayi,us-1);
        }

    }

    //Extension classlar static olmalı
    public static class Extension
    {
        public static bool CheckSpaces(this string param)
        {
            return param.Contains(" ");
        }

        public static string RemoveWhiteSpaces(this string param) 
        {
            string[] dizi = param.Split(" ");
            return String.Join("",dizi);
        }

        public static string MakeUpperCase(this string param) 
        {
            return param.ToUpper();
        }

        public static string MakeLowerCase(this string param) 
        {
            return param.ToLower();
        }

        public static int[] SortArray(this int[] param)
        {
            Array.Sort(param);
            return param;
        }

        public static void EkranaYazdir(this int[] param)
        {
            foreach (int item in param)
            {
                Console.WriteLine(item);
                
            }
        }
    }

}