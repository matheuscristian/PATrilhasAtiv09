using System;

namespace ddwdwdw
{
	class Program
	{
		public static void Main(string[] args)
		{
			int[] numbers = {1, 3, 4, 5, 7, 8, 9, 83, 28};
			int max = int.MinValue;
			
			foreach (var num in numbers) {
				if (num > max) {
					max = num;
				}
			}
			
			Console.WriteLine(max);
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}
