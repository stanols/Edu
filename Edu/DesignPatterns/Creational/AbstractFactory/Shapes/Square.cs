using Edu.DesignPatterns.Creational.AbstractFactory.Shapes.Interfaces;

namespace Edu.DesignPatterns.Creational.AbstractFactory.Shapes
{
	public class Square : IRectangle
	{
		public string Draw()
		{
			return $"I am {nameof(Square)}!";
		}
	}
}
