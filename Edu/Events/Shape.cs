using System;

namespace Edu.Events
{
	public abstract class Shape
	{
		protected double _area;

		public double Area
		{
			get { return _area; }
			set { _area = value; }
		}

		public event EventHandler<ShapeEventArgs> ShapeChanged;

		public Shape()
		{
		}

		public abstract void PrintArea();

		protected virtual void OnShapeChanged(ShapeEventArgs eventArgs)
		{
			ShapeChanged?.Invoke(this, eventArgs);
		}
	}
}
