namespace DressUpGame.Models
{
	public class Character
	{
		public string Image { get; set; }

		public string Name { get; set; }

		public Clothing? Hat { get; set; }
		public Clothing? Hair { get; set; }
		public Clothing? Shirt { get; set; }
		public Clothing? Shoes { get; set; }
		public Clothing Pants { get; set; }

		public Character()
		{

		}

		public Character(string image, string name, Clothing? hat, Clothing? hair, Clothing? shirt, Clothing? shoes, Clothing pants)
		{
			this.Image = image;
			this.Name = name;
			this.Hat = hat;
			this.Hair = hair;
			this.Shirt = shirt;
			this.Shoes = shoes;
			this.Pants = pants;
		}
	}
}
