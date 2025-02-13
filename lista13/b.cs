using System;

namespace ddwdwdw
{
	class Banco {
		readonly public string nome;
		
		int dinheiro = 0;
		bool contaAberta = true;
		
		public Banco(string nome) {
			this.nome = nome;
		}
		
		public int depositar(int quantia) {
			if (!this.contaAberta) {
				return -1;
			}
			
			this.dinheiro += quantia;
			return this.dinheiro;
		}
		
		public int sacar(int quantia) {
			if (!this.contaAberta) {
				return -1;
			}
			
			this.dinheiro -= quantia;
			return this.dinheiro;
		}
		
		public bool fecharConta() {
			this.contaAberta = false;
		}
		
	}
	
	class Program
	{
		public static void Main(string[] args)
		{
			var conta = new Banco("Matheus Cristian Rocha Gomes");
			
			Console.WriteLine(conta.depositar(1000));
			conta.fecharConta();
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}
