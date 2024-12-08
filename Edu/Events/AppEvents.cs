namespace Edu.Events
{
	public static class AppEvents
	{
		private static readonly ShapeContainer _container;

		static AppEvents()
		{
			_container = new ShapeContainer();
		}

		public static void PrintResults()
		{
			var circle = new Circle(2);
			_container.Add(circle);
			circle.PrintArea();

			var rectangle = new Rectangle(2, 2);
			_container.Add(rectangle);
			rectangle.PrintArea();

			circle.Update(10);
			rectangle.Update(10, 10);

			_container.Remove(circle);

			circle.Update(11);
			rectangle.Update(11, 11);
		}
	}
}
