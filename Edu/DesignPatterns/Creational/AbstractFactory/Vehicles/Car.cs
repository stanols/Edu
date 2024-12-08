using Edu.DesignPatterns.Creational.AbstractFactory.Vehicles.Interfaces;

namespace Edu.DesignPatterns.Creational.AbstractFactory.Vehicles
{
	public class Car : ICar
	{
		public string Drive()
		{
			return $"I am {nameof(Car)}!";
		}
	}
}
