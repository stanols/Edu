using System;

namespace Edu.DesignPatterns.Structural.Facade
{
	public class CoolingSubSystem
	{
		public void Pressurize()
		{
			Console.WriteLine("Pressure 100%.");
		}

		public void StartFan()
		{
			Console.WriteLine("Fan has started...");
		}

		public void StopFan()
		{
			Console.WriteLine("Fan has stopped...");
		}
	}
}
