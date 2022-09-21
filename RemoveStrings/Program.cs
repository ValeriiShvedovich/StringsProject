using System;

namespace RemoveStrings
{
	class Program
	{
		static void Main(string[] args)
		{
			const int n = 5; //количество исходных строк
			string[] input = new string[n];
			Console.WriteLine("Необходимо ввести {0} строк\n", n);
			for (int i = 0; i < n; i++)
			{
				Console.Write("Введите строку #{0}: ", i + 1);
				input[i] = Console.ReadLine();
			}
			string[] output = new string[n]; //результирующий массив
			int count = 0; //количество строк
			for (int i = 0; i < n; i++)
			{
				if (input[i].Length <= 3)
				{
					output[count++] = input[i]; //добавляем строку с увелечением количества
				}
			}
			Console.WriteLine("\nСтроки, длина которых меньше либо равна 3 символам (всего {0} строк): ", count);
			for (int i = 0; i < count; i++)
				Console.WriteLine(output[i]);
			Console.WriteLine("Нажмите Enter для завершения...");
			Console.ReadLine();
		}
	}
}
