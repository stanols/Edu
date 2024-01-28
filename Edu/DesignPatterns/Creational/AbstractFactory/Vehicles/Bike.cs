using Edu.DesignPatterns.Creational.AbstractFactory.Vehicles.Interfaces;

namespace Edu.DesignPatterns.Creational.AbstractFactory.Vehicles
{
	public class Bike : IBike
	{
		public string Drive()
		{
			return $"I am {nameof(Bike)}!";
		}
	}
}
