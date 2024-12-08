using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Edu.Types.ReferenceTypes.Objects
{
	public static class ObjectTypeProvider
	{
		public static void PrintObjectTypeResults()
		{
			var objectInstance = new Object();

			Console.WriteLine($"object: {objectInstance.ToString()}");
		}
	}
}
