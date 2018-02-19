using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem_1._Sort_Times
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> tames = Console.ReadLine().Split(' ').ToList();
            tames.Sort();
            Console.WriteLine(string.Join(", ",tames));
        }
    }
}
