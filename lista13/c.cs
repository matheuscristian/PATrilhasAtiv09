using System;

namespace ddwdwdw
{
	class Produto {
		public int qnt;
		public int preco;
		
		public Produto(int qnt, int preco) {
			this.qnt = qnt;
			this.preco = preco;
		}
		
		public int calcularValorTotal() {
			return this.qnt * this.preco;
		}
		
	}
	
	class Program
	{
		public static void Main(string[] args)
		{
			var produto = new Produto(34, 25);
			
			Console.WriteLine(produto.calcularValorTotal());
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}
