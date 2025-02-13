using System;

namespace ddwdwdw
{
	class Program
	{
		public static void Main(string[] args)
		{
			int[] numbers = {2, 2, 4, 4};
			int sum = 0;
			
			foreach (var num in numbers) {
				sum += num;
			}
			
			Console.WriteLine(sum / numbers.Length);
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}
