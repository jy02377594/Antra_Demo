using System;

namespace Exercise7
{
    class Program
    {
        static void Main(string[] args)
        {
            int balanceNum = 1000;
            Console.WriteLine("Enter Your Pin Number");
            int pin = Convert.ToInt32(Console.ReadLine());
            if (pin != 123)
            {
                Console.WriteLine("Pin Number is wrong, system quit");
            }
            else
            {
                Console.WriteLine("********Welcome to ATM Service**************");
                Console.WriteLine();
                Console.WriteLine("1. Check Balance");
                Console.WriteLine();
                Console.WriteLine("2. Withdraw Cash");
                Console.WriteLine();
                Console.WriteLine("3. Deposit Cash");
                Console.WriteLine();
                Console.WriteLine("4. Quit");
                Console.WriteLine();
                Console.WriteLine("*********************************************");
                Console.WriteLine("Enter your choice:");
                int choice = 0;
                while (choice != 4)
                {
                    choice = Convert.ToInt32(Console.ReadLine());
                    switch (choice)
                    {
                        default:
                            Console.WriteLine("wrong choice");
                            Console.WriteLine();
                            Console.WriteLine("Enter your choice:");
                            continue;
                        case 1:
                            Console.WriteLine($"YOU’RE BALANCE IN Rs: {balanceNum}");
                            Console.WriteLine();
                            Console.WriteLine("Enter your choice:");
                            continue;
                        case 2:
                            Console.WriteLine("How much you want to withdrawal?");
                            int wNum = Convert.ToInt32(Console.ReadLine());
                            if(wNum > balanceNum) Console.WriteLine("you have not enough money");
                            else balanceNum -= wNum;
                            Console.WriteLine($"YOU’RE BALANCE IN Rs: {balanceNum}");
                            Console.WriteLine();
                            Console.WriteLine("Enter your choice:");
                            continue;
                        case 3:
                            Console.WriteLine("How much you want to deposit?");
                            int dNum = Convert.ToInt32(Console.ReadLine());
                            balanceNum += dNum;
                            Console.WriteLine($"YOU’RE BALANCE IN Rs: {balanceNum}");
                            Console.WriteLine();
                            Console.WriteLine("Enter your choice:");
                            continue;
                        case 4:
                            break;
                    }
                }
            }
        }
    }
}
