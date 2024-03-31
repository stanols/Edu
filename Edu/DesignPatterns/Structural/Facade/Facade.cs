namespace Edu.DesignPatterns.Structural.Facade
{
	public static class Facade
	{
		public static void Execute()
		{
			var electricalSubSystem = new ElectricalSubSystem();
			var fuelSubSystem = new FuelSubSystem();
			var coolingSubSystem = new CoolingSubSystem();
			var vehicleSystem = new VehicleSystem(electricalSubSystem, fuelSubSystem, coolingSubSystem);

			RunSystem(vehicleSystem);
		}

		private static void RunSystem(VehicleSystem vehicleSystem)
		{
			vehicleSystem.Run();
		}
	}
}
