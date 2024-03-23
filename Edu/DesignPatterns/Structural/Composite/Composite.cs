using System;

namespace Edu.DesignPatterns.Structural.Composite
{
	public static class Composite
	{
		public static void Execute()
		{
			var platoon = new Platoon();

			var sniper = new Soldier();
			var sergeant = new Soldier();
			var staffSergeant = new Soldier();

			var squad = new Squad();
			squad.Add(sniper);
			squad.Add(sergeant);

			platoon.Add(squad);
			platoon.Add(staffSergeant);

			var totalPower = platoon.GetPower();
			Console.WriteLine($"Total Power: {totalPower}");

			var additionalTroops = new Troops[]
			{
				new Squad(),
				new Soldier(),
				new Squad(),
				new Soldier(),
				new Soldier()
			};
			platoon.GetSoldiers(additionalTroops);
		}
	}
}
