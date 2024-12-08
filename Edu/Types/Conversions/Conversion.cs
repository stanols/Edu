using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Edu.Types.Conversions
{
	public static class Conversion
	{
		public static void PrintConvertedValueTypes()
		{
			var number = "10";
			var flag = false;
			var symbol = "n";
			var timestamp = "2020-01-01T00:00:00";
			var enumString = "Apple";

			var intNumber = Convert.ToInt32(number);
			var decimalNumber = Convert.ToDecimal(number);
			var doubleNumber = Convert.ToDouble(number);
			var boolFlag = Convert.ToBoolean(flag);
			var charSymbol = Convert.ToChar(symbol);
			var dateTime = Convert.ToDateTime(timestamp);
			var enumValue = Enum.Parse(typeof(Fruits), enumString);

			Console.WriteLine($"{intNumber.GetType()}: {intNumber}");
			Console.WriteLine($"{decimalNumber.GetType()}: {decimalNumber}");
			Console.WriteLine($"{doubleNumber.GetType()}: {doubleNumber}");
			Console.WriteLine($"{boolFlag.GetType()}: {boolFlag}");
			Console.WriteLine($"{charSymbol.GetType()}: {charSymbol}");
			Console.WriteLine($"{dateTime.GetType()}: {dateTime}");
			Console.WriteLine($"{enumValue.GetType()}: {enumValue}");
		}

		///byte -> short -> int -> long -> decimal
		///int -> double
		///short -> float -> double
		///char -> int 
		public static void PrintCastingResults()
		{
			//narrowing
			ushort ushortValue = 4; //000000000000100
			byte byteValue = (byte)ushortValue; //0000100

			Console.WriteLine($"ushort to byte: {byteValue}");

			//widening
			byte newByteValue = 4; //0000100
			ushort newUshortValue = newByteValue; //000000000000100

			Console.WriteLine($"byte to ushort: {newUshortValue}");

			//checking overflow
			try
			{
				int firstValue = 33;
				int secondValue = 600;

				//throws exception if overflow happens
				byte resultValue = checked((byte)(firstValue + secondValue));

				Console.WriteLine($"{resultValue}");
			}
			catch (OverflowException ex)
			{
				Console.WriteLine($"Overflowexception catch: {ex.Message}");
			}
		}
	}

	public enum Fruits
	{
		Apple,
		Orange,
		Cucumber,
		Banana
	}
}
