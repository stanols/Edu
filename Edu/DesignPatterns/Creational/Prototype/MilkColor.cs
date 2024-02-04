namespace Edu.DesignPatterns.Creational.Prototype
{
	public class WhiteColor : BaseColor
	{
		public WhiteColor(
			int red,
			int green,
			int blue,
			Texture texture)
			: base(red, green, blue, texture)
		{
		}

		public override BaseColor CloneDeep()
		{
			var color = base.Clone() as WhiteColor;

			color.Texture = new Texture
			{
				Name = this.Texture.Name,
				Type = this.Texture.Type
			};

			return color;
		}
	}
}
