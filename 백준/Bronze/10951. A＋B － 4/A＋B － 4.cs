using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baekjoon
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                string input = Console.ReadLine();
                if (input == null) break;
                string[] n = input.Split();
                int x = int.Parse(n[0]);
                int y = int.Parse(n[1]);
                Console.WriteLine(x+y);
            }
        }
    }
}