using System;
using System.Collections;
using System.Collections.Generic;

namespace inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            TohumluBitkiler tohumluBitki = new TohumluBitkiler();
            tohumluBitki.TohumlaCogalma();

            Console.WriteLine("\n****************\n");

            Kuslar marti = new Kuslar();
            marti.Ucmak();
             
        }
    }

}

