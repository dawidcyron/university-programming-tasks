using System;
using System.Linq;
					
public class Program
{
	public static void Main()
	{
    	fillArray();
		copyPositiveNumbersFromArray();
		addMatrix();
	}
	
	private static void fillArray() {
		int size = Convert.ToInt16(Console.ReadLine());
		int[] arr = new int[size];
		for (int i = 0; i < size; i++) {
			arr[i] = Convert.ToInt16(Console.ReadLine());
		}
		Console.WriteLine("Data in array: ");
		foreach (int num in arr) {
			Console.Write(num + " ");
		}
		Console.WriteLine();
	}
	
	private static void copyPositiveNumbersFromArray() {
		int[] allNums = {5, 3, 2, -1, -20, 53, -21, 0, 21, -3};
		int[] onlyPositive = new int[10];
		int positiveIndex = 0;
		Console.WriteLine("Positive numbers from first array: ");
		foreach (int num in allNums) {
			if (num > 0) {
				onlyPositive[positiveIndex] = num;
				positiveIndex++;
			}
		}
		for (int i = 0; i < positiveIndex; i++) {
			Console.Write(onlyPositive[i] + " ");
		}
		Console.WriteLine();
	}
	
	private static void addMatrix() {
		int[,] arr = {{9, 1, 7}, {12, 32, 65}};
		int[,] arr2 = {{2, 3, 5}, {6, 3, 1}};
		int[,] result = new int[2,3];
		Console.WriteLine("Matrix after addition: ");
		for (int i = 0; i < arr.GetLength(0); i++) {
			for (int j = 0; j < arr.GetLength(1); j++) {
				result[i,j] = arr[i,j] + arr2[i,j];
				Console.Write(result[i,j] + " ");
			}
			Console.WriteLine();
		}
	}
}
