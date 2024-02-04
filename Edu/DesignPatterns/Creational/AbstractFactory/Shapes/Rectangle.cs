using Edu.DesignPatterns.Creational.AbstractFactory.Shapes.Interfaces;

namespace Edu.DesignPatterns.Creational.AbstractFactory.Shapes
{
	public class Rectangle : IRectangle
	{
		public string Draw()
		{
			return $"I am {nameof(Rectangle)}!";
		}
	}
}
