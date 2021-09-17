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
            const int maxIndex = 9;           

            int[] numbers = new int[10];
            numbers[minIndex] = 1;
            numbers[maxIndex] = 10;

            Console.WriteLine($"{numbers[0]},{numbers[1]},{numbers[9]}");
        }
    }
}
