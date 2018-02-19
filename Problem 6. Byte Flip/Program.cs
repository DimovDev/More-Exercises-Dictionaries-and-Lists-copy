using System;
using System.Linq;

namespace Problem_6._Byte_Flip
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine().Split(' ').Where(x=> x.Length==2).ToArray();
           
            for (int i = numbers.Length-1; i >= 0; i--)
            {
                char[] charArray = numbers[i].ToCharArray();
                Array.Reverse(charArray);
                Console.Write(System.Convert.ToChar(System.Convert.ToInt32(new string(charArray),16)));

            }
            Console.WriteLine();      

        }
    }
}
