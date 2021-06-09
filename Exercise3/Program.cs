using System;

namespace Exercise3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("please type a string");
            string str = Console.ReadLine();
            char[] cArr = str.ToCharArray();
            Array.Reverse(cArr);
            str = new string(cArr);
            Console.WriteLine($"the reverse of string is {str}");
        }
    }
}
