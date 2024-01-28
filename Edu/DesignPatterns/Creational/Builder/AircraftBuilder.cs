using Edu.DesignPatterns.Creational.Builder.Interfaces;
using Edu.DesignPatterns.Creational.Builder.Parts;

namespace Edu.DesignPatterns.Creational.Builder
{
	public class AircraftBuilder : IAircraftBuilder
	{
		private Aircraft _aircraft;

		public AircraftBuilder()
		{
			Reset();
		}

		public void Reset()
		{
			_aircraft = new Aircraft();
		}

		public Aircraft Build()
		{
			var aircraft = _aircraft;

			Reset();

			return aircraft;
		}

		public AircraftBuilder BuildFuselage()
		{
			_aircraft.AddFuselage(new Fuselage());

			return this;
		}

		public AircraftBuilder BuildWings()
		{
			_aircraft.AddWing(new Wing());
			_aircraft.AddWing(new Wing());

			return this;
		}

		public AircraftBuilder BuildStabilazers()
		{
			_aircraft.AddStabilizer(new Stabilizer());
			_aircraft.AddStabilizer(new Stabilizer());
			_aircraft.AddStabilizer(new Stabilizer());

			return this;
		}

		public AircraftBuilder BuildCockpit()
		{
			_aircraft.AddCockpit(new Cockpit());

			return this;
		}
	}
}
