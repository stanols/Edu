using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Edu.Loops
{
    public static class Loop
    {
        public static void PrintLoopResults()
        {
            var index = 0;

            for (; ; )
            {
                Console.WriteLine("Simple infinite loop if there is no condition to exit below.");
                if (index == 0)
                {
                    break;
                }
            }

            for (; index < 3;)
            {
                Console.WriteLine("More complex for loop.");
                index++;
            }

            Console.WriteLine("Hard case.");
            for (int i = 0, j = 10; i < 10; i++, j--)
            {
                Console.WriteLine($"Even i[{i}]? {i % 2 == 0}, odd j[{j}]? {j % 2 != 0}");
            }

            Console.WriteLine("Do loop");
            index = 0;
            do
            {
                Console.WriteLine($"do-while: {index}");

                if (index == 2)
                {
                    Console.WriteLine($"index {index} was skipped");
                    index++; //otherwise infinite loop
                    continue;
                }

                index++;
            }
            while (index < 5);

            Console.WriteLine("While loop");
            index = 5;
            while (index > 0)
            {
                Console.WriteLine("while: {index}");

                if (index == 2)
                {
                    Console.WriteLine($"index {index} breaks the loop");
                    break;
                }

                index--;
            }

            Console.WriteLine("Loop through collections");

            var names = new List<string> { "Pasha", "Natasha", "Katya" };
            var ages = new Dictionary<string, ushort>
            {
                { "Pasha", 28 },
                { "Natasha", 23 },
                { "Katya", 28 }
            };

            foreach (var name in names)
            {
                Console.WriteLine($"My name is {name}");
            }

            foreach (var key in ages.Keys)
            {
                Console.WriteLine($"My name is {key} and age is {ages[key]}");
            }

            foreach (var value in ages.Values)
            {
                Console.Write($"{value} ");
            }
        }
    }
}
