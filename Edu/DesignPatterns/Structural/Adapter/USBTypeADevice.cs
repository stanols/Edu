using Edu.DesignPatterns.Structural.Adapter.Interfaces;
using System;

namespace Edu.DesignPatterns.Structural.Adapter
{
	public class USBTypeADevice : IUSBTypeADevice
	{
		public void TransferData(string data)
		{
			Console.WriteLine($"Data {data} transfered!");
		}
	}
}
