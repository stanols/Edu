using System;

namespace Edu.Types.Condition
{
	public static class Condition
	{
		public static void PrintConditions()
		{
			const int adultAge = 18;
			var age = 28;
			var isAdult = false;

			if (age > adultAge)
			{
				isAdult = true;
			}

			Console.WriteLine($"isAdult: {isAdult}");

			isAdult = false;
			age = 15;

			if (age >= adultAge)
			{
				isAdult = true;
			}
			else
			{
				isAdult = false;
			}

			Console.WriteLine($"isAdult: {isAdult}");

			isAdult = true;
			age = 90;

			if (age <= adultAge)
			{
				isAdult = false;
			}
			else if (age == adultAge)
			{
				isAdult = true;
			}
			else
			{
				isAdult = true;
			}

			Console.WriteLine($"isAdult: {isAdult}");

			var fruit = "apple";

			switch (fruit)
			{
				case "orange":
					Console.WriteLine("It's orange!");
					break;
				case "apple":
					Console.WriteLine("It's apple!");
					break;
				case "banana":
					Console.WriteLine("It's banana!");
					break;
				default:
					Console.WriteLine("It's orange!");
					break;
			}

			var isApple = fruit == "apple" ? true : false;

			Console.WriteLine($"Is {fruit} an apple?");
			Console.WriteLine($"Answer: {isApple}");

			var sex = "man";
			var canGiveBirth = sex switch
			{
				"man" => false,
				"woman" => true,
				_ => default
			};

			Console.WriteLine(@$" - Can {sex} give a birth?");
			Console.WriteLine(@$" - Answer: {canGiveBirth}");
		}
	}
}
