using Edu.DesignPatterns.Creational.AbstractFactory.Vehicles.Interfaces;

namespace Edu.DesignPatterns.Creational.AbstractFactory.Vehicles
{
	public class Limousine : ICar
	{
		public string Drive()
		{
			return $"I am {nameof(Limousine)}!";
		}
	}
}
