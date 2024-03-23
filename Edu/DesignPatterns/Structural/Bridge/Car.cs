using Edu.DesignPatterns.Structural.Bridge.Interfaces;

namespace Edu.DesignPatterns.Structural.Bridge
{
	public class Car : Vehicle
	{
		public Car(IVehicle vehicle) : base(vehicle)
		{
		}

		public override void Start()
		{
			base._vehicle.Start();
		}
	}
}
