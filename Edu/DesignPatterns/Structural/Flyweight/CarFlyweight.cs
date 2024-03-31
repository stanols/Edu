using System;
using Newtonsoft.Json;

namespace Edu.DesignPatterns.Structural.Flyweight
{
	public class CarFlyweight
	{
		private Car _sharedState;

		public CarFlyweight(Car car)
		{
			_sharedState = car;
		}

		public void Operation(Car uniqueState)
		{
			var sharedStateString = JsonConvert.SerializeObject(_sharedState);
			var uniqueStateString = JsonConvert.SerializeObject(uniqueState);

			Console.WriteLine($"Are states equal? Answer: {sharedStateString == uniqueStateString}");
			Console.WriteLine();
		}
	}
}
