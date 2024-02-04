namespace Edu.DesignPatterns.Creational.Prototype
{
	public class GreenColor : BaseColor
	{
		public GreenColor(
			int red,
			int green,
			int blue,
			Texture texture)
			: base(red, green, blue, texture)
		{
		}

		public override BaseColor CloneDeep()
		{
			var color = base.Clone() as GreenColor;

			color.Texture = new Texture
			{
				Name = this.Texture.Name,
				Type = this.Texture.Type
			};

			return color;
		}
	}
}
