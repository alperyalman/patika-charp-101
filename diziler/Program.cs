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
            int[] sayiDizisi = new int[5];
            int toplam = 0;
            for (int i = 0; i < sayiDizisi.Length; i++)
            {
                Console.Write("Lütfen {0}. sayıyı girin:", i+1);
                sayiDizisi[i] = Convert.ToInt32(Console.ReadLine());
                toplam += sayiDizisi[i];
            }
            double ortalama = toplam / sayiDizisi.Length;
            
            Console.Write("Sayi Dizisi: ");
            foreach (int sayi in sayiDizisi) 
                Console.Write("{0}, ", sayi);
            Console.WriteLine();

            Console.WriteLine("Sayıların toplamı: " + toplam);
            Console.WriteLine("Sayıların ortalaması: " + ortalama);
            Console.ReadLine();

            Console.WriteLine("========== Array sınıfı ve metodları =========");
            // Array.Sort
            // Diziler üzerinden sıralama işlemi yapar. Eğer string bir dizi ise alfabetik olarak olarak A'dan Z'ye sıralar. Eğer numeric bir dizi ise dizi elemanlarını küçükten büyüğe sıralar.
            Console.WriteLine("Array.Sort");
            Array.Sort(sayiDizisi);
            Console.Write("Sayi Dizisi: ");
            foreach (int sayi in sayiDizisi) 
                Console.Write("{0}, ", sayi);
            Console.WriteLine();
            
            // Array.Clear
            // Dizinin belirtilen elemanlarını varsayılan değerine getirir. Yani örneğin numeric bir dizi ise 0 olarak setler.
            // Örnek: Aşağıdaki örnek sayi dizisinin 2.indexinden başlayarak 2 tane elemanı temizler.
            Console.WriteLine("Array.Clear");
            Array.Clear(sayiDizisi,2,2);
            Console.Write("Sayi Dizisi: ");
            foreach (int sayi in sayiDizisi) 
                Console.Write("{0}, ", sayi);
            Console.WriteLine();
            

            // Array.Reverse
            // Dizinin ortasını belirleyerek elemanlarını aynalar gibi düşünebilirsiniz. Yani dizinin ilk elemanı ile son elemanını yer değiştirir.
            Console.WriteLine("Array.Reverse");
            Array.Reverse(sayiDizisi);
            Console.Write("Sayi Dizisi: ");
            foreach (int sayi in sayiDizisi) 
                Console.Write("{0}, ", sayi);
            Console.WriteLine();
            
            // Array.IndexOf
            // Verilen dizinin verilen elemanının indexini getirir. Eğer dizi içerisinde elemanı bulamazsa -1 döner.
            Console.WriteLine("Array.IndexOf");
            Console.WriteLine(Array.IndexOf(sayiDizisi,37));
            
            // Array.Resize
            // Dizileri yeniden boyutlandırmak için kullanılır.

            Console.WriteLine("Array.Resize");
            int[] sayiDizisi2 = {1,3,4,9,8,7};
            Array.Resize<int>(ref sayiDizisi2,12);
            sayiDizisi2[6] = 10;
            Console.Write("Sayi Dizisi: ");
            foreach (int sayi in sayiDizisi2) 
                Console.Write("{0}, ", sayi);
            Console.WriteLine();
            
            // Yukarıdaki örnekte başlangıçta 6 elemanlı olan sayiDizisi Resize metodu ile 12 elemanlı hale getirildi. Daha sonra 7. elemanına 10 değeri atandı. Diğer boş olan indexlerin değeri ise varsayılan olarak 0 atanır.

            int[] sayiDizisi3 = {1,3,4,9,8,7};
            Array.Resize<int>(ref sayiDizisi3,3);
            Console.Write("Sayi Dizisi: ");
            foreach (int sayi in sayiDizisi3) 
                Console.Write("{0}, ", sayiDizisi3);
            Console.WriteLine();
            // Yukarıdaki örnekte başlangıçta 6 elemanlı olan sayiDizisi Resize metodu ile 3 elemanlı hale getirildi. sondaki 3 eleman kırpıldı. Artık dizi şu şekilde: {1,3,4}
        }
    }
}