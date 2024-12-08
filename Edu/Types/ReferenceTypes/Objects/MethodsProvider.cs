using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Edu.Types.ReferenceTypes.Objects
{
	public static class MethodsProvider
	{
		public static IEnumerable<T> FilterItems<T>(this IEnumerable<T> items, Func<T, bool> predicate)
		{
			foreach (var item in items)
			{
				if (predicate(item))
				{
					yield return item;
				}
			}
		}

		public static void ExecutePublicStaticCode()
		{
		}

		internal static void ExecuteInternalStaticCode()
		{
		}

		private static void ExecutePrivateStaticCode()
		{
		}
	}
}
