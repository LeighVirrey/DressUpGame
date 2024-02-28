namespace DressUpGame.Models
{
	public class Clothing
	{
		public enum Type{
			HAT,
			HAIR,
			SHRIT,
			PANTS,
			SHOES
		}

		public Type type { get; set; }

		public string Name { get; set; }
		public string Image {  get; set; }

		public Clothing() { }

		public Clothing(Type type, string name, string image)
		{
			this.type = type;
			this.Name = name;
			this.Image = image;
		}
	}
}
