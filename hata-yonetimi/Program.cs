using System;

namespace hata_yonetimi
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Sayi giriniz: ");
                int sayi = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Girdiginiz sayi: " + sayi);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Hata: " + ex.Message.ToString());
            }
            finally // Optional
            {
                Console.WriteLine("Islem tamamlandi!");
            }

            try
            {
                // int a = int.Parse(null);
                // int b = int.Parse("test");
                int c = int.Parse("1111111111111");
            }
            catch (ArgumentNullException ex)
            {
                Console.WriteLine("Bos deger girdiniz");
                Console.WriteLine(ex);
            }
            catch(FormatException ex)
            {
                Console.WriteLine("Format uygun degil");
                Console.WriteLine(ex);
            }
            catch(OverflowException ex)
            {
                Console.WriteLine("Cok kucuk veya buyuk bir deger girildi");
                Console.WriteLine(ex);
            }


            
        }
    }
}
