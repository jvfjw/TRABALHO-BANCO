using System;

namespace ConsoleApp1 {

    class Program
    {
        static void Main(string[] args)
        {

            Cliente cliente = new Cliente()
            {
                Nome = "João Silva",
                IdCliente = "12345",
                Endereço = "Rua Exemplo, 123"
            };

            
            ContaDoBanco conta = new ContaDoBanco(1001, 500.0, cliente, TipoConta.Corrente);

            conta.Sacar(200, "Refrigerante e vinho");

            conta.Depositar(300, "Bolsa família");

            Console.WriteLine(conta);

            conta.ExibirTransacoes();
        }
    }
}