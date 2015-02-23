using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratory_Work_4
{
	enum weartype
	{
		outerwear,
		underwear
	}

	enum material
	{
		linen,
		cotton,
		silk,
		wool
	}

	enum size
	{
		XXS,
		XS,
		S,
		M,
		L,
		XL,
		XXL
	}

	enum color
	{
		black,
		white,
		red,
		green,
		blue
	}

	class Cloth
	{
		public weartype WearType { get; set; }
		public material Material { get; set; }
		public size Size { get; set; }
		public color Color { get; set; }

		public Cloth ()
		{
			WearType = weartype.outerwear;
			Material = material.silk;
			Size = size.L;
			Color = color.white;
		}

		public Cloth(weartype _WearType, material _Material, size _Size, color _Color)
		{
			WearType = _WearType;
			Material = _Material;
			Size = _Size;
			Color = _Color;
		}

		public override string ToString()
		{
			StringBuilder sb = new StringBuilder();

			sb.Append("Одежда.\n\nТип: ");
			sb.Append(WearType.ToString());
			sb.Append("\nМатериал: ");
			sb.Append(Material.ToString());
			sb.Append("\nРазмер: ");
			sb.Append(Size.ToString());
			sb.Append("\nЦвет: ");
			sb.Append(Color.ToString());

			return sb.ToString();
		}
	}
}
