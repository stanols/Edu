using System;

namespace Edu.DesignPatterns.Creational.Prototype
{
	public static class Prototype
	{
		public static void Execute()
		{
			var manager = new ColorManager();

			var natureTexture = new Texture
			{
				Name = nameof(TextureType.Smooth),
				Type = TextureType.Smooth
			};
			var dairyTexture = new Texture
			{
				Name = nameof(TextureType.Soft),
				Type = TextureType.Soft
			};

			manager["grass"] = new GreenColor(0, 255, 0, natureTexture);
			var grassShallowCopy = manager["grass"].CloneDeep();
			manager["tree"] = grassShallowCopy;
			
			manager["milk"] = new WhiteColor(0, 255, 0, dairyTexture);
			var milkDeepCopy = manager["milk"].Clone() as WhiteColor;
			manager["kefir"] = milkDeepCopy;

			Console.WriteLine($"Tree deep clone color: {manager["tree"]}");
			Console.WriteLine($"Are references equal: {manager["grass"].Texture == manager["tree"].Texture}");

			Console.WriteLine($"Kefir shallow clone color: {manager["kefir"]}");
			Console.WriteLine($"Are references equal: {manager["milk"].Texture == manager["kefir"].Texture}");

			Console.WriteLine();
		}
	}
}
