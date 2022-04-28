using System;
using System.Collections;
using System.Collections.Generic;

namespace sinif_kavrami
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

            Calisan calisan1 = new Calisan();
            calisan1.Ad = "Ayşe";
            calisan1.Soyad = "Yılmaz";
            calisan1.No = 22;
            calisan1.Departman = "İK";
            calisan1.CalisanBilgileri();
            Console.WriteLine("************************");

            Calisan calisan2 = new Calisan();
            calisan2.Ad = "Fatma";
            calisan2.Soyad = "Yılmaz";
            calisan2.No = 33;
            calisan2.Departman = "Satın Alma";
            calisan2.CalisanBilgileri();


            
        }
    }

    class Calisan {
        public string Ad;
        public string Soyad;
        public int No;
        public string Departman;

        public void CalisanBilgileri(){
            Console.WriteLine("Çalışan Adı: {0}",Ad);
            Console.WriteLine("Çalışan Soyadı: {0}",Soyad);
            Console.WriteLine("Çalışan No: {0}",No);
            Console.WriteLine("Çalışan Departmanı: {0}",Departman);
        }
    }
}

