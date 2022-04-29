using System;

namespace inheritance
{
    public class Bitkiler:Canlilar {
        public Bitkiler() {
            base.Beslenme();
            base.Solunum();
            base.Sindirim();
        }
        protected void FotsentezYapmak()
        {
            Console.WriteLine("Birkiler fotosentez yapar");
        }   
    }

    public class TohumluBitkiler: Bitkiler {
        public TohumluBitkiler()
        {
            base.FotsentezYapmak();
            // base.Beslenme();
            // base.Solunum();
            // base.Sindirim();  
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