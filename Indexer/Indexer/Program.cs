namespace Indexer
{
	internal class Program
	{
		static void Main(string[] args)
		{
			//int[] arr = { 1, 2, 3, 4, 5 };
			//Console.WriteLine(arr[0]);

			ListInt array = new ListInt();
			//array.Add(12);
			//Console.WriteLine(array[0]);

			array.AddRange(1, 2, 3, 4, 5, 6, 7, 8, 9);
			//Console.WriteLine(array[1]);

			//array.Contains(500);

			//array.Sum();
			//array.Remove(5);

			//array.RemoveRange(5, 6, 7);
			array.ToString();
		}
	}
}
