using System;
using System.Collections.Generic;
using System.Linq;

namespace Edu.DesignPatterns.Structural.Flyweight
{
	public class CarFlyweightFactory
	{
		private List<Tuple<CarFlyweight, string>> _flyweights = new List<Tuple<CarFlyweight, string>>();

		public CarFlyweightFactory(params Car[] args)
		{
			foreach (var arg in args)
			{
				var carFlyweight = new CarFlyweight(arg);
				var key = GetKey(arg);

				var value = new Tuple<CarFlyweight, string>(carFlyweight, key);
				
				_flyweights.Add(value);
			}
		}

		public string GetKey(Car key)
		{
			List<string> elements = new List<string>
			{
				key.Model,
				key.Color,
				key.Company
			};

			if (key.Owner != null && key.Number != null)
			{
				elements.Add(key.Number);
				elements.Add(key.Owner);
			}

			elements.Sort();

			return string.Join("_", elements);
		}

		public CarFlyweight GetOrCreateCarFlyweight(Car sharedState)
		{
			var key = GetKey(sharedState);

			if (!_flyweights.Any(t => t.Item2 == key))
			{
				_flyweights.Add(new Tuple<CarFlyweight, string>(new CarFlyweight(sharedState), key));
			}

			return _flyweights
				.Where(t => t.Item2 == key)
				.First()
				.Item1;
		}

		public void ListCarFlyweights()
		{
			foreach (var flyweight in _flyweights)
			{
				Console.WriteLine(flyweight.Item2);
			}

			Console.WriteLine($"Total count: {_flyweights.Count}");
			Console.WriteLine();
		}
	}
}
