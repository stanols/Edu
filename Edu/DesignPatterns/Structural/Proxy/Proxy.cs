using System;

namespace Edu.DesignPatterns.Structural.Proxy
{
	public static class Proxy
	{
		public static void Execute()
		{
			var firstImage = new Image("first_image.png");
			firstImage.Display();

			var secondImage = new ImageProxy("second_image.png");
			secondImage.Display();

			Console.WriteLine();
		}
	}
}
