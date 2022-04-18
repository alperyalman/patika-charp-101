using System;
using System.Collections;
using System.Collections.Generic;

namespace array_list
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList liste = new ArrayList();
            liste.Add("Ayse");
            liste.Add(2);
            liste.Add(true);
            liste.Add('a');

            Console.WriteLine(liste[1]);            
            foreach (var item in liste)
            {   
                Console.WriteLine(item);
            }

            // Add Range
            string[] renkler = {"Kirmizi","Yesil","Sari"};
            List<int> sayilar = new List<int>(){1,2,4,5,75,3,65};
            liste.AddRange(renkler);
            liste.AddRange(sayilar);

            liste.Clear();

            liste.Add(sayilar);
            
            //Sort-Sıralama
            liste.Sort();
            foreach (var item in liste)
            {
                Console.WriteLine(item);
            }

            //Reverse
            liste.Reverse();

            //Binary search
            Console.WriteLine(yeniListe.BinarySearch(5));
        }
    }
}

