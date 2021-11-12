using System;
using System.Linq;
class Program
{
	static int count = 0;
	static void Main(string[] args)
	{
		int[] s = new int[20];
		Random r = new Random();
		for(int i = 0; i < 20; i++){
			s[i] = r.Next(0, 1000);
		}
		Console.WriteLine(string.Join(", ", s));

		Console.WriteLine("");
		Console.WriteLine("sort↓");
		Console.WriteLine("");

		s = QuickSort(s);
		
		Console.WriteLine(string.Join(", ", s));
		Console.WriteLine("count : " + count);
	}

	static int[] QuickSort(int[] array){
		count++;
		if (array.Length <= 1) return array;
		if (array.Length == 2) {
			if (array[0] > array[1]){
				int tmp = array[0];
				array[0] = array[1];
				array[1] = tmp;
			}
			return array;
		}

		int pivot = array[0];			// 基準値
		int[] smallArray = new int[0];	// 基準値より小さい組
		int[] largeArray = new int[0];	// 基準値より大きい組

		for(int i = 1; i < array.Length; i++){
			if (pivot > array[i]){
				Array.Resize(ref smallArray, smallArray.Length + 1);
				smallArray[smallArray.Length -1] = array[i];
			}
			else {
				Array.Resize(ref largeArray, largeArray.Length + 1);
				largeArray[largeArray.Length -1] = array[i];
			}
		}

		smallArray = QuickSort(smallArray);
		largeArray = QuickSort(largeArray);

		return smallArray.Concat(new int[]{ pivot }).ToArray().Concat(largeArray).ToArray();
    }
}