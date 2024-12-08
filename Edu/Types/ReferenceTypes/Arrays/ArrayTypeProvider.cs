using System;
using System.Collections;
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

			Console.WriteLine("Rank = 1, DimentionLength = 5, ArrayLength = 4");

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

			Console.WriteLine("Array with rank > 1:");

			var rankedArray = new int[,]
			{
				{ 1, 2, 3, 4, 5 },
				{ 5, 4, 3, 2, 1 },
				{ 1, 2, 3, 4, 5 }
			};

			Console.WriteLine("Array of arrays:");

			var arrayOfItems = new int[][]
			{
				new int[5]{ 1, 2, 3, 4, 5 },
				new int[4]{ 5, 4, 3, 2 },
				new int[3]{ 1, 2, 3 },
				new int[2]{ 2, 1 },
				new int[1]{ 1 }
			};

			foreach (var items in arrayOfItems)
			{
				foreach (var item in items)
				{
					Console.WriteLine($"int[{Array.IndexOf(arrayOfItems, items)}][{Array.IndexOf(items, item)}]");
				}
			}

			var numbersToProcess = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
			var invertedArray = InvertNumbers(numbersToProcess);
			var evenArray = GetOddNumbers(invertedArray);
			var filteredArray = ExcludeNumbers(evenArray, new int[] { 7, 9, 5 });

			Console.WriteLine($"Even inverted array filtered by another array: {string.Join(",", filteredArray)}");

			var unorderedArray = new int[] { 2, 1, 5, 9, 4, 7, 3, 6, 8 };

			Console.WriteLine($"Not sorted array: {string.Join(",", unorderedArray)}");

			var sortedArray = SortNumbers(unorderedArray);

			Console.WriteLine($"Sorted array: {string.Join(",", sortedArray)}");
		}

		private static int[] InvertNumbers(int[] numbers)
		{
			var middleItemIndex = numbers.Length / 2;

			int tempItem;
			for (var index = 0; index < middleItemIndex; index++)
			{
				tempItem = numbers[index];
				numbers[index] = numbers[numbers.Length - index - 1];
				numbers[numbers.Length - index - 1] = tempItem;
			}

			//or use numbers.Reverse<int>();

			return numbers;
		}

		private static int[] GetOddNumbers(int[] numbers)
		{
			return numbers.Where(number => number % 2 != 0).ToArray();
		}

		private static int[] ExcludeNumbers(int[] numbers, int[] excludeNumbers)
		{
			return Array.FindAll(numbers, x => !excludeNumbers.Contains(x));
		}

		private static int[] SortNumbers(int[] numbers)
		{
			int temp;
			for (var i = 0; i < numbers.Length - 1; i++)
			{
				for (var j = i + 1; j < numbers.Length; j++)
				{
					if (numbers[i] > numbers[j])
					{
						temp = numbers[i];
						numbers[i] = numbers[j];
						numbers[j] = temp;
					}
				}
			}

			return numbers;
		}
	}
}
