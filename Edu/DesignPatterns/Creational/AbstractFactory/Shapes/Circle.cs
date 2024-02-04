using Edu.DesignPatterns.Creational.AbstractFactory.Shapes.Interfaces;

namespace Edu.DesignPatterns.Creational.AbstractFactory.Shapes
{
	public class Circle : ICircle
	{
		public string Draw()
		{
			return $"I am {nameof(Circle)}!";
		}
	}
}
