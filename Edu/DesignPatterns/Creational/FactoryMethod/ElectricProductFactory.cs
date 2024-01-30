using Edu.DesignPatterns.Creational.FactoryMethod.Interfaces;

namespace Edu.DesignPatterns.Creational.FactoryMethod
{
	public class ElectricProductFactory : ProductFactory
	{
		public override IProduct CreateProduct()
		{
			return new Dishwasher();
		}
	}
}
