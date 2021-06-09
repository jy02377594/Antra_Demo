using System;

namespace Exercise2
{
    public class Arithmetic
    {
        public int Addition(int n1, int n2)
        {
            return n1 + n2;
        }

        public int Subtraction(int n1, int n2)
        {
            return n1 - n2;
        }

        public int multiplication(int n1, int n2)
        {
            return n1 * n2;
        }

        public double division(int n1, int n2)
        {
            return Convert.ToDouble((n1 + 0.00) / (n2 + 0.00));
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int a, b;
            Arithmetic math = new Arithmetic();
            Console.WriteLine("please enter a");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("please enter b");
            b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Addition:{math.Addition(a, b)}");
            Console.WriteLine($"Subtraction:{math.Subtraction(a, b)}");
            Console.WriteLine($"multiplication:{math.multiplication(a, b)}");
            Console.WriteLine($"division:{math.division(a, b)}");

            Console.ReadKey();
        }
    }
}
