using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 1;
            int b = 1;
            string c = "Marisa";
            int d = 2;
            if (Comparison<int>(a, b))
                Console.WriteLine("They are the same");
            else
                Console.WriteLine("They are different");

            if (Comparison2<string, int>(c, d))
                Console.WriteLine("They are the same");
            else
                Console.WriteLine("They are different");
        }
        public static bool Comparison<T>(T input1, T input2)
        {
            if (input1.ToString().Equals(input2.ToString()))
                return true;
            else
                return false;
        }
        public static bool Comparison2<T,Z>(T input3, Z input4)
        {
            if (input3.ToString().Equals(input4.ToString()))
                return true;
            else
                return false;

        }
    }
}
