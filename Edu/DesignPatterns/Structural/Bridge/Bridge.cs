using Edu.DesignPatterns.Structural.Bridge.Interfaces;

namespace Edu.DesignPatterns.Structural.Bridge
{
	public static class Bridge
	{
		public static void Execute()
		{
			var dealer = new Dealer();

			var nissan = new Nissan();
			var vehicle = new Vehicle(nissan);
			dealer.TestDriveVehicle(vehicle);

			var ford = new Ford();
			var car = new Car(ford);
			dealer.TestDriveVehicle(car);
		}
	}
}
