using System;

namespace donguler_while_foreach // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("============ While loop ============");
            Console.Write("Bir sayi giriniz: ");
            int sayi = Convert.ToInt32(Console.ReadLine());
            int sayac = 1;
            int toplam = 0;

            while (sayac <= sayi)
            {
                toplam += sayac;
                sayac++;
            }

            Console.WriteLine("Toplam: " + toplam);
            Console.WriteLine("Ortalama: " + (float)toplam/sayi);

            Console.WriteLine("============ Foreach ============");
            string[] arabalar = {"ford", "toyota", "nissan", "ferrari"};

            foreach (var araba in arabalar)
            {
                Console.WriteLine(araba);
            }
                
        }
    }
}