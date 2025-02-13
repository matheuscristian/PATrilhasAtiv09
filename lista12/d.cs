using System;

namespace ddwdwdw
{
	class Program
	{
		public static void Main(string[] args)
		{
			string[] numbers = {"Hello, ", "World! hehehhe"};
			string max = "";
			
			foreach (var num in numbers) {
				if (num.Length > max.Length) {
					max = num;
				}
			}
			
			Console.WriteLine(max);
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}
