using System;

namespace Edu.DesignPatterns.Creational.Singleton
{
	public class Earth
	{
		private static readonly Lazy<Earth> _instance =
			new Lazy<Earth>(() => new Earth());

		public static Earth Instance
		{
			get
			{
				return _instance.Value;
			}
		}

		public static Earth GetEarth() => _instance.Value;

		private Earth()
		{
		}
	}
}
