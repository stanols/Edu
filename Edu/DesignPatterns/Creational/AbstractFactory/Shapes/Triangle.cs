using Edu.DesignPatterns.Creational.AbstractFactory.Shapes.Interfaces;

namespace Edu.DesignPatterns.Creational.AbstractFactory.Shapes
{
	public class Triangle : ITriangle
	{
		public string Draw()
		{
			return $"I am {nameof(Triangle)}!";
		}
	}
}
