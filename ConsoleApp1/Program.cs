using ConsoleApp1;

Cliente cliente = new Cliente()
{
    Nome = "João Silva",
    IdCliente = "12345",
    Endereço = "Rua Exemplo, 123"
};

TipoConta tipoConta = TipoConta.Corrente;
ContaDoBanco conta = new ContaDoBanco(1001, 500.0, cliente, tipoConta);

conta.Sacar(200, "Refrigerante e vinho");

conta.Depositar(300, "Bolsa família");

Console.WriteLine(conta.informacoesConta());

conta.ExibirTransacoes();
