using System;
using System.Linq;

class Solution
{

    static void Main(String[] args)
    {
        var numbers = Console.ReadLine().Split(' ').Select(x => long.Parse(x)).ToList();
        var sumOfAllNumbers = 0L;
        var minimum = long.MaxValue;
        var maximum = 0L;
        for (int i = 0; i < 5; i++)
        {
            sumOfAllNumbers += numbers[i];
            if (numbers[i] < minimum)
                minimum = numbers[i];

            if (numbers[i] > maximum)
                maximum = numbers[i];

        }
        Console.WriteLine(string.Format("{0} {1}", sumOfAllNumbers - maximum, sumOfAllNumbers - minimum));
    }
}
