﻿namespace DressUpGame.Models
{
	public class Clothing
	{
		//public enum Type{
		//	HAT,
		//	HAIR,
		//	SHIRT,
		//	PANTS,
		//	SHOES
		//}

		public string type { get; set; }

		public string Name { get; set; }
		public string Image {  get; set; }

		public Clothing() { }

		public Clothing(string type, string name, string image)
		{
			this.type = type;
			this.Name = name;
			this.Image = image;
		}
	}
}
