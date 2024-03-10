using Edu.DesignPatterns.Structural.Bridge.Interfaces;
using System;

namespace Edu.DesignPatterns.Structural.Bridge
{
	public class Nissan : IVehicle
	{
		public Nissan()
		{
		}

		public void Start()
		{
			Console.WriteLine("Nissan: breem beem beem beem beem.");
		}
	}
}
