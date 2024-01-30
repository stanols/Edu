using System;

namespace Edu.DesignPatterns.Creational.FactoryMethod
{
	public static class FactoryMethod
	{
		public static void Execute()
		{
			var electricProductFactory = new ElectricProductFactory();
			var electricProductPrice = CalculatePrice(electricProductFactory);

			Console.WriteLine($"Electric product price: {electricProductPrice}");

			var nonElectricProductFactory = new NonElectricProductFactory();
			var nonElectricPrice = CalculatePrice(nonElectricProductFactory);

			Console.WriteLine($"Non-Electric product price: {nonElectricPrice}");
		}

		public static decimal CalculatePrice(ProductFactory factory)
		{
			const decimal usdRate = 1.4M;
			return factory.GetPriceInUSD(usdRate);
		}
	}
}
