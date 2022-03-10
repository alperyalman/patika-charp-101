using System;

namespace odev1_2 // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Bir konsol uygulamasında kullanıcıdan pozitif iki sayı girmesini isteyin (n, m). 
            // Sonrasında kullanıcıdan n adet pozitif sayı girmesini isteyin. 
            // Kullanıcının girmiş olduğu sayılardan m'e eşit yada tam bölünenleri console'a yazdırın.
            int n,m;
            Console.WriteLine("İki adet sayi giriniz: ");
            Console.Write("1. sayi: ");
            n = Int32.Parse(Console.ReadLine()); // İlk girilen sayının okunması
            
            Console.Write("2. sayi: ");
            m = Int32.Parse(Console.ReadLine()); // 2. girilen sayının okunması
            
            Console.Write("Aralarında boşluk bırakarak " + n + " adet pozitif sayi giriniz:  ");
            // string a = Console.ReadLine();
            // int[] b = Array.ConvertAll(a, int.Parse());
            int[] sayilar = Array.ConvertAll(Console.ReadLine().Trim().Split(' '), s => int.Parse(s)); // Girilen sayiların bir diziye atanması

            Console.Write(m + " sayisina bölünenler: ");
            // n sayisinin m'e bölünüp bölünmediğinin kontrolü
            foreach (var sayi in sayilar) 
            {
                if(sayi%m == 0)
                    Console.Write(sayi + " ");
            }
        }
    }
}