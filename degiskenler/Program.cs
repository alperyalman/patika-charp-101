using System;

namespace degiskenler
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            //String ifadeler           
            string degisken = null;
            string Degisken = null;
            String str = " ";
            char ch = 'c'; // 2 byte
            //String ifadeler
            string str1 = string.Empty;
            str1 = "Ad-Soyad";
            string ad = "Ad";
            string soyad = "Soyad";
            string tamisim = ad + "-" + soyad;
            Console.WriteLine(tamisim);

            //8 bit variables
            byte b = 5; // 1 byte [0-255]
            sbyte sb = 5; // 1 byte [-128 127]
            
            //16 bit variables
            short s = 5;    //2 byte 
            ushort u_s = 5; //2 byte 
            Int16 i16 = 1; //2 byte

            //32 bit variable types
            int i = 2; // 4 byte
            uint ui = 2; //4 byte 
            Int32 i32 = 1; //4 byte

            //64 bit variables
            Int64 i64 = 1; //8 byte 
            long l = 1; //8 byte
            ulong ul = 1; //8 byte

            //Floating numbers
            float f = 1.1F; // 4 byte
            double d = 2.2; // 8 byte
            decimal de = 3.3M; // 16 byte

            //Boolean variables
            bool b1 = true;
            bool b2 = false;
            bool b3 = 10<2;

            //Date and Time
            DateTime dt = DateTime.Now;
            Console.WriteLine(dt);

            string datetime = DateTime.Now.ToString("dd.mm.yyyy");
            Console.WriteLine(datetime);
            string datetime2 = DateTime.Now.ToString("dd/mm/yyyy");
            Console.WriteLine(datetime2);
            string time = DateTime.Now.ToString("HH:mm");
            Console.WriteLine(time);
            
            //Objects
            object o1 = "x";
            object o2 = 'c';
            object o3 = 1;
            object o4 = 1.1;

            //Degisken Donusumleri
            string str20 = "20";
            int int20 = 20;
            string yeniDeger = str20 + int20.ToString();
            Console.WriteLine(yeniDeger); // -> 2020

            int int21 = int20 + Convert.ToInt32(str20);
            Console.WriteLine(int21); // -> 40

            int int22 = int20 + int.Parse(str20);
            Console.WriteLine(int22); // -> 40

            Console.Read();





            


        }
    }
}
