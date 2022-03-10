using System;

namespace odev1_4 // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Bir konsol uygulamasında kullanıcıdan bir cümle yazması isteyin. 
            // Cümledeki toplam kelime ve harf sayısını console'a yazdırın.

            string cumle;
            Console.WriteLine("Bir cumle yaziniz: ");
            cumle = Console.ReadLine().Trim(); // Girlien cümlenin okunması
            Console.WriteLine("Toplam kelime sayisi: " + cumle.Split(' ').Length); // Cümlenin kelime dizisine çevrilerek eleman sayisinin gösterilmesi
            Console.WriteLine("Toplam harf sayisi (bosluklar dahil): " + cumle.Length); // Cümledeki toplam karakter sayisi
        }
    }
}