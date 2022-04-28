using System;
using System.Collections;
using System.Collections.Generic;

namespace kurucu_metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            //Erişim belirleyiciler
            // * Public
            // * Privae
            // * Internal
            // * Protected

            Console.WriteLine("***********Çalışan 1*************");
            Calisan calisan1 = new Calisan("Ayşe", "Kara", 22, "İK");
            calisan1.Ad = "Ayşe";
            calisan1.Soyad = "Yılmaz";
            calisan1.No = 22;
            calisan1.Departman = "İK";
            calisan1.CalisanBilgileri();

            Console.WriteLine("\n***********Çalışan 2*************");
            Calisan calisan2 = new Calisan();
            calisan2.Ad = "Fatma";
            calisan2.Soyad = "Yılmaz";
            calisan2.No = 33;
            calisan2.Departman = "Satın Alma";
            calisan2.CalisanBilgileri();

            Console.WriteLine("\n***********Çalışan 3*************");
            Calisan calisan3 = new Calisan("Ahmet", "Kaya");
            calisan3.CalisanBilgileri();

            
        }
    }

    class Calisan {
        public string Ad;
        public string Soyad;
        public int No;
        public string Departman;

        public Calisan(string ad, string soyad, int no, string departman){
            this.Ad = ad;
            this.Soyad=soyad;
            this.No=no;
            this.Departman=departman;
        }

        public Calisan(string ad, string soyad){
            this.Ad = ad;
            this.Soyad=soyad;
        }

        public Calisan(){}

        public void CalisanBilgileri(){
            Console.WriteLine("Çalışan Adı: {0}",Ad);
            Console.WriteLine("Çalışan Soyadı: {0}",Soyad);
            Console.WriteLine("Çalışan No: {0}",No);
            Console.WriteLine("Çalışan Departmanı: {0}",Departman);
        }
    }
}

