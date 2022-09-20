using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Array 

            // int[]numbers=new int[5] {10,20,30,40,50};
            // string[] names = { "rahul", "mahesh", "suraj" };
            // for (int i=0;i<numbers.Length;i++)
            // {
            //     Console.WriteLine($"number{i}={numbers[i]}");
            // }
            // for(int i=0;i<names.Length;i++)
            // {
            //     Console.WriteLine($"names{i}={names[i]}");
            // }

            int[] numbers = new int[5];

            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine($"numbers{i}={numbers[i]}");
            }

            string[] names = new string[5];
            for (int i = 0; i < names.Length; i++)
            {
                names[i] = Convert.ToString(Console.ReadLine());
            }
            for (int i = 0; i <= names.Length; i++)
            {
                Console.WriteLine($"number{i}={names[i]}");
            }
            Console.WriteLine();
        }
    }
}
