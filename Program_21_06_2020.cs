using System;
using System.Linq;

public class Program
{
	public static double toCelsius(double inFahrenheit)
	{
		return ((inFahrenheit - 32) * (5.0 / 9.0));
	}

	public static bool isInRange(double a, double b, double x)
	{
		return x > a && x < b;
	}

	public static int calculate(int x, int n)
	{
		int result = 0;
		for (int i = 1; i <= n; i++)
		{
			result += x + i;
			Console.WriteLine(result);
		}

		return result;
	}

	public static void Rysuj(int width, int height, string symbol)
	{
		for (int i = 0; i < height; i++)
		{
			for (int j = 0; j < width; j++)
			{
				Console.Write(symbol);
			}

			Console.WriteLine();
		}
	}

	public static void Main()
	{
		Console.WriteLine(toCelsius(121));
		Console.WriteLine("Podaj dolna granice przedzialu");
		double lowest = Convert.ToDouble(Console.ReadLine());
		Console.WriteLine("Podaj gorna granice przedzialu");
		double highest = Convert.ToDouble(Console.ReadLine());
		Console.WriteLine("Podaj liczbe do sprawdzenia");
		double toCheck = Convert.ToDouble(Console.ReadLine());
		if (isInRange(lowest, highest, toCheck))
		{
			Console.WriteLine("Liczba znajduje sie w przdziale");
		}
		else
		{
			Console.WriteLine("Liczba poza przedzialem");
		}

		Console.WriteLine("Podaj x do wzoru");
		int x = Convert.ToInt32(Console.ReadLine());
		Console.WriteLine("Podaj n do wzoru");
		int n = Convert.ToInt32(Console.ReadLine());
		Console.WriteLine("Wynik to: " + calculate(x, n));
		Console.WriteLine("Podaj szerokosc prostokata");
		int width = Convert.ToInt32(Console.ReadLine());
		Console.WriteLine("Podaj wysokosc prostokata");
		int height = Convert.ToInt32(Console.ReadLine());
		Console.WriteLine("Podaj symbol");
		string symbol = Console.ReadLine();
		Console.WriteLine();
		Rysuj(width, height, symbol);
		Console.WriteLine();
		Rysuj(height, width, symbol);
	}
}
