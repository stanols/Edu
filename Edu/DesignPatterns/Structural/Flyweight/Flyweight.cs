using System;

namespace Edu.DesignPatterns.Structural.Flyweight
{
	public static class Flyweight
	{
		public static void Execute()
		{
			var factory = new CarFlyweightFactory(
				new Car { Company = "Chevrolet", Model = "Camaro2018", Color = "pink" },
				new Car { Company = "Mercedes Benz", Model = "C300", Color = "black" },
				new Car { Company = "Mercedes Benz", Model = "C500", Color = "red" },
				new Car { Company = "BMW", Model = "M5", Color = "red" },
				new Car { Company = "BMW", Model = "X6", Color = "white" }
			);

			factory.ListCarFlyweights();

			AddCarToPoliceDatabase(factory, new Car
			{
				Number = "CL234IR",
				Owner = "James Doe",
				Company = "BMW",
				Model = "M5",
				Color = "red"
			});

			AddCarToPoliceDatabase(factory, new Car
			{
				Number = "CL234IR",
				Owner = "James Doe",
				Company = "BMW",
				Model = "X1",
				Color = "red"
			});

			factory.ListCarFlyweights();
		}

		public static void AddCarToPoliceDatabase(CarFlyweightFactory factory, Car car)
		{
			Console.WriteLine("Adding a car to database..");

			var flyweight = factory.GetOrCreateCarFlyweight(
				new Car
				{
					Color = car.Color,
					Model = car.Model,
					Company = car.Company
				});

			flyweight.Operation(car);
		}
	}
}
