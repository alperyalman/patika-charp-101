using System;

namespace operatorler
{
    class Program
    {
        static async void Main(string[] args)
        {
            //Atama ve işlemli atama
            Console.WriteLine("Atama ve işlemli atama");
            int x = 3;
            int y = 3;
            y = y+2; 
            Console.WriteLine(y);
            y += 2; // y = y+2
            Console.WriteLine(y);
            y /= 1;
            Console.WriteLine(y);
            x *=2;
            Console.WriteLine(x);
            
            //Mantıksal operatörler
            Console.WriteLine("Mantıksal operatörler");
            bool isSuccess = true;
            bool isCompleted = false;

            if(isSuccess && isCompleted)
                Console.WriteLine("Perfect!");

            if(isSuccess || isCompleted)
                Console.WriteLine("Great!");
            
            if(isSuccess && !isCompleted)
                Console.WriteLine("Fine!");


            // İlişkisel operatorler
            Console.WriteLine("İlişkisel operatorler");
            int a = 3;
            int b = 4;
            bool sonuc = a<b;
            Console.WriteLine(sonuc);
            sonuc = a>b;
            Console.WriteLine(sonuc);
            sonuc = a>=b;
            Console.WriteLine(sonuc);
            sonuc = a<=b;
            Console.WriteLine(sonuc);
            sonuc = a==b;
            Console.WriteLine(sonuc);
            sonuc = a!=b;
            Console.WriteLine(sonuc);

            //Aritmetik operatörler
            Console.WriteLine("Aritmetik operatörler");
            int sayi1 = 10;
            int sayi2 = 5;
            int sonuc1 = sayi1/sayi2;
            Console.WriteLine(sonuc1);
            sonuc1 = sayi1*sayi2;
            Console.WriteLine(sonuc1);
            sonuc1 = sayi1+sayi2;
            Console.WriteLine(sonuc1);
            sonuc1 = sayi1++;
            Console.WriteLine(sonuc1);

            // % mod operatörü
            int sonuc2 = 20%3;
            Console.WriteLine(sonuc2);  


        }
    }
}
