using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratory_Work_9_DLL
{
	public static class Solve_Task_Using_Dictionary
	{
		private const string latin = "abcdefghijklmnopqrstuvwxyz0123456789,. !?:()[]-";

		/// <summary>
		/// Проверка на наличие только Латинских букв.
		/// </summary>
		/// <param name="strings"></param>
		/// <returns></returns>
		private static bool CheckReqierments(string[] strings)
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
				System.Windows.Forms.MessageBox.Show(ex.Message);
				return false;
			}
			return true;
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="text"></param>
		/// <returns></returns>
		public static string Solve_Task( string text )
		{
			string[] strings = text.Split('\n');

			if (!CheckReqierments(strings))
			{
				return "";
			}

			int max_length = 0;

			for (int i = 0; i < strings.Length; i++)
			{
				if (strings[i].Length > max_length)
				{
					max_length = i;
				}
			}

			string[] words = strings[max_length].Split(
				new char[] 
				{ 
					',', 
					'.', 
					'!', 
					'?', 
					':', 
					' ', 
					'\t', 
					'\r', 
					'\n' 
				});

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

			return data;
		}
	}
}
