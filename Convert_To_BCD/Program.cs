using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Convert_To_BCD
{
    class Program
    {
        static void Main(string[] args)
        {
            int number, c;
            string[] a = { "0000", "0001", "0010", "0011", "0100", "0101", "0110", "0111", "1000", "1001" };

            Stack<int> myStack = new Stack<int>();
            StringBuilder result = new StringBuilder();

            number = int.Parse(Console.ReadLine());

            while (number != 0)
            {
                c = number % 10;
                myStack.Push(c);
                number /= 10;
            }

            while (myStack.Count != 0)
                result.Append(a[myStack.Pop()] + " ");

            Console.WriteLine(result);
            Console.ReadKey();
        }
    }
}
