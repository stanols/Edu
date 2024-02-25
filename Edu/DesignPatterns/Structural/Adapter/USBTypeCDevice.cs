using Edu.DesignPatterns.Structural.Adapter.Interfaces;

namespace Edu.DesignPatterns.Structural.Adapter
{
	public class USBTypeCDevice : IUSBTypeCDevice
	{
		private readonly IUSBTypeADevice _usbTypeADevice;

		public USBTypeCDevice(IUSBTypeADevice usbTypeADevice)
		{
			_usbTypeADevice = usbTypeADevice;
		}

		public void Transfer(int data)
		{
			_usbTypeADevice.TransferData($"{data}");
		}
	}
}
