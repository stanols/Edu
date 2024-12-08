namespace Edu.DesignPatterns.Creational.AbstractFactory.Shapes.Interfaces
{
	public interface IShapeFactory
	{
		ICircle CreateCircle();

		IRectangle CreateRectangle();

		ITriangle CreateTriangle();
	}
}
