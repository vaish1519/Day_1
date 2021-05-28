using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_2
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int a, b,n;
            Console.Write("Enter first no");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter second no");
            b = Convert.ToInt32(Console.ReadLine());
            Console.Write("Select you option \n 1. Addition \n 2.Substraction \n 3.Multiplication \n 4.Division");
            n = Convert.ToInt32(Console.ReadLine());
            switch (n)
            {
                case 1:
                    int sum = Addition(a, b);
                    Console.WriteLine("Addition:" + sum);
                    break;
                case 2:
                    int sub = Substraction(a, b);
                    Console.WriteLine("Substraction:" + sub);
                    break;
                case 3:
                    int div = Division(a, b);
                    Console.WriteLine("Division:" + div);
                    break;
                case 4:
                    int mul = Multiplication(a, b);
                    Console.WriteLine("Multiplication:" + mul);
                    break;
            }


        }
        public static int Addition(int a, int b)
        {
            return (a + b);
        }
        public static int Substraction(int a, int b)
        {
            return (a - b);
        }
        public static int Multiplication(int a, int b)
        {
            return (a * b);
        }
        public static int Division(int a, int b)
        {
            return (a / b);
        }
    }
}


