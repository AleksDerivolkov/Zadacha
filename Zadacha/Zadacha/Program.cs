using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input 3 words!");
            Console.Write($"Input First Word:/");
            string first = Console.ReadLine();
            Console.Write("Input Second Word:/");
            string second = Console.ReadLine();
            Console.Write("Input Third Word:/");
            string third = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("Which word do you like [1,2,3]?");
            int num = int.Parse(Console.ReadLine());
            if (num == 1) Console.WriteLine($"Your Word is:{first}");
            else if (num == 2) Console.WriteLine($"Your Word is:{second}");
            else Console.WriteLine($"Your Word is:{third}");
        }
    }
}
