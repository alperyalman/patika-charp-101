using System;
using System.Collections;
using System.Collections.Generic;

namespace dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int,string> kullanicilar = new Dictionary<int, string>();

            kullanicilar.Add(10,"Ayşe");
            kullanicilar.Add(12,"Ali");
            kullanicilar.Add(14,"Fatma");
            kullanicilar.Add(15,"Mehmet");

            Console.WriteLine(kullanicilar[12]);

            foreach (var item in kullanicilar)
                Console.WriteLine(item);

            //Count
            Console.WriteLine(kullanicilar.Count);

            //Contains
            Console.WriteLine(kullanicilar.ContainsKey(12));
            Console.WriteLine(kullanicilar.ContainsValue("Ahmet"));

            //Remove
            kullanicilar.Remove(12);
            foreach (var item in kullanicilar)
                Console.WriteLine(item);
            
            
            foreach (var item in kullanicilar.Keys)
                Console.WriteLine(item);
            
            foreach (var item in kullanicilar.Values)
                Console.WriteLine(item);
            
            
        }
    }
}

