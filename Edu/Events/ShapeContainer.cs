using System.Collections.Generic;

namespace Edu.Events
{
	public class ShapeContainer
	{
		private readonly List<Shape> _shapes;

		public ShapeContainer()
		{
			_shapes = new List<Shape>();
		}

		public void Add(Shape shape)
		{
			shape.ShapeChanged += HandleShapeChanged;

			_shapes.Add(shape);
		}

		public void Remove(Shape shape)
		{
			shape.ShapeChanged -= HandleShapeChanged;

			_shapes.Remove(shape);
		}

		private void HandleShapeChanged(object sender, ShapeEventArgs eventArgs)
		{
			if (sender is Shape shape)
			{
				shape.PrintArea();
			}
		}
	}
}
