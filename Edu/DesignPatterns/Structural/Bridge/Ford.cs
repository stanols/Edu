using Edu.DesignPatterns.Structural.Bridge.Interfaces;
using System;

namespace Edu.DesignPatterns.Structural.Bridge
{
	public class Ford : IVehicle
	{
		public Ford()
		{
		}

		public void Start()
		{
			Console.WriteLine("Ford: Broom boom boom boom boom.");
		}
	}
}
