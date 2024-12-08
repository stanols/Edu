using System;

namespace Edu.Events
{
	public class Rectangle : Shape
	{
		private double _length;
		private double _width;

		public Rectangle(double length, double width)
		{
			Update(length, width, true);
		}

		public void Update(double length, double width)
		{
			Update(length, width, false);
		}

		public void Update(double length, double width, bool suppressShapeChangedEvent)
		{
			_length = length;
			_width = width;
			_area = _length * _width;

			if (!suppressShapeChangedEvent)
			{
				var shapeEventArgs = new ShapeEventArgs(_area);
				OnShapeChanged(shapeEventArgs);
			}
		}

		protected override void OnShapeChanged(ShapeEventArgs eventArgs)
		{
			base.OnShapeChanged(eventArgs);
		}

		public override void PrintArea()
		{
			Console.WriteLine(@$"Rectangle area is: {Area}");
		}
	}
}
