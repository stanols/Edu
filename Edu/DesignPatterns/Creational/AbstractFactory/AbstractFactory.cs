using System;
using Edu.DesignPatterns.Creational.AbstractFactory.Interfaces;

namespace Edu.DesignPatterns.Creational.AbstractFactory
{
	public static class AbstractFactory
	{
		public static void PrintAbstractFactoryResults()
		{
			var thingsFactory = new ThingsFactory("Things");
			var productsFactory = new ProductsFactory("Products");

			Produce(thingsFactory);
			Produce(productsFactory);
		}

		private static void Produce(IFactory factory)
		{
			var circle = factory.CreateCircle();
			var rectangle = factory.CreateRectangle();
			var triangle = factory.CreateTriangle();

			var car = factory.CreateCar();
			var bike = factory.CreateBike();

			Console.WriteLine($"Production of {factory.Name}:");

			Console.WriteLine($"{circle}, {circle.Draw()};");
			Console.WriteLine($"{rectangle}, {rectangle.Draw()};");
			Console.WriteLine($"{triangle}, {triangle.Draw()};");

			Console.WriteLine($"{car}, {car.Drive()};");
			Console.WriteLine($"{bike}, {bike.Drive()}.");

			Console.WriteLine();
		}
	}
}
