using System;

namespace metotlar // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        // Referans olarak bir atama yapıldığında ise fonksiyona ilgili değişkenin bellekteki adresi gönderilmiş gibi düşünebilirsiniz. 
        // Dolayısıyla fonksiyon asıl değişken üzerinde değişiklik yapar. Fonksiyon içerisinde bir değişiklik yapıldığında çağırıldığı 
        // yerdeki değişken de değişikliğe uğramış olur. Yani değeri değişir. Bu nedenle ref anahtar kelimesini kullanırken çok dikkatli olunmalıdır.
        public static int ArttirVeToplaRef (ref int x, ref int y)
        {
            x+=1;
            y+=y;
            return (x+y);
        }

        public static int ArttirVeTopla (int x, int y)
        {
            x+=1;
            y+=y;
            return (x+y);
        }
        

        static void Main(string[] args)
        {
            int x = 3;
            int y = 4;  

            int sonuc = ArttirVeTopla (x, y);

            Console.WriteLine("x = {0}, y = {1}, Arttırılmış Toplam = {2}", x,y,sonuc);

            //Ref Kullanımının Özellikleri:
            // Referans olarak iletilmek istenen değişkenin önüne "ref" yazılmalıdır.
            // ref olarak metoda verilen değişkenin mutlaka bir başlangıç değeri olmak zorundadır.
            sonuc = ArttirVeToplaRef(ref x, ref y);
            Console.WriteLine("x = {0}, y = {1}, Arttırılmış Toplam = {2}", x,y,sonuc);

            Console.ReadLine();


        }

        
    }
}