using System.Collections;

namespace Edu.DesignPatterns.Behavioral.Iterator
{
	public abstract class IteratorAggregate : IEnumerable
	{
		public abstract IEnumerator GetEnumerator();
	}
}
