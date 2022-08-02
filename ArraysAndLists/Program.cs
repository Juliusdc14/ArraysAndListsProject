using System;
using System.Collections.Generic;

namespace ArraysAndLists
{
    class Program
    {
        public static int i { get; private set; }

        static void Main(string[] args)
        {

            var numbers = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };



            var evens = new List<int>();

            var odds = new List<int>();



            
            foreach (var num in numbers)
            {
                if (num % 2 == 0)
                {
                    evens.Add(num);
                }
                else
                {
                    odds.Add(num);
                }
            }

            

            foreach (var item in evens)
            {
                Console.WriteLine($"{item} is a even number!");
            }
            foreach (var oddNumbers in odds)
            {
                Console.WriteLine($"{oddNumbers} its really an odd number!");
            }
        }
    }
}