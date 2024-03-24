using System;

namespace Edu.DesignPatterns.Structural.Facade
{
	public class FuelSubSystem
	{
		public void Pressurize()
		{
			Console.WriteLine("Pressure 100%.");
		}

		public void Refuel()
		{
			Console.WriteLine("Refueling...");
		}
	}
}
