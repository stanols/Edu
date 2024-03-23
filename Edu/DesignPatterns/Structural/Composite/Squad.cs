using System.Collections.Generic;

namespace Edu.DesignPatterns.Structural.Composite
{
	public class Squad : Troops
	{
		protected List<Troops> _troops = new List<Troops>();

		public Squad()
		{
		}

		public override void Add(Troops troops)
		{
			_troops.Add(troops);
		}

		public override void Remove(Troops troops)
		{
			_troops.Remove(troops);
		}

		public override int GetPower()
		{
			var power = 0;

			foreach (var troops in _troops)
			{
				power += troops.GetPower();
			}

			return power;
		}
	}
}
