using System;

namespace stringmetotlar // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string degisken = "Dersimiz c#";
            string degisken2 = "Dersimiz C#";
            //Lenght
            Console.WriteLine(degisken.Length);

            //Toupper ToLower
            Console.WriteLine(degisken.ToUpper());
            Console.WriteLine(degisken.ToLower());

            //Concat
            Console.WriteLine(String.Concat(degisken," Merhaba"));

            // Compare, CompareTo
            Console.WriteLine(String.Compare(degisken, degisken2, true));
            Console.WriteLine(String.Compare(degisken, degisken2, false));
            Console.WriteLine(degisken.CompareTo(degisken2));

            //Contains
            Console.WriteLine(degisken.Contains(degisken2));
            Console.WriteLine(degisken.EndsWith("c#"));
            Console.WriteLine(degisken.StartsWith("Ders"));
            
            //Indexof
            Console.WriteLine(degisken.IndexOf("c#"));


            //Insert
            Console.WriteLine(degisken.Insert(0,"Merhaba "));
            Console.WriteLine(degisken.LastIndexOf("i"));

            //Padleft, padright
            Console.WriteLine(degisken + degisken2.PadLeft(30));
            Console.WriteLine(degisken + degisken2.PadLeft(30,'*'));
            Console.WriteLine(degisken.PadRight(30) + degisken2);
            Console.WriteLine(degisken.PadRight(30,'-') + degisken2);

            //Remove 
            Console.WriteLine(degisken.Remove(5));
            Console.WriteLine(degisken.Remove(5, 3));
            Console.WriteLine(degisken.Remove(0,1));
            
            //Replace
            Console.WriteLine(degisken.Replace("c#", ".net"));

            //Split
            Console.WriteLine(degisken.Split(' ')[1]);

            //Substring
            Console.WriteLine(degisken.Substring(4));
            Console.WriteLine(degisken.Substring(4,4));
            

            
        }
    }
}