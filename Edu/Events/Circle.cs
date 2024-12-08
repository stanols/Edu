using System;

namespace Edu.Events
{
	public class Circle : Shape
	{
		private double _radius;

		public Circle(double radius)
		{
			Update(radius, true);
		}

		public void Update(double radius)
		{
			this.Update(radius, false);
		}

		public void Update(double radius, bool suppressShapeChangedEvent)
		{
			_radius = radius;
			_area = Math.PI * _radius * _radius;

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
			Console.WriteLine($@"Circle area is: {base.Area}");
		}
	}
}
