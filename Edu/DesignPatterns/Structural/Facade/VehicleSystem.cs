using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Edu.DesignPatterns.Structural.Facade
{
	public class VehicleSystem
	{
		protected ElectricalSubSystem _electricalSubSystem;
		protected FuelSubSystem _fuelSubSystem;
		protected CoolingSubSystem _coolingSubSystem;

		public VehicleSystem(
			ElectricalSubSystem electricalSubSystem,
			FuelSubSystem fuelSubSystem,
			CoolingSubSystem coolingSubSystem)
		{
			_electricalSubSystem = electricalSubSystem;
			_fuelSubSystem = fuelSubSystem;
			_coolingSubSystem = coolingSubSystem;
		}

		public void Run()
		{
			_electricalSubSystem.Charge();
			_electricalSubSystem.PowerUp();
			_fuelSubSystem.Pressurize();
			_coolingSubSystem.Pressurize();
			_coolingSubSystem.StartFan();
		}
	}
}
