using System;

namespace LargestNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c;

            Console.WriteLine("Enter value of a:");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter value of b:");
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter value of c:");
            c = Convert.ToInt32(Console.ReadLine());

            if (a > b && a > c)
            {
                Console.WriteLine("Largest Number is:"+a );

            }
            else if (b > a && b > c)
            {
                Console.WriteLine("Largest Number is:"+b);
            }
            else {
                Console.WriteLine("Largest Number is:"+c);
            }
            
        }
    }
}
