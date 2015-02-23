using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laboratory_Work_8
{
	public partial class Form1 : Form
	{
		private static string latin = "abcdefghijklmnopqrstuvwxyz0123456789,. !?:()[]-";

		public Form1()
		{
			InitializeComponent();
		}

		private bool CheckReqierments(string[] strings)
		{
			try
			{
				for (int j = 0; j < strings.Length; j++)
				{
					string word = strings[j].ToLower();

					for (int i = 0; i < word.Length; i++)
					{
						bool flag = false;
						for (int k = 0; k < latin.Length; k++)
						{
							if (word[i] == latin[k])
								flag = true;
						}

						if (word == "")
							flag = true;

						if (!flag)
							throw new NotLatinAlphabetException();
					}
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
				return false;
			}
			return true;
		}

		private void button1_Click(object sender, EventArgs e)
		{
			string[] strings = richTextBox1.Text.Split('\n' );

			if (!CheckReqierments(strings))
			{
				return;
			}

			int max_length = 0;

			for ( int i = 0; i < strings.Length; i++)
			{
				if (strings[i].Length > max_length)
				{
					max_length = i;
				}
			}

			string[] words = strings[max_length].Split(new char[] { ',', '.', '!', '?', ':', ' ', '\t', '\r', '\n' });

			Dictionary<char, int> consonants = new Dictionary<char, int>()
			{
				{'b',0},
				{'c',0},
				{'d',0},
				{'f',0},
				{'g',0},
				{'h',0},
				{'j',0},
				{'k',0},
				{'l',0},
				{'m',0},
				{'n',0},
				{'p',0},
				{'q',0},
				{'r',0},
				{'s',0},
				{'t',0},
				{'v',0},
				{'x',0},
				{'z',0}
			};

			string data = "Самая длинная строка имеет номер <" + max_length + ">\n\nОна имеет вид:" + strings[max_length] + "\n\n";

			for (int i = 0; i < words.Length; i++)
			{
				if (words[i] == "")
					continue;

				string word = words[i].ToLower();

				for (int j = 0; j < word.Length; j++)
				{
					if (consonants.ContainsKey(word[j]))
					{
						consonants[word[j]]++;
					}
				}
			}

			foreach (var t in consonants)
			{
				data += t.Key + ": " + t.Value + "\r\n";
			}

			richTextBox2.Text = data;
		}
	}
}
