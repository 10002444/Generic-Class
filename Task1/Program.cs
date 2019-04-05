using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.Write("Please enter a number: ");
            int num = int.Parse(Console.ReadLine());
            Console.Write("Please enter a string: ");
            string name = Console.ReadLine();

            GenericClass<int, string> check = new GenericClass<int, string>();
            if (check.Comparison(num, name))
                Console.WriteLine("They are the same");
            else
                Console.WriteLine("They are different");
        }

        class GenericClass<T, Z>
        {
            public bool Comparison(T input1, Z input2)
            {
                if (input1.ToString().Equals(input2.ToString()))
                    return true;
                else
                    return false;
            }
        }
    }
}
