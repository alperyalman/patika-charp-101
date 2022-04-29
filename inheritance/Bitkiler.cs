using System;

namespace inheritance
{
    public class Bitkiler:Canlilar {
        
        protected void FotsentezYapmak()
        {
            Console.WriteLine("Birkiler fotosentez yapar");
        }

        public override void UyaranlaraTepki()
        {
            //base.UyaranlaraTepki();
            Console.WriteLine("Bitkiler güneşe tepki verir");
        }
    }

    public class TohumluBitkiler: Bitkiler {
        public TohumluBitkiler()
        {
            base.FotsentezYapmak();
            base.Beslenme();
            base.Solunum();
            base.Sindirim(); 
            base.UyaranlaraTepki(); 
        }

        public void TohumlaCogalma()
        {
            Console.WriteLine("Tohmulu bitkiler tohumla cogalir");
        }
    }

    public class TohumsuzBitkiler:Bitkiler {

        public TohumsuzBitkiler() {
            base.FotsentezYapmak();
            // base.Beslenme();
            // base.Solunum();
            // base.Sindirim();
        }
        public void SporlaCogalma()
        {
            Console.WriteLine("Tohmsuz bitkiler sporla cogalir");
        }
    }

}