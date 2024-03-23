using System;

namespace Edu.DesignPatterns.Structural.Composite
{
	public class Soldier : Troops
	{
		public override int GetPower()
		{
			Console.WriteLine("I am soldier.");
			return 1;
		}

		public override bool IsComposite()
		{
			return false;
		}
	}
}
