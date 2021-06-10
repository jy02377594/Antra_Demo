using System;

namespace Exercise5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("please type the number of rows");
            int lastnum = 0, row = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i <= row; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    if (lastnum == 0)
                    {
                        Console.Write("1");
                        lastnum = 1;
                    }
                    else
                    {
                        Console.Write("0");
                        lastnum = 0;
                    }
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
