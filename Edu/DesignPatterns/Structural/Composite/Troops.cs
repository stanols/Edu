using System;

namespace Edu.DesignPatterns.Structural.Composite
{
	public abstract class Troops
	{
		public Troops()
		{
		}

		public virtual void Add(Troops troops)
		{
			throw new NotImplementedException();
		}

		public virtual void Remove(Troops troops)
		{
			throw new NotImplementedException();
		}

		public abstract int GetPower();

		public virtual bool IsComposite()
		{
			return true;
		}
	}
}
