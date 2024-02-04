using System;
using System.Threading.Tasks;

namespace Edu.DesignPatterns.Creational.Singleton
{
	public static class Singleton
	{
		public static void Execute()
		{
			var firstGovernment = Government.GetInstance();
			firstGovernment.PayTaxes(1000);

			var secondGovernment = Government.GetInstance();
			secondGovernment.PayTaxes(2000);

			Console.WriteLine($"firstGovernment taxes: {firstGovernment.Taxes}");
			Console.WriteLine($"secondGovernment taxes: {secondGovernment.Taxes}");
			Console.WriteLine($"Are Government references equal: {firstGovernment == secondGovernment}");
			Console.WriteLine();

			Passport firstPassport = null;
			Passport secondPassport = null;

			Parallel.Invoke(
				() =>
				{
					firstPassport = Passport.Instance;
				},
				() =>
				{
					secondPassport = Passport.GetInstance();
				});
			Console.WriteLine($"Are Passport references equal: {firstPassport == secondPassport}");
			Console.WriteLine($"Are Passport guids equal: {firstPassport.Validate(secondPassport.Guid)}");
			Console.WriteLine();

			Earth firstEarth = null;
			Earth secondEarth = null;

			Parallel.Invoke(
				() =>
				{
					firstEarth = Earth.Instance;
				},
				() =>
				{
					secondEarth = Earth.GetEarth();
				});
			Console.WriteLine($"Are Earth references equal: {firstEarth == secondEarth}");
			Console.WriteLine();
		}
	}
}
