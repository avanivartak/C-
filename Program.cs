using System;

namespace MyFIrstConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /**string str = Console.ReadLine();
            Console.WriteLine(str);
            int num = System.Console.Read();// returns ascii value 
            Console.WriteLine("Sum is {0}",num1+num2); //{0} placeholder for index no.(0) of referred variable
             **/
            int num1, num2;
            Console.WriteLine("Enter a value");

            num1 = Int32.Parse(Console.ReadLine());
            num2 = Int32.Parse(Console.ReadLine());
            //AddNum(num1,num2);
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

