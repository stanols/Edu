using System;

namespace Edu.DesignPatterns.Structural.Proxy
{
	public class Image : IImage
	{
		private string _fileName;

		public Image(string fileName)
		{
			_fileName = fileName;
		}

		public void Display()
		{
			Console.WriteLine($"I'm image with the following file name: {_fileName}");
		}
	}
}
