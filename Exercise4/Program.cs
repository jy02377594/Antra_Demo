using System;

namespace Exercise4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("please type number 1");
            int n1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("please type number 2");
            int n2 = Convert.ToInt32(Console.ReadLine());
            for (int i = n1; i <= n2; i++)
            {
                int armstrongNum = 0, num = i;
                while (num > 0)
                {
                    armstrongNum += Convert.ToInt32(Math.Pow((num % 10), 3));
                    num = num / 10;
                }
                if (armstrongNum == i) Console.WriteLine($"The armstrongNum is {armstrongNum}");
            }
        }
    }
}
