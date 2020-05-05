using System;
using System.Collections.Generic;
using System.Linq;

namespace ReturnHighLowFromString
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var resu = HighAndLow("8 3 -5 42 -1 0 0 -9 4 7 4 -4");
            Console.Write(resu);
        }
        public static string HighAndLow(string numbers)
        {
            var _numbers = numbers.Split(' ').Select(Int32.Parse).ToList();

            int low = _numbers.Min();
            int high = _numbers.Max();
            string toReturn = "";
            toReturn = toReturn + high.ToString() + " " + low.ToString();

            return toReturn;
        }
    }
}
