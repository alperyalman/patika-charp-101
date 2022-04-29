using System;
using System.Collections;
using System.Collections.Generic;

namespace enum_kavrami
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Gunler.Pazar);
            Console.WriteLine((int)Gunler.Cumartesi);

            int sicaklik = 32;

            if(sicaklik <= (int)HavaDurumu.Normal)
                Console.WriteLine("Havanın ısınmasını bekle!");
            else if (sicaklik>=(int)HavaDurumu.Sicak)
                Console.WriteLine("Çıkmak için sıcak bir gün!");
            else if (sicaklik >=(int)HavaDurumu.Normal && sicaklik<(int)HavaDurumu.CokSicak)
                Console.WriteLine("Dışarı çık!");
        }
    }

    enum Gunler 
    {
        Pazartesi, 
        Sali,
        Carsamba,
        Persembe, 
        Cuma = 23,
        Cumartesi,

        Pazar
    }

    enum HavaDurumu
    {
        Normal = 20,
        Sicak = 25,
        CokSicak = 30
    }
}

