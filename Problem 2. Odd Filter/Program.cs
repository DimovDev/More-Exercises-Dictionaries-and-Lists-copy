using System;
using System.Linq;

namespace Problem_2._Odd_Filter
{
    class Program
    {
        static void Main(string[] args)
        {
            var oddest = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            oddest.RemoveAll(x => x % 2 == 1);
            double average = oddest.Sum() / oddest.Count;
            for (int i = 0; i < oddest.Count; i++)
            {
              
                if (oddest[i]>average)
                {
                    oddest[i] +=1 ;
                }
                else
                {
                    oddest[i] -= 1;

                }

            }
            Console.WriteLine(string.Join(" ",oddest));
        }
    }
}
