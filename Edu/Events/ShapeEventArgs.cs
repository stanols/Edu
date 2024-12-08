using System;

namespace Edu.Events
{
	public class ShapeEventArgs : EventArgs
	{
		private double _newArea;

		public double NewArea
		{
			get { return _newArea; }
			private set { _newArea = value; }
		}

		public ShapeEventArgs(double newArea) : base()
		{
			NewArea = newArea;
		}
	}
}
