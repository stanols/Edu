using System;

namespace Edu.DesignPatterns.Creational.Builder
{
	public static class Builder
	{
		public static void PrintBuilderResults()
		{
			var aircraftBuilder = new AircraftBuilder();

			var aircraft = aircraftBuilder
				.BuildFuselage()
				.BuildWings()
				.BuildStabilazers()
				.BuildCockpit()
				.Build();

			Console.WriteLine($"{aircraft.Fly()}");
		}
	}
}
