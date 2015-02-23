using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laboratory_Work_4
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		bool first_start = true;

		private void button1_Click(object sender, EventArgs e)
		{
			Cloth cloth;
			UnderWear underwear;

			if ( radioButton_Constructor1.Checked )
			{
				if ( checkBox_Pants.Checked )
				{
					underwear = new UnderWear();

					label1.Text = underwear.ToString();
				}
				else
				{
					cloth = new Cloth();

					label1.Text = cloth.ToString();
				}
			}
			else
			{
				

				if ( radioButton_Constructor2.Checked)
				{
					weartype weart;
					material mat;
					size sz;
					color col;

					if (radioButton_MaterialCotton.Checked)
					{
						mat = material.cotton;
					}
					else
					{
						if (radioButton_MaterialLinen.Checked)
						{
							mat = material.linen;
						}
						else
						{
							if (radioButton_MaterialSilk.Checked)
							{
								mat = material.silk;
							}
							else
							{
								if (radioButton_MaterialWool.Checked)
								{
									mat = material.wool;
								}
								else
								{
									MessageBox.Show("Материал не выбран!\nПожалуйста выберите один из материалов.");
									return;
								}
							}
						}
					}

					if (radioButton_SizeXXS.Checked)
					{
						sz = size.XXS;
					}
					else
					{
						if (radioButton_SizeXS.Checked)
						{
							sz = size.XS;
						}
						else
						{
							if (radioButton_SizeS.Checked)
							{
								sz = size.S;
							}
							else
							{
								if (radioButton_SizeM.Checked)
								{
									sz = size.M;
								}
								else
								{
									if (radioButton_SizeL.Checked)
									{
										sz = size.L;
									}
									else
									{
										if (radioButton_SizeXL.Checked)
										{
											sz = size.XL;
										}
										else
										{
											if (radioButton_SizeXXL.Checked)
											{
												sz = size.XXL;
											}
											else
											{
												MessageBox.Show("Размер не выбран!\nПожалуйста выберите один из размеров.");
												return;
											}
										}
									}
								}
							}
						}
					}

					if (radioButton_ColorBlack.Checked)
					{
						col = color.black;
					}
					else
					{
						if (radioButton_ColorBlue.Checked)
						{
							col = color.blue;
						}
						else
						{
							if (radioButton_ColorGreen.Checked)
							{
								col = color.green;
							}
							else
							{
								if (radioButton_ColorRed.Checked)
								{
									col = color.red;
								}
								else
								{
									if (radioButton_ColorWhite.Checked)
									{
										col = color.white;
									}
									else
									{
										MessageBox.Show("Цвет не выбран!\nПожалуйста выберите один из цветов.");
										return;
									}
								}
							}
						}
					}

					if ( checkBox_Pants.Checked )
					{
						bool haspock;
						bool hasbelt;

						
						if ( checkBox_PantsPockets.Checked )
						{
							haspock = true;
						}
						else
						{
							haspock = false;
						}

						if ( checkBox_PantsBelt.Checked)
						{
							hasbelt = true;
						}
						else
						{
							hasbelt = false;
						}

						underwear = new UnderWear(wearsubtype.pants, haspock, hasbelt, mat, sz, col);

						label1.Text = underwear.ToString();
					}
					else
					{
						if (radioButton_TypeOutWear.Checked)
						{
							weart = weartype.outerwear;
						}
						else
						{
							if (radioButton_TypeUnderWear.Checked)
							{
								weart = weartype.underwear;
							}
							else
							{
								MessageBox.Show("Тип не выбран!\nПожалуйста выберите один из типов.");
								return;
							}
						}

						cloth = new Cloth( weart, mat, sz, col);

						label1.Text = cloth.ToString();
					}
				}
			}
		}

		private void checkBox_Pants_CheckedChanged(object sender, EventArgs e)
		{
			if (checkBox_Pants.Checked )
			{
				if (!radioButton_Constructor1.Checked)
					groupBox_UnderWear.Enabled = true;
				groupBox_WearType.Enabled = false;
			}
			else
			{
				groupBox_UnderWear.Enabled = false;

				if ( !radioButton_Constructor1.Checked)
					groupBox_WearType.Enabled = true;
			}
		}

		private void radioButton_Constructor1_CheckedChanged(object sender, EventArgs e)
		{
			if ( radioButton_Constructor1.Checked )
			{
				groupBox_WearType.Enabled = false;
				groupBox_Material.Enabled = false;
				groupBox_Size.Enabled = false;
				groupBox_Color.Enabled = false;

				if ( first_start )
					checkBox_Pants.Enabled = true;

				
			}
		}

		private void radioButton_Constructor2_CheckedChanged(object sender, EventArgs e)
		{
			if (radioButton_Constructor2.Checked )
			{
				
				groupBox_Material.Enabled = true;
				groupBox_Size.Enabled = true;
				groupBox_Color.Enabled = true;
				checkBox_Pants.Enabled = true;

				if (checkBox_Pants.Checked)
				{
					groupBox_WearType.Enabled = false;
				}
				else
				{
					groupBox_WearType.Enabled = true;
				}
			}
			
		}

		
	}
}
