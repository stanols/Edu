using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Edu.Types.Operations
{
	public static class Operation
	{
		public static void PrintValueTypeOperations()
		{
			var a = 10;
			var b = 3;
			var x = 1;
			var y = 2;
			var z = 3;

			var c = a / b;
			double d = 10 / 3; //literals are converted to int
			var e = (double)a / b;
			var f = 10.0 / 3;
			var g = 10.0 % 3;
			var h = x++;
			var i = ++x;
			var j = y--;
			var k = --y;

			Console.WriteLine($"с: {c}");
			Console.WriteLine($"d: {d}");
			Console.WriteLine($"e: {e}");
			Console.WriteLine($"f: {f}");
			Console.WriteLine($"g: {g}");
			Console.WriteLine($"h: {h}");
			Console.WriteLine($"i: {i}");
			Console.WriteLine($"j: {j}");
			Console.WriteLine($"k: {k}");


			//Priority
			a = 2;
			b = 3;
			c = 5;

			var resultWithBrackets = ((a++) * 2) + ((b--) / 2) - (c % 2);

			a = 2;
			b = 3;
			c = 5;
			var resultWithoutBrackets = a++ * 2 + b-- / 2 - c % 2;

			Console.WriteLine($"resultWithBrackets: {resultWithBrackets}");
			Console.WriteLine($"resultWithoutBrackets: {resultWithoutBrackets}");

			x = 2;//010
			y = 5;//101
			var andResult = x & y;

			x = 2;//010
			y = 5;//101
			var orResult = x | y;


			x = 2;//010
			y = 5;//101
			var xorResult = x ^ y;

			x = 2;
			var notResult = ~x;

			x = 2;
			var lefthShiftResult = x << 2;

			x = 2;
			var rightShiftResult = x >> 2;

			Console.WriteLine($"andResult: {andResult}");
			Console.WriteLine($"orResult: {orResult}");
			Console.WriteLine($"xorResult: {xorResult}");
			Console.WriteLine($"notResult: {notResult}");
			Console.WriteLine($"lefthShiftResult: {lefthShiftResult}");
			Console.WriteLine($"rightShiftResult: {rightShiftResult}");

			Console.WriteLine($"simple:");
			x = 6;

			x -= 1;
			Console.WriteLine($"x -= 1: {x}");
			x += 1;
			Console.WriteLine($"x += 1: {x}");
			x *= 2;
			Console.WriteLine($"x *= 2: {x}");
			x /= 10;
			Console.WriteLine($"x /= 10: {x}");
			x %= 5;
			Console.WriteLine($"x %= 5: {x}");


			Console.WriteLine($"hard:");
			x = 6;//0110

			x &= 9;//0110 & 1001 -> 0000 -> 0
			Console.WriteLine($"x &= 1: {x}");
			x |= 15;//1111 -> 15
			Console.WriteLine($"x |= 1: {x}");
			x ^= 1;//1111 -> 1110 -> 14
			Console.WriteLine($"x ^= 1: {x}");
			x <<= 1;//1110 -> 0001 1100 -> 28
			Console.WriteLine($"x <<= 1: {x}");
			x >>= 1;//0001 1100 -> 1110 -> 14
			Console.WriteLine($"x >>= 1: {x}");
		}

		public static void PrintComparisonOperationResults()
		{
			int a = 10;
			int b = 4;

			bool c = a == b;

			Console.WriteLine($"Equal: {a == b}");
			Console.WriteLine($"Not Equal: {a != b}");
			Console.WriteLine($"Less: {a < b}");
			Console.WriteLine($"Greater: {a > b}");
			Console.WriteLine($"LessOrEqual: {a <= b}");
			Console.WriteLine($"GreaterOrEqual: {a >= b}");
			Console.WriteLine($"And: {true && true}");
			Console.WriteLine($"Or: {true || false}");
			Console.WriteLine($"Not: {!true}");
		}
	}
}
