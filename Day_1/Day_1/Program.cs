using System;

namespace Day_1
{
    class Program
    {
        static void Main(string[] args)
        {
            /* int i, j, c = 5, s = 0;
             for(i=9;i>=1;i--)
             {
                 for(j = 1; j <= s; j++)
                 {
                     Console.Write(" ");
                 }
                 for(j=9;j>=c;j--)
                 {
                     Console.Write(" * ");
                 }
                 Console.Write("\n");
                 if (i<6)
                 {
                     s++;
                     c--;
                 }
                 else
                 {
                     s--;
                     c++;
                 }
             }
             Console.ReadLine();*/

            int i, j, c = 5, s = 0;
            for (i = 9; i >= 1; i--)
            {
                for (j = 9; j >= s; j--)
                {
                    Console.Write(" ");
                }
                for (j = 1; j <= c; j++)
                {
                    Console.Write(" * ");
                }
                Console.Write("\n");
                if (i < 6)
                {
                    s++;
                    c--;
                }
                else
                {
                    s--;
                    c++;
                }
            }
            Console.ReadLine();
        }
    }
}
