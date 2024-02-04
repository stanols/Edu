using System.Collections.Generic;

namespace Edu.DesignPatterns.Creational.Prototype
{
	public class ColorManager
	{
		private Dictionary<string, BaseColor> _colors =
			new Dictionary<string, BaseColor>();

		public BaseColor this[string key]
		{
			get { return _colors[key]; }
			set {
				if (!_colors.ContainsKey(key))
				{
					_colors.Add(key, value);
				}
			}
		}
	}
}
