using System;

namespace odev1_3 // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Bir konsol uygulamasında kullanıcıdan pozitif bir sayı girmesini isteyin (n). 
            // Sonrasında kullanıcıdan n adet kelime girmesi isteyin.
            // Kullanıcının girişini yaptığı kelimeleri sondan başa doğru console'a yazdırın.

            int n; // Girilecek kelime sayisi
            Console.Write("Pozitif bir sayi giriniz: ");
            n = Int32.Parse(Console.ReadLine()); // Girilen sayinin okunması
            Console.WriteLine("Aralarinda bosluk birakarak " + n + " adet kelime giriniz:");
            string[] words = Console.ReadLine().Trim().Split(' '); // Girilen kelimelerin diziye atanması
            Console.WriteLine("\nSondan basa dogru girdiğiniz kelimeler: "); 
            Console.WriteLine(string.Join(" ", words.Reverse())); // Ters çevrilen dizini yazdırılması
        }
    }
}