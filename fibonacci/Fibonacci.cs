using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fibonacci
{
    public class Fibonacci
    {
        public static void Main()
        {
            Console.WriteLine("Enter the number to print the Fibonacci series..");
            int num = Convert.ToInt32(Console.ReadLine());
            Fibonacci obj = new Fibonacci();
            string str = obj.getFibonacciNumbers(num);
            Console.WriteLine(str);
        }
        public  string getFibonacciNumbers(int n)
        {
            StringBuilder str = new StringBuilder();
            int f1 = 0, f2 = 1, i;

            if (n < 1)
                return String.Empty;
            str.Append(f1 + " ");
            for (i = 1; i < n; i++)
            {
                str.Append(f2 + " ");
                int next = f1 + f2;
                f1 = f2;
                f2 = next;
            }
            return str.ToString().Trim();
        }

    }
}
