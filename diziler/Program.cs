using System;

namespace diziler // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("============ Diziler ============");

            // Dizi index'i 0'dan başlar. Yani 5 elemanlı bir dizinin ilk elemanı 0. indexte sonuncu elemanı 4. indextedir.

            int[] sayilar = new int[10];
            sayilar[2] = 12;

            // Yukarıda örnek bir dizi tanımlaması görüyoruz. Integer tipinde veri tutan 10 elemanlı bir dizi tanımladık. Ve dizinin 3. elemanına yani 2. indexine 12 değerini atadık.

            string[] renklerr = {"Mavi","Kırmızı","Sarı","Yeşil"};
            // Dizilerin elemanlarını dizi tanımı yapılırken verebiliriz. Yukarıdaki örnekte göreceğiniz üzere string tipinde bir dizi tanımladık. Ve elemanları bize bunun 4 elemanlı bir dizi olduğunu söylüyor.

            // Dizi tanımlandığı anda eleman sayısı belirlenmek zorunda değildir. Önce tanımı yapıp daha sonradan eleman sayısı da atanabilir. Ama bir dizinin büyüklüğü yani bellekte ne kadar yer kaplayacağı dizi kullanılmadan önce mutlaka belirlenmelidir.

            int[] dizi;
            dizi = new int[4];
            // Yukarıdaki örnekte önce integer tipinde "dizi" adında bir dizi tanımı yaptık. Alt satırda da bu dizinin 4 elemanlı bir dizi olacağını söyledik.

            // Dizilere Erişim
            // Aşağıdaki örnekte de görebileceğiniz gibi dizilere index numaraları ile erişilebilir.

            string[] renkler = {"Mavi","Kırmızı","Sarı","Yeşil"};
            string renk = renkler[1]; // Kırmızı rengi getirir.
            // Döngülerle Dizi Kullanımı
            int[] sayiDizisi = new int[10];
            int toplam = 0;
            for (int i = 0; i < sayiDizisi.Length; i++)
            {
                Console.Write("Lütfen {0}. sayıyı girin:", i+1);
                sayiDizisi[i] = Convert.ToInt32(Console.ReadLine());
                toplam += sayiDizisi[i];
            }
            double ortalama = toplam / sayiDizisi.Length;
            
            Console.WriteLine("Sayıların toplamı: " + toplam);
            Console.WriteLine("Sayıların ortalaması: " + ortalama);
            Console.ReadLine();
        }
    }
}