using System;
					
public class Program
{
	public static void Main()
	{
		displayInFahrenheit();
		calculateDelta();
		calculateBMI();
	}
	
	private static void displayInFahrenheit()
	{
		Console.WriteLine("Podaj temperature w stopniach Celcjusza: ");
		Double inCelcius = Convert.ToDouble(Console.ReadLine());
		Double inFahrenheit = 32+((9*inCelcius)/5);
		Console.WriteLine("Temperatura w Fahrenheitach: " + inFahrenheit);
	}
	
	private static void calculateDelta()
	{
		Console.WriteLine("Podaj a:");
		Double a = Convert.ToDouble(Console.ReadLine());
		Console.WriteLine("Podaj b:");
		Double b = Convert.ToDouble(Console.ReadLine());
		Console.WriteLine("Podaj c:");
		Double c = Convert.ToDouble(Console.ReadLine());
		Double delta = Math.Pow(b, 2) - (4 * a * c);
		Console.WriteLine("Delta: " + delta);
	}
	
	private static void calculateBMI()
	{
		Console.WriteLine("Podaj wage w kilogramach:");
		Double mass = Convert.ToDouble(Console.ReadLine());
		Console.WriteLine("Podaj wzrost w metrach:");
		Double height = Convert.ToDouble(Console.ReadLine());
		Double bmi = mass/Math.Pow(height, 2);
		Console.WriteLine("Twoje BMI to: " + bmi);
	}
}
