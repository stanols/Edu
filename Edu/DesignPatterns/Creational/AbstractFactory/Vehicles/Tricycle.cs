using Edu.DesignPatterns.Creational.AbstractFactory.Vehicles.Interfaces;

namespace Edu.DesignPatterns.Creational.AbstractFactory.Vehicles
{
	public class Tricycle : IBike
	{
		public string Drive()
		{
			return $"I am {nameof(Tricycle)}!";
		}
	}
}
