using System;

namespace Edu.DesignPatterns.Structural.Facade
{
	public class ElectricalSubSystem
	{
		public void Charge()
		{
			Console.WriteLine("Charging...");
		}

		public void PowerUp()
		{
			Console.WriteLine("Power is on...");
		}

		public void PowerDown()
		{
			Console.WriteLine("Power is off...");
		}
	}
}
