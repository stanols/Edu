using Edu.DesignPatterns.Creational.AbstractFactory.Vehicles.Interfaces;

namespace Edu.DesignPatterns.Creational.AbstractFactory.Vehicles
{
	public class VehicleFactory : IVehicleFactory
	{
		public ICar CreateCar()
		{
			return new Car();
		}

		public IBike CreateBike()
		{
			return new Bike();
		}
	}
}
