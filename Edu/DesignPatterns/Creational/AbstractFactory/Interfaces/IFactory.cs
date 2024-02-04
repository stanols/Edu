using Edu.DesignPatterns.Creational.AbstractFactory.Shapes.Interfaces;
using Edu.DesignPatterns.Creational.AbstractFactory.Vehicles.Interfaces;

namespace Edu.DesignPatterns.Creational.AbstractFactory.Interfaces
{
	public interface IFactory : IShapeFactory, IVehicleFactory
	{
		public string Name { get; }
	}
}
