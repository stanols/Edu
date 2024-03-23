using Edu.DesignPatterns.Structural.Bridge.Interfaces;

namespace Edu.DesignPatterns.Structural.Bridge
{
	public class Vehicle : IVehicle
	{
		protected IVehicle _vehicle;

		public Vehicle(IVehicle vehicle)
		{
			_vehicle = vehicle;
		}

		public virtual void Start()
		{
			_vehicle.Start();
		}
	}
}
