using System;

namespace odev1_1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Bir konsol uygulamasında kullanıcıdan pozitif bir sayı girmesini isteyin(n). 
            // Sonrasında kullanıcıdan n adet pozitif sayı girmesini isteyin. 
            // Kullanıcının girmiş olduğu sayılardan çift olanlar console'a yazdırın.
            Console.Write("Pozitf bir sayi girinizi: ");
            int n = Int32.Parse(Console.ReadLine()); // Girilen sayinin okunması
            Console.WriteLine("----- " + n + " adet pozitf sayi giriniz -----");
            int[] sayilar = new int[n]; // Girlien sayi boyutunda dizi oluşturulması

            // Girilen sayiarın diziye atanması
            for (int i = 1; i<=n; i++)
            {
                Console.Write(i + ". sayi: ");
                sayilar[i-1] = Int32.Parse(Console.ReadLine());
            }

            Console.Write("Girdiğiniz çift sayilar: ");
            // Girile sayiların çift olup olmadığının kontrol edilip ekrana yazdırılması
            foreach (int sayi in sayilar)
            {
                if(sayi%2 == 0)
                    Console.Write(sayi + " - ");   
            }

            

        }
    }
}
