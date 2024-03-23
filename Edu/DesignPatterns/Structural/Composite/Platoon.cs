using System.Collections.Generic;

namespace Edu.DesignPatterns.Structural.Composite
{
	public class Platoon : Troops
	{
		protected List<Troops> _troops = new List<Troops>();

		public Platoon()
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

			foreach (var item in _troops)
			{
				power += item.GetPower();
			}

			return power;
		}

		public List<Troops> GetSoldiers(params Troops[] troops)
		{
			var soldiers = new List<Troops>();

            foreach (var item in troops)
            {
				if (!item.IsComposite())
				{
					soldiers.Add(item);
				}
            }

			return soldiers;
		}
	}
}
