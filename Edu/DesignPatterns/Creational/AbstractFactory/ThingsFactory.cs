using Edu.DesignPatterns.Creational.AbstractFactory.Interfaces;
using Edu.DesignPatterns.Creational.AbstractFactory.Shapes;
using Edu.DesignPatterns.Creational.AbstractFactory.Shapes.Interfaces;
using Edu.DesignPatterns.Creational.AbstractFactory.Vehicles;
using Edu.DesignPatterns.Creational.AbstractFactory.Vehicles.Interfaces;

namespace Edu.DesignPatterns.Creational.AbstractFactory
{
	public class ThingsFactory : IFactory
	{
		private string _name;

		public string Name { get { return _name; } }

		public ThingsFactory(string name)
		{
			_name = name;
		}

		public ICar CreateCar()
		{
			return new Car();
		}

		public IBike CreateBike()
		{
			return new Bike();
		}

		public ICircle CreateCircle()
		{
			return new Circle();
		}

		public IRectangle CreateRectangle()
		{
			return new Rectangle();
		}

		public ITriangle CreateTriangle()
		{
			return new Triangle();
		}
	}
}
