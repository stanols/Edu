namespace Edu.DesignPatterns.Structural.Proxy
{
	public class ImageProxy: IImage
	{
		private IImage _image;
		private string _fileName;

		public ImageProxy(string fileName)
		{
			_fileName = fileName;
		}

		public void Display()
		{
			if (_image == null)
			{
				_image = new Image(_fileName);
			}

			_image.Display();
		}
	}
}
