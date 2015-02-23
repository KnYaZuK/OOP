using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratory_Work_1
{
	public class Furnace
	{
		bool enabled;
		public bool Enabled
		{
			get { return enabled; }
			set { enabled = value; }
		}

		bool opened;
		public bool Opened
		{
			get { return opened; }
			set { opened = value; }
		}

		byte power;
		public byte Power
		{
			get { return power; }
			set { power = value; }
		}

		bool have_inside;
		public bool Have_inside
		{
			get { return have_inside; }
			set { have_inside = value; }
		}

		byte[] temperature = new byte[4] { 0, 150, 200, 250 };

		public Furnace()
		{
			Enabled = false;
			Opened = false;
			Have_inside = false;
			Power = temperature[0];
		}

		public void Open()
		{
			Opened = true;
		}

		public void Close()
		{
			Opened = false;
		}

		public void Set_Power(byte a)
		{
			switch (a)
			{
				case 0:
					Power = temperature[0];
					Enabled = false;
					break;
				case 1:
					Power = temperature[1];
					Enabled = true;
					break;
				case 2:
					Power = temperature[2];
					Enabled = true;
					break;
				case 3:
					Power = temperature[3];
					Enabled = true;
					break;
				default:
					Power = 0;
					Enabled = false;
					break;
			}
		}
	}
}
