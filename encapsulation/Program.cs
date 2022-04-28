using System;
using System.Collections;
using System.Collections.Generic;

namespace encapsulation
{
    class Program
    {
        static void Main(string[] args)
        {
            Ogrenci ogrenci = new Ogrenci();
            ogrenci.Isim = "Ayşse";
            ogrenci.Soyisim = "Kara";
            ogrenci.OgrenciNo = 2323;
            ogrenci.Sinif = 3;
            ogrenci.OgrenciBilgileriniGetir();

            ogrenci.SinifAtlat();
            ogrenci.OgrenciBilgileriniGetir(); 
            

            Ogrenci ogrenci2 = new Ogrenci("Deniz", "Arda", 256,1);
            ogrenci2.OgrenciBilgileriniGetir();

            ogrenci2.SinifDusur();
            ogrenci2.SinifDusur();
            ogrenci2.OgrenciBilgileriniGetir();
        }
    }

    class Ogrenci
    {
        private string isim;
        private string soyisim; 
        private int ogrenciNo;
        private int sinif;

        public string Isim { get => isim; set => isim = value; }
        public string Soyisim { get => soyisim; set => soyisim = value; }
        public int OgrenciNo { get => ogrenciNo; set => ogrenciNo = value; }
        public int Sinif { 
            get => sinif; 
            
            set 
            {
                if(value<1)
                {
                    Console.WriteLine("Sınf en az 1 olabilir!");
                    sinif = 1;
                }
                else
                    sinif = value;
            } 
        }

        public Ogrenci(string isim, string soyisim, int ogrenciNo, int sinif)
        {
            Isim = isim;
            Soyisim = soyisim;
            OgrenciNo = ogrenciNo;
            Sinif = sinif;
        }

        public Ogrenci(){}

        public void OgrenciBilgileriniGetir(){
            Console.WriteLine("********* Öğrenci Bilgileri *********");
            Console.WriteLine("Öğrenci Adı: {0}", this.Isim);
            Console.WriteLine("Öğrenci Soyadı: {0}", this.Soyisim);
            Console.WriteLine("Öğrenci No: {0}", this.OgrenciNo);
            Console.WriteLine("Sınıf: {0}", this.Sinif);
        }

        public void SinifAtlat()
        {
            this.Sinif += 1;
        }

        public void SinifDusur()
        {
            this.Sinif -= 1;
        }
    }
}

