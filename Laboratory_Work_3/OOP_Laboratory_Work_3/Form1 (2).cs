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
				lenght_final += lenght;
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
					Array_T<string> arr = new Array_T<string>(a, b);
				}
				else
				{
					if ( radioButton_Objext_Type_int.Checked)
					{
						Array_T<int> arr = new Array_T<int>(a, b);
					}
					else
					{
						MessageBox.Show("Тип массивов не выбран, пожалуйста проверьте наличие галочки на типе массива.");
						return;
					}
				}
			}

		}

		private void textBox2_TextChanged(object sender, EventArgs e)
		{

		}

		private void textBox3_TextChanged ( object sender, EventArgs e )
		{

		}

		private void textBox1_TextChanged ( object sender, EventArgs e )
		{

		}

		

		
	}
}
