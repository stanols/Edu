using System;
using System.Collections.Generic;

namespace Edu.DesignPatterns.Behavioral.ChainOfResponsibility
{
	public static class ChainOfResponsibility
	{
		public static void Execute()
		{
			var monkey = new MonkeyHandler();
			var squirrel = new SquirrelHandler();
			var dog = new DogHandler();

			var foodItems = new List<string>
			{
				"Nut",
				"Banana",
				"Cup of coffee"
			};

			Console.WriteLine("Chain: Monkey > Squirrel > Dog.");
			monkey.SetNext(squirrel).SetNext(dog);
			Execute(monkey, foodItems);
			Console.WriteLine();

			Console.WriteLine("Subchain: Squirrel > Dog\n");
			Execute(squirrel, foodItems);
			Console.WriteLine();
		}

		public static void Execute(IHandler handler, List<string> foodItems)
		{
			foreach (var foodItem in foodItems)
			{
				Console.WriteLine($"Client: Who wants a {foodItem}?");

				var result = handler.Handle(foodItem);

				if (result == null)
				{
					Console.WriteLine($"{foodItem} was left untouched.");
					continue;
				}

				Console.WriteLine(result);
			}
		}
	}
}
