using System;

namespace ddwdwdw
{
	class Program
	{
		public static void Main(string[] args)
		{
			int[] numbers = {1, 3, 4, 5, 7, 8, 9, 83, 28};
			
			foreach (var num in numbers) {
				Console.WriteLine(num);
			}
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}
