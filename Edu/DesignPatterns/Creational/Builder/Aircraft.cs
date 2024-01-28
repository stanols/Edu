using System.Collections.Generic;
using Edu.DesignPatterns.Creational.Builder.Interfaces;
using Edu.DesignPatterns.Creational.Builder.Parts;

namespace Edu.DesignPatterns.Creational.Builder
{
	public class Aircraft : IAircraft
	{
		private Fuselage _fuselage;
		private List<Wing> _wings = new List<Wing>();
		private List<Stabilizer> _stabilizers = new List<Stabilizer>();
		private Cockpit _cockpit;

		public void AddFuselage(Fuselage fuselage)
		{
			_fuselage = fuselage;
		}

		public void AddWing(Wing wing)
		{
			_wings.Add(wing);
		}

		public void AddStabilizer(Stabilizer stabilizer)
		{
			_stabilizers.Add(stabilizer);
		}

		public void AddCockpit(Cockpit cockpit)
		{
			_cockpit = cockpit;
		}

		public string Fly()
		{
			return $"I am {nameof(Aircraft)}!";
		}
	}
}
