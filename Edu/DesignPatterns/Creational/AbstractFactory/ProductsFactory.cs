﻿using Edu.DesignPatterns.Creational.AbstractFactory.Interfaces;
using Edu.DesignPatterns.Creational.AbstractFactory.Shapes;
using Edu.DesignPatterns.Creational.AbstractFactory.Shapes.Interfaces;
using Edu.DesignPatterns.Creational.AbstractFactory.Vehicles;
using Edu.DesignPatterns.Creational.AbstractFactory.Vehicles.Interfaces;

namespace Edu.DesignPatterns.Creational.AbstractFactory
{
	public class ProductsFactory : IFactory
	{
		private string _name;

		public string Name { get { return _name; } }

		public ProductsFactory(string name)
		{
			this._name = name;
		}

		public ICar CreateCar()
		{
			return new Limousine();
		}

		public IBike CreateBike()
		{
			return new Tricycle();
		}

		public ICircle CreateCircle()
		{
			return new Circle();
		}

		public IRectangle CreateRectangle()
		{
			return new Square();
		}

		public ITriangle CreateTriangle()
		{
			return new Triangle();
		}
	}
}
