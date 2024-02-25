namespace Edu.DesignPatterns.Structural.Adapter
{
	public static class Adapter
	{
		public static void Execute()
		{
			var usbTypeADevice = new USBTypeADevice();
			var usbTypeCDevice = new USBTypeCDevice(usbTypeADevice);

			var data = 100;
			usbTypeCDevice.Transfer(data);
		}
	}
}
