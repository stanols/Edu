namespace Edu.DesignPatterns.Creational.AbstractFactory.Vehicles.Interfaces
{
	public interface IVehicleFactory
	{
		ICar CreateCar();
		IBike CreateBike();
	}
}
