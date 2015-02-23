using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_Laboratory_Work_3
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		Array_T<string> arr_string;
		Array_T<int> arr_int;
		
		/// <summary>
		/// Метод получения количества элементов в массиве.
		/// </summary>
		/// <param name="lenght"></param>
		/// <returns></returns>
		private int Summ_of_Faktorial ( int lenght )
		{
			int lenght_final = 0;

			for (int i = 0; i <= lenght; i++)
			{
				lenght_final += i;
			}

			return lenght_final;
		}

		private void button1_Click(object sender, EventArgs e)
		{
			int a, b; 

			try
			{
				a = this.Summ_of_Faktorial(Int32.Parse(Text_Box_Lenght.Text));
				b = this.Summ_of_Faktorial(Int32.Parse(Text_Box_Count.Text));
			}
			catch
			{
				MessageBox.Show("Введены неверные данные, пожалуйста проверьте правильность ввода!");
				return;
			}
			
			if ( a <= 20 && b <= 20)
			{
				if ( radioButton_Object_Type_string.Checked)
				{
					arr_string = new Array_T<string>(a, b);
				}
				else
				{
					if ( radioButton_Objext_Type_int.Checked)
					{
						arr_int = new Array_T<int>(a, b);
					}
					else
					{
						MessageBox.Show("Тип массивов не выбран, пожалуйста проверьте наличие галочки на типе массива.");
						return;
					}
				}
			}
			else
			{
				MessageBox.Show("Размеры массивов превышают значение 20, повторите ввод с меньшими значениями количества элементов");
				return;
			}

			if (Int32.Parse(Text_Box_Left.Text) > 20 || Int32.Parse(Text_Box_Right.Text) > 20)
			{
				MessageBox.Show("Диапазон чисел слишком большой. Пожалуйста введите значения диапазона менее 20.");
				return;
			}

			if ( radioButton_Object_Type_string.Checked )
			{
				Random rnd = new Random();

				for ( int i = 0; i < arr_string.one_dimensional.Length; i++ )
				{
					switch (rnd.Next(0, 3))
					{
						case 0:
							{
								arr_string.one_dimensional[i] = ( (char)rnd.Next(65, 91) ).ToString();
								for (int j = 0; j < arr_string.two_dimensional.GetLength(1); j++)
								{
									switch ( rnd.Next(0,3))
									{
										case 0:
										{
											arr_string.two_dimensional[i, j] = ( (char)rnd.Next(65, 91) ).ToString();
											arr_string.inserted[i][j] = ( (char)rnd.Next(65, 91) ).ToString();
										}
										break;
										case 1:
										{
											arr_string.two_dimensional[i, j] = ( (char)rnd.Next(48, 57) ).ToString();
											arr_string.inserted[i][j] = ( (char)rnd.Next(48, 57) ).ToString();
										}
										break;
										case 2:
										{
											arr_string.two_dimensional[i, j] = ( (char)rnd.Next(97, 122) ).ToString();
											arr_string.inserted[i][j] = ( (char)rnd.Next(97, 122) ).ToString();
										}
										break;
									}
								}
							}
							break;
						case 1:
							{
								arr_string.one_dimensional[i] = ( (char)rnd.Next(48, 57) ).ToString();
								for (int j = 0; j < arr_string.two_dimensional.GetLength(1); j++)
								{
									switch (rnd.Next(0, 3))
									{
										case 0:
											{
												arr_string.two_dimensional[i, j] = ( (char)rnd.Next(65, 91) ).ToString();
												arr_string.inserted[i][j] = ( (char)rnd.Next(65, 91) ).ToString();
											}
											break;
										case 1:
											{
												arr_string.two_dimensional[i, j] = ( (char)rnd.Next(48, 57) ).ToString();
												arr_string.inserted[i][j] = ( (char)rnd.Next(48, 57) ).ToString();
											}
											break;
										case 2:
											{
												arr_string.two_dimensional[i, j] = ( (char)rnd.Next(97, 122) ).ToString();
												arr_string.inserted[i][j] = ( (char)rnd.Next(97, 122) ).ToString();
											}
											break;
									}
									
								}
							}
							break;
						case 2:
							{
								arr_string.one_dimensional[i] = ( (char)rnd.Next(97,122) ).ToString();
								for (int j = 0; j < arr_string.two_dimensional.GetLength(1); j++)
								{
									switch (rnd.Next(0, 3))
									{
										case 0:
											{
												arr_string.two_dimensional[i, j] = ( (char)rnd.Next(65, 91) ).ToString();
												arr_string.inserted[i][j] = ( (char)rnd.Next(65, 91) ).ToString();
											}
											break;
										case 1:
											{
												arr_string.two_dimensional[i, j] = ( (char)rnd.Next(48, 57) ).ToString();
												arr_string.inserted[i][j] = ( (char)rnd.Next(48, 57) ).ToString();
											}
											break;
										case 2:
											{
												arr_string.two_dimensional[i, j] = ( (char)rnd.Next(97, 122) ).ToString();
												arr_string.inserted[i][j] = ( (char)rnd.Next(97, 122) ).ToString();
											}
											break;
									}
								}
							}
							break;
					}
				}
			}
			else
			{
				Random rnd = new Random();

				int left = Int32.Parse(Text_Box_Left.Text);
				int right = Int32.Parse(Text_Box_Right.Text);

				for (int i = 0; i < arr_int.one_dimensional.Length; i++)
				{
					arr_int.one_dimensional[i] = rnd.Next(left, right + 1);

					for (int j = 0; j < arr_int.two_dimensional.GetLength(1); j++)
					{
						arr_int.two_dimensional[i, j] = rnd.Next(left, right + 1);
						arr_int.inserted[i][j] = rnd.Next(left, right + 1);
					}
				}
			}

			groupBox_ArrayButton.Enabled = true;
		}


		private void button1_Click_1 ( object sender, EventArgs e )
		{
			label_Array.Text = String.Empty;
			label_ShowResult.Text = String.Empty;

			if ( radioButton_Object_Type_string.Checked)
			{
				
				int change = 0;
				do
				{
					change = 0;
					for (int i = 0; i < arr_string.one_dimensional.Length - 1; i++)
					{
						if (String.Compare(arr_string[i],arr_string[i + 1]) > 0 )
						{
							change++;
							string temp = arr_string[i];
							arr_string[i] = arr_string[i + 1];
							arr_string[i + 1] = temp;
						}
					}
				} while ( change != 0);

				for ( int i = 0; i < arr_string.one_dimensional.Length; i++)
				{
					label_Array.Text += " <" + arr_string[i] + ">\t";
					label_ShowResult.Text += arr_string[i];
				}
			}

			if( radioButton_Objext_Type_int.Checked)
			{
				int change = 0;
				do
				{
					change = 0;
					for (int i = 0; i < arr_int.one_dimensional.Length - 1; i++)
					{
						if (arr_int[i] > arr_int[i + 1])
						{
							change++;
							int temp = arr_int[i];
							arr_int[i] = arr_int[i + 1];
							arr_int[i + 1] = temp;
						}
					}
				} while (change != 0);

				int sum = 0;
				for (int i = 0; i < arr_int.one_dimensional.Length; i++)
				{
					label_Array.Text += " <" + arr_int[i].ToString() + ">\t";
					sum += arr_int[i];
				}
				label_ShowResult.Text = sum.ToString();
			}
		}

		private void button2_Click ( object sender, EventArgs e )
		{
			label_Array.Text = String.Empty;
			label_ShowResult.Text = String.Empty;

			if (radioButton_Object_Type_string.Checked)
			{
				int change = 0;
				for (int j = 0; j < arr_string.two_dimensional.GetLength(0); j++)
				{
					do
					{
						change = 0;
						for (int i = 0; i < arr_int.two_dimensional.GetLength(1) - 1; i++)
						{
							if (String.Compare(arr_string.two_dimensional[j, i], arr_string.two_dimensional[j, i + 1]) > 0)
							{
								change++;
								string temp = arr_string.two_dimensional[j, i];
								arr_string.two_dimensional[j, i] = arr_string.two_dimensional[j, i + 1];
								arr_string.two_dimensional[j, i + 1] = temp;
							}
						}
					} while (change != 0);
				}

				//for (int i = 0; i < arr_string.two_dimensional.GetLength(0); i++ )
				//{
				//	for (int j = 0; j < arr_string.two_dimensional.GetLength(1); j++ )
				//	{

				//	}
				//}
					foreach (string s in arr_string.two_dimensional)
					{
						label_Array.Text += " <" + s + ">\t";
						label_ShowResult.Text += s;
					}
			}

			if (radioButton_Objext_Type_int.Checked)
			{
				int change = 0;
				for (int j = 0; j < arr_int.two_dimensional.GetLength(0); j++)
				{
					do
					{
						change = 0;
						for (int i = 0; i < arr_int.two_dimensional.GetLength(1) - 1; i++)
						{
							if (arr_int.two_dimensional[j,i] > arr_int.two_dimensional[j,i + 1])
							{
								change++;
								int temp = arr_int.two_dimensional[j, i];
								arr_int.two_dimensional[j, i] = arr_int.two_dimensional[j, i + 1];
								arr_int.two_dimensional[j,i + 1] = temp;
							}
						}
					} while (change != 0);
				}

				int sum = 0;
				foreach ( int i in arr_int.two_dimensional )
				{
					label_Array.Text += " <" + i.ToString() + ">\t";
					sum += i;
				}
				label_ShowResult.Text = sum.ToString();
			}
		}

		private void button3_Click ( object sender, EventArgs e )
		{
			label_Array.Text = String.Empty;
			label_ShowResult.Text = String.Empty;

			if (radioButton_Object_Type_string.Checked)
			{
				int change = 0;
				for (int j = 0; j < arr_string.inserted.GetLength(0); j++)
				{
					do
					{
						change = 0;
						for (int i = 0; i < arr_string.inserted[j].GetLength(0) - 1; i++)
						{
							if (String.Compare(arr_string.inserted[j][i], arr_string.inserted[j][i + 1]) > 0)
							{
								change++;
								string temp = arr_string.inserted[j][i];
								arr_string.inserted[j][i] = arr_string.inserted[j][i + 1];
								arr_string.inserted[j][i+1] = temp;
							}
						}
					} while (change != 0);
				}

				foreach (string[] arr in arr_string.inserted)
				{
					foreach ( string s in arr)
					{
						label_Array.Text += " <" + s + ">\t";
						label_ShowResult.Text += s;
					}
				}
			}
			if (radioButton_Objext_Type_int.Checked)
			{
				int change = 0;
				for (int j = 0; j < arr_int.inserted.Length; j++)
				{
					do
					{
						change = 0;
						for (int i = 0; i < arr_int.inserted[j].Length - 1; i++)
						{
							if (arr_int.inserted[j][i] > arr_int.inserted[j][i + 1])
							{
								change++;
								int temp = arr_int.inserted[j][i];
								arr_int.inserted[j][i] = arr_int.inserted[j][i + 1];
								arr_int.inserted[j][i + 1] = temp;
							}
						}
					} while (change != 0);
				}

				int sum = 0;
				foreach (int[] arr in arr_int.inserted)
				{
					foreach (int s in arr)
					{
						label_Array.Text += " <" + s + ">\t";
						sum += s;
					}
				}
				label_ShowResult.Text = sum.ToString();
			}
		}

		private void Text_Box_Lenght_Click ( object sender, EventArgs e )
		{
			Text_Box_Lenght.SelectAll();
		}

		private void Text_Box_Count_Click ( object sender, EventArgs e )
		{
			Text_Box_Count.SelectAll();
		}

		private void Text_Box_Left_Click ( object sender, EventArgs e )
		{
			Text_Box_Left.SelectAll();
		}

		private void Text_Box_Right_Click ( object sender, EventArgs e )
		{
			Text_Box_Right.SelectAll();
		}

		private void radioButton_Objext_Type_int_CheckedChanged ( object sender, EventArgs e )
		{
			if (radioButton_Objext_Type_int.Checked && arr_int != null)
			{
				groupBox_ArrayButton.Enabled = true;
			}
			else
			{
				groupBox_ArrayButton.Enabled = false;
			}
		}

		private void radioButton_Object_Type_string_CheckedChanged ( object sender, EventArgs e )
		{
			if (radioButton_Object_Type_string.Checked && arr_string != null)
			{
				groupBox_ArrayButton.Enabled = true;
			}
			else
			{
				groupBox_ArrayButton.Enabled = false;
			}
		}

		
	}
}
