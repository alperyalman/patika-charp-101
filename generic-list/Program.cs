using System;
using System.Collections.Generic;

namespace generic_list
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> sayiListesi = new List<int>();
            sayiListesi.Add(12);
            sayiListesi.Add(123);
            sayiListesi.Add(14);
            sayiListesi.Add(165);
            sayiListesi.Add(43);
            sayiListesi.Add(32);
            sayiListesi.Add(18);

            List<string> renkListesi = new List<string>();
            renkListesi.Add("Sari");
            renkListesi.Add("Mavi");
            renkListesi.Add("Yesil");
            renkListesi.Add("Kirmizi");
            renkListesi.Add("Turuncu");
            renkListesi.Add("Mor");

            //Count
            Console.WriteLine(sayiListesi.Count);
            Console.WriteLine(renkListesi.Count);

            // Foreach ile erişim
            foreach (var sayi in sayiListesi)
            {
                Console.WriteLine(sayi);
            }

            foreach (var renk in renkListesi)
            {
                Console.WriteLine(renk);
            }

            sayiListesi.ForEach(sayi=> Console.WriteLine(sayi));
            renkListesi.ForEach(renk=> Console.WriteLine(renk));


            //Remove
            sayiListesi.Remove(165);
            renkListesi.Remove("Mavi");

            sayiListesi.ForEach(sayi=> Console.WriteLine(sayi));
            renkListesi.ForEach(renk=> Console.WriteLine(renk));

            sayiListesi.RemoveAt(0);
            renkListesi.RemoveAt(0);

            sayiListesi.ForEach(sayi=> Console.WriteLine(sayi));
            renkListesi.ForEach(renk=> Console.WriteLine(renk));

            //Liste içinde arama
            Console.WriteLine(sayiListesi.Contains(10));
            Console.WriteLine(renkListesi.Contains("Turuncu"));

            Console.WriteLine(sayiListesi.BinarySearch(10));
            Console.WriteLine(renkListesi.BinarySearch("Yesil"));

            //Diziyi list'e çevirme
            string[] hayvanlar = {"Kedi","Kopek","Kus"};
            List<string> hayvanListesi = new List<string>(hayvanlar);
            
            //Listeyi temizleme 
            hayvanListesi.Clear();

            //Liste içinde nesne tutmak 
            List<Kullanicilar> kullaniciListesi = new List<Kullanicilar>();
            Kullanicilar kullanici1 = new Kullanicilar();
            kullanici1.Isim = "Ayse";
            kullanici1.Soyisim = "Ay";
            kullanici1.Yas = 12;
            
            Kullanicilar kullanici2 = new Kullanicilar();
            kullanici2.Isim = "Fatma";
            kullanici2.Soyisim = "Boy";
            kullanici2.Yas = 13;

            kullaniciListesi.Add(kullanici1);
            kullaniciListesi.Add(kullanici2);

            List<Kullanicilar> yeniKullaniciListesi = new List<Kullanicilar>();
            yeniKullaniciListesi.Add(new Kullanicilar(){
                Isim="Arda", 
                Soyisim = "Fatma",
                Yas = 24
            });


            foreach (var kullanici in kullaniciListesi)
            {
                Console.WriteLine(kullanici.Isim);
                Console.WriteLine(kullanici.Soyisim);
                Console.WriteLine(kullanici.Yas);
            }


        }
    }

    public class Kullanicilar{
        private string isim;
        private string soyisim;
        private int yas;

        public string Isim {get => isim; set => isim = value; }
        public string Soyisim {get => soyisim; set => soyisim = value; }
        public int Yas {get => yas ; set => yas = value; }
    }
}

