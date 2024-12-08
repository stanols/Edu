using System;

namespace Edu.GarbageCollector
{
	public static class GarbageCollector
	{
		public static void PrintResults()
		{
			using var connection = new Connection();

			connection.CreateFile();
			var customHashCode = connection.GetCustomHashCode();			

			GC.Collect();

			Console.WriteLine($@"Maximum generations: {GC.MaxGeneration}");
		}
	}
}
