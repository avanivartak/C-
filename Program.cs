using System;

namespace MyFIrstConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1, num2;
            Console.WriteLine("Enter a value");

            num1 = Int32.Parse(Console.ReadLine());
            num2 = Int32.Parse(Console.ReadLine());
            GreatestOfTwo(num1, num2);
        }
        static void AddNum(int num1, int num2)
        {
            Console.WriteLine("Sum is {0} and {1} is {2}", num1, num2, num1 + num2);

        }
        static void GreatestOfTwo(int num1,int num2)
        {
            if (num1 > num2)
            {
                Console.WriteLine("{0} is greater", num1);
            }
            else if(num2>num1)
            {
                Console.WriteLine("{0} is greater", num2);
            }
            else
            {
                Console.WriteLine("Both are same numbers");
            }

        }
    }
}

