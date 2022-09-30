using System;

namespace syntax
{
    class Program
    {
        static void Main(string[] args)
        {
            var answer = 34;
            var response = (answer < 9) ? $"{answer} is less than nine" : $"{answer} is greater than nine";
            Console.WriteLine(response);

        }
    }
}

