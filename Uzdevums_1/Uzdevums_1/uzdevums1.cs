using System;
namespace Uzdevums_1
{
	public class uzdevums1
	{
		static void Main(string[] args)
		{
			int[,] array = new int[20, 20];

			// Aizpilda masivu ar gadijuma cipariem
			Random random = new Random();
			for(int i = 0; i < 20; i++)
			{
				for(int j = 0; i < 20; i++)
				{
					array[i, j] = random.Next(100);
				}
			}

			// Izvada masivu uz ekrana
			for(int i = 0; i < 20; i++)
			{
				for(int j = 0; i < 20; i++)
				{
					Console.Write(array[i, j] + " ");
				}
				Console.WriteLine();
			}

			//Atrod mazako un lielako ciparu un to koordinates
			int min = array[0, 0];
			int max = array[0, 0];
			int minRow = 0;
			int minCol = 0;
			int maxRow = 0;
			int maxCol = 0;

			for(int i = 0; i < 20; i++)
			{
				for (int j = 0; j < 20; j++)
				{
					if (array[i, j] < min)
					{
						min = array[i, j];
						minRow = i;
						minCol = i;
					}

					if (array[i, j] > max)
					{
						max = array[i, j];
						maxRow = i;
						maxCol = j;
					}

					Console.WriteLine($"Mazakais cipars: {min} (Koordinates: {minRow}, {minCol})");
					Console.WriteLine($"Lielakais cipars: {max} (Koordinates: {maxRow}, {maxCol})");

					//Atlasa un izvada masivu augosa seciba
					int[] sortedArray = new int[400];
					int index = 0;

					for (int i = 0; i < 20; i++)
					{
						for (int j = 0; j < 20; j++)
						{
							sortedArray[index] = array[i, j];
							index++;
						}	
					}

					Array.Sort(sortedArray);

					Console.WriteLine("Masivs augosa seciba:");
					for (int i = 0; i < 20; i++)
					{
						Console.WriteLine(sortedArray[i] + " ");
						if((i + 1) % 20 == 0)
						{
							Console.WriteLine();
						}
					}

					Console.ReadLine();

				}
			}
		}
	}
}

