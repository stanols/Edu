using Edu.DesignPatterns.Creational.FactoryMethod.Interfaces;

namespace Edu.DesignPatterns.Creational.FactoryMethod
{
	public abstract class ProductFactory
	{
		public abstract IProduct CreateProduct();

		public decimal GetPriceInUSD(decimal usdRate)
		{
			var product = CreateProduct();
			var price = product.GetPrice();

			return price * usdRate;
		}
	}
}
