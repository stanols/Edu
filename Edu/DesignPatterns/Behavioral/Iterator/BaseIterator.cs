using System.Collections;

namespace Edu.DesignPatterns.Behavioral.Iterator
{
	public abstract class BaseIterator : IEnumerator
	{
		object IEnumerator.Current => Current();

		public abstract int Key();

		public abstract object Current();

		public abstract bool MoveNext();

		public abstract void Reset();
	}
}
