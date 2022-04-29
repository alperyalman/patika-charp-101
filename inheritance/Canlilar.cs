using System;

namespace inheritance
{
    public class Canlilar // public sealed class Canlilar: sealed ile kalıtım engelleniyor
    {
        protected void Beslenme()
        {
            Console.WriteLine("Canlilar beslenir");
        }

        protected void Solunum()
        {
            Console.WriteLine("Canlilar solunum yapar");
        }

        protected void Sindirim()
        {
            Console.WriteLine("Canlilar sindirim yapar");
        }

        public virtual void UyaranlaraTepki()
        {
            Console.WriteLine("Canlılar uyaranlar tepki verir");
        }
    }

}