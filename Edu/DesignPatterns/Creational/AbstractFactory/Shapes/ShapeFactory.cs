using Edu.DesignPatterns.Creational.AbstractFactory.Shapes.Interfaces;

namespace Edu.DesignPatterns.Creational.AbstractFactory.Shapes
{
    public class ShapeFactory : IShapeFactory
    {
        public ICircle CreateCircle()
        {
            return new Circle();
        }

        public IRectangle CreateRectangle()
        {
            return new Rectangle();
        }

        public ITriangle CreateTriangle()
        {
            return new Triangle();
        }
    }
}
