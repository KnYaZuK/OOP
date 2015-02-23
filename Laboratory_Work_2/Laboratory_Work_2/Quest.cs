using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratory_Work_2
{
	class Quest
	{
		static public void Do_This ( int[] arr, ref int positive, ref int negative )
		{
				for (int i = 0; i < arr.Length; i++)
				{
					if ( (i + 1 ) % 2 == 0)
					{
						if ( arr[i] > 0 )
						{
							positive += arr[i];
						}
					}
					else
					{
						if ( arr[i] < 0 )
						{
							negative += arr[i];;
						}
					}
				}

		}
			
		

		static public int[,] Do_This( int[,] arr )
		{
			uint swap;
			do
			{
				swap = 0;
				
					for (int j = 0; j < arr.GetLength(1) - 1; j++)
					{
						if (arr[0, j + 1] < arr[0, j])
						{
							int temp = arr[0, j];
							arr[0, j] = arr[0, j + 1];
							arr[0, j + 1] = temp;
							swap++;
						}
					}

				for (int i = 0; i < arr.GetLength(0) - 1; i++)
				{
					if (arr[i + 1, arr.GetLength(1) - 1] < arr[i, arr.GetLength(1) - 1])
					{
						int temp = arr[i, arr.GetLength(1) - 1];
						arr[i, arr.GetLength(1) - 1] = arr[i + 1, arr.GetLength(1) - 1];
						arr[i + 1, arr.GetLength(1) - 1] = temp;
						swap++;
					}
				}

					for (int j = arr.GetLength(1) - 1; j > 0; j--)
					{
						if (arr[arr.GetLength(0) - 1, j - 1] < arr[arr.GetLength(0) - 1, j])
						{
							int temp = arr[arr.GetLength(0) - 1, j];
							arr[arr.GetLength(0) - 1, j] = arr[arr.GetLength(0) - 1, j - 1];
							arr[arr.GetLength(0) - 1, j - 1] = temp;
							swap++;
						}
					}

				for (int i = arr.GetLength(0) - 1; i > 1; i--)
				{
					if (arr[i - 1, 0] < arr[i, 0])
					{
						int temp = arr[i, 0];
						arr[i, 0] = arr[i - 1, 0];
						arr[i - 1, 0] = temp;
						swap++;
					}
				}

			} while (swap != 0);

			return arr;
		}

		
	}
}
