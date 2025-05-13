using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rhombus
{
	class Program
	{
		static void Main(string[] args)
		{
			while (true)
			{
				Console.ForegroundColor = ConsoleColor.Blue;
				Console.WriteLine("Rhombus drawer");
				Console.ResetColor();
				Console.WriteLine();
				Console.ForegroundColor = ConsoleColor.Yellow;
				Console.Write("Enter rhombus size (any positive integer): ");

				if (int.TryParse(Console.ReadLine(), out int size))
				{
					if (size > 0)
					{
						Console.WriteLine();
						Console.ForegroundColor = ConsoleColor.Cyan;
						Console.WriteLine("Rhombus:");
						Console.WriteLine();

						for (int i = -size + 1; i < size; i++)
						{
							int absI = Math.Abs(i);

							for (int j = 0; j < absI; j++)
							{
								Console.Write(" ");
							}

							for (int j = 0; j < 2 * (size - absI) - 1; j++)
							{
								Console.Write("*");
							}

							Console.WriteLine();
						}

						break;
					}
					else
					{
						Console.ForegroundColor = ConsoleColor.Red;
						Console.WriteLine("Size must be a positive integer! Please try again!");
						Console.ResetColor();
					}
				}
				else
				{
					Console.ForegroundColor = ConsoleColor.Red;
					Console.WriteLine("Invalid input! Please enter a valid positive integer!");
					Console.ResetColor();
				}
			}

			Console.WriteLine();
			Console.ResetColor();
			Console.WriteLine("Press any key to exit!");
			Console.ReadKey();
			Console.Clear();
		}
	}
}
