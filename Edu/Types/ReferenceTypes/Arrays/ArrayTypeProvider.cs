using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Edu.Types.ReferenceTypes.Arrays
{
    public static class ArrayTypeProvider
    {
        public static void PrintArrayTypeResults()
        {
            const int minIndex = 0;
            const int maxIndex = 4;           

            var numbers = new int[5] { 1, 2, 3, 4, 5 };
            numbers[minIndex] = 1;
            numbers[maxIndex] = 5;

            Console.WriteLine($"For");

            for (var index = 0; index < numbers.Length; index++)
            {
                Console.WriteLine($"Array[{index}] = {numbers[index]}");
            }

            Console.WriteLine($"Foreach:");

            foreach (var number in numbers) 
            {
                Console.WriteLine($"Array[{Array.IndexOf(numbers, number)}] = {number}");
            }

            Console.WriteLine($"Do While:");

            var i = 0;
            do
            {
                Console.WriteLine($"Array[{i}] = {numbers[i]}");
                i++;
            }
            while (i < numbers.Length);

            Console.WriteLine($"While:");

            var j = numbers.Length - 1;
            while (j >= 0)
            {
                Console.WriteLine($"Array[{j}] = {numbers[j]}");
                j--;
            }

            try
            {
                var missingElementIndex = 6;
                var missingElement = numbers[missingElementIndex];
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }
    }
}
