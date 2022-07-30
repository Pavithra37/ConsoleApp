using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorApp
{
	class Program
	{
		public static void Main(string[] args)
		{
			double num1 = 0; double num2=0;
			Console.WriteLine("This is a calculator app");
			Console.WriteLine("\n.............\n");

			Console.WriteLine("Enter num1:");
			num1 = Convert.ToDouble(Console.ReadLine());
			Console.WriteLine("Enter num2:");
			num2 = Convert.ToDouble(Console.ReadLine());

			Console.WriteLine("Choose an option:");
			Console.WriteLine("\ta - Addition");
			Console.WriteLine("\tb - Subtraction");
			Console.WriteLine("\tc - Multiplication");
			Console.WriteLine("\td - Division");

			switch (Console.ReadLine())
			{
				case "a":
					Console.WriteLine($"{num1} + {num2} = " + (num1 + num2));
					break;
				case "b":
					Console.WriteLine($"{num1} - {num2} = " + (num1 - num2));
					break;
				case "c":
					Console.WriteLine($"{num1} * {num2} = " + (num1 * num2));
					break;
				case "d":
					while (num2 == 0)
					{
						Console.WriteLine("Enter a non-zero integer:");
						num2 = Convert.ToDouble(Console.ReadLine());
					}
						Console.WriteLine($"{num1} / {num2} = " + (num1 / num2));
						break;


            }

			Console.ReadKey();
		}
	}
}
