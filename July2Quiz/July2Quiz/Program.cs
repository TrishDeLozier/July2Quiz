using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace July2Quiz
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, smallest;
            Console.WriteLine("Please enter a number: ");
            num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter another number: ");
            num2 = int.Parse(Console.ReadLine());
            smallest = SmallestNumber(num1, num2);
            Console.WriteLine("The smallest number is: " + smallest);
        }

        static public int SmallestNumber(int num1, int num2)
    {
        int smallest;
            if (num1 > num2)
            smallest = num2;
            else
            smallest = num1;
        return smallest;
    }
    }
}
