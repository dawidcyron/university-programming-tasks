using System;
using System.Linq;
					
public class Program
{
	public static void Main()
	{
		LeapYear();	
		isDivisor();
		maxNumber();
		simpleCalculator();
		roots();
		bmi();
		stipend();
		drawingOne();
		factorial();
		toCross100();
		sumInput();
		series();
	}
	
	private static void isLeapYear()
	{
		int year = Convert.ToInt32(Console.ReadLine());
		if (year % 400 == 0) 
		{
			Console.WriteLine("Leap Year");
		} else if (year % 100 == 0) {
			Console.WriteLine("Not leap year");
		} else if (year % 4 == 0) {
			Console.WriteLine("Leap year");
		} else {
			Console.WriteLine("Not a leap year");
		}
	}
	
	private static void isDivisor()
	{
		int number = Convert.ToInt32(Console.ReadLine());
		int divisor = Convert.ToInt32(Console.ReadLine());
		if (number % divisor == 0) {
			Console.WriteLine(divisor + " is a divisior of " + number);
		} else {
			Console.WriteLine(divisor + " is not a divisor of " + number);
		}
	}
	
	private static void maxNumber()
	{
		double[] numbers = new double[3];
		numbers[0] = Convert.ToDouble(Console.ReadLine());
		numbers[1] = Convert.ToDouble(Console.ReadLine());
		numbers[2] = Convert.ToDouble(Console.ReadLine());
		Console.WriteLine(numbers.Max());
	}
	
	private static void simpleCalculator()
	{
		double firstNumber = Convert.ToDouble(Console.ReadLine());	
		double secondNumber = Convert.ToDouble(Console.ReadLine());
		string operation = Console.ReadLine();
		if (operation == "+") {
			Console.WriteLine(firstNumber + secondNumber);
		} else if (operation == "-") {
			Console.WriteLine(firstNumber - secondNumber);
		} else if (operation == "*") {
			Console.WriteLine(firstNumber * secondNumber);
		} else if (operation == "/") {
			Console.WriteLine(firstNumber / secondNumber);
		}
	}
	
	private static void roots()
	{
		double a = Convert.ToDouble(Console.ReadLine());
		double b = Convert.ToDouble(Console.ReadLine());
		double c = Convert.ToDouble(Console.ReadLine());
		double delta = Math.Pow(b, 2) - 4 * a * c;
		if (delta < 0) {
			Console.WriteLine("No roots");
		} else if (delta == 0) {
			Console.WriteLine((-1 * b)/(2 * a));
		} else {
			Console.WriteLine(((-1 * b) - Math.Sqrt(delta))/(2 * a));
			Console.WriteLine(((-1 * b) + Math.Sqrt(delta))/(2 * a));
		}
	}
	
	private static void bmi()
	{
		Console.WriteLine("Enter height in meters");
		double height = Convert.ToDouble(Console.ReadLine());
		Console.WriteLine("Enter weight in kg");
		double weight = Convert.ToDouble(Console.ReadLine());
		double bmi = weight/Math.Pow(height, 2);
		if (bmi < 15.5) {
			Console.WriteLine("Niedowaga");
		} else if (bmi >= 18.5 && bmi < 24.99) {
			Console.WriteLine("Wartosc prawidlowa");
		} else {
			Console.WriteLine("Nadwaga");
		}
	}
	
	private static void stipend()
	{
		double gpa = Convert.ToDouble(Console.ReadLine());
		if (gpa >= 2 && gpa <= 3.99) {
			Console.WriteLine("Stipend equal to 0 pln");
		} else if (gpa >=4 && gpa >= 4.79) {
			Console.WriteLine("Stipend equal to 350 pln");
		} else if (gpa >= 4.8 && gpa <= 5) {
			Console.WriteLine("Stipend equal to 550 pln");
		}
	}
	
	private static void drawingOne()
	{
		int rows = Convert.ToInt16(Console.ReadLine());
		// Draw first image
		for (int i = 0; i < rows; i++) {
			for (int j = 0; j < rows; j++) {
				if (j <= i)
				{
					Console.Write("*");
				}
			}
			Console.WriteLine();
		}
		Console.WriteLine();
		// Draw second image
		for (int i = 0; i < rows; i++) {
			for (int j = 0; j < rows; j++) {
				if (i <= j)
				{
					Console.Write("*");
				}
			}
			Console.WriteLine();
		}
		Console.WriteLine();
		// Draw third image
		for (int i = 0; i < rows; i++) {
			for (int j = 0; j < rows; j++) {
				if (rows - j <= i + 1)
				{
					Console.Write("*");
				} else {
					Console.Write(" ");
				}
			}
			Console.WriteLine();
		}
		Console.WriteLine();
		// Draw fourth image
		for (int i = 0; i < rows; i++) {
			for (int j = 0; j < rows; j++) {
				if (i == 0 || i == rows-1 || j == 0 || j == rows-1 )
				{
					Console.Write("*");
				} else {
					Console.Write(" ");
				}
			}
			Console.WriteLine();
		}
	}
	
	private static void factorial()
	{
		int toCalculate = Convert.ToInt16(Console.ReadLine());
		int factorial = toCalculate;
		for (int i = toCalculate-1; i > 0; i--) {
			factorial *= i;
		}
		Console.WriteLine(factorial);
	}
	
	private static void toCross100()
	{
		int currentNumber = Convert.ToInt16(Console.ReadLine());
		if (currentNumber >= 100) {
			Console.WriteLine(0);
		} else {
			int counter = 0;
			while(currentNumber < 100) {
				currentNumber += currentNumber+1;
				counter++;
			}
			Console.WriteLine(counter);
		}
	}
	
	private static void sumInput()
	{
		int sum = 0;
		int data = Convert.ToInt16(Console.ReadLine());
		while (data != 0) {
			sum += data;
			data = Convert.ToInt16(Console.ReadLine());
		}
		Console.WriteLine(sum);
	}
	
	private static void series()
	{
		int goUntil = Convert.ToInt16(Console.ReadLine());
		if (goUntil % 2 == 0) {
			Console.WriteLine(-1 * goUntil / 2);
		} else {
			Console.WriteLine(goUntil / 2);
		}
	}
}
