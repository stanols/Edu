using Edu.DesignPatterns.Creational.FactoryMethod.Interfaces;

namespace Edu.DesignPatterns.Creational.FactoryMethod
{
	public class NonElectricProductFactory : ProductFactory
	{
		public override IProduct CreateProduct()
		{
			return new Mirror();
		}
	}
}
