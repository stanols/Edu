using System;

namespace Edu.DesignPatterns.Creational.Prototype
{
	public abstract class BaseColor : ICloneable
	{
		public int Red { get; private set; }
		public int Green { get; private set; }
		public int Blue { get; private set; }
		public Texture Texture { get; protected set; }

		public BaseColor(
			int red,
			int green,
			int blue,
			Texture texture)
		{
			Red = red;
			Green = green;
			Blue = blue;
			Texture = texture;
		}

		public abstract BaseColor CloneDeep();

		public virtual object Clone()
		{
			return MemberwiseClone();
		}

		public override string ToString()
		{
			return $"rgb({Red}, {Green}, {Blue}) - {Texture.Name}:{Texture.Type}";
		}
	}
}
