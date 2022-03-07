using System;

namespace donguler_for_loop // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = 6;
            String result = "";

           //Write even numbers
            for (int i = 1; i<50; i++)
            {
                if(i%2 != 0)
                    continue;
                Console.Write(i + " - ");
            }

            Console.WriteLine();


            for (int i = 1; i<=n; i++)
            {
                if(n == 0)
                    break;
                result += new String(' ', n-i) + new String('#',i) + "\n";
            }
            Console.WriteLine(result);

                
        }
    }
}