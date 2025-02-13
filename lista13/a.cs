using System;

namespace ddwdwdw
{
	static class Calc {
		public static int sum(int a, int b) {
			return a + b;
		}
		
		public static int sub(int a, int b) {
			return a - b;
		}
		
		public static int mul(int a, int b) {
			return a * b;
		}
		
		public static float div(int a, int b) {
			return a / b;
		}
	}
	
	class Program
	{
		public static void Main(string[] args)
		{
			Console.WriteLine(Calc.sum(1, 2));
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}
