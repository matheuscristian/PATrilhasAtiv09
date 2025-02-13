using System;

namespace ddwdwdw
{
	class Program
	{
		public static void Main(string[] args)
		{
			string[] s = {"Hello, ", "World!"};
			
			foreach (var txt in s) {
				Console.WriteLine(txt);
			}
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}
