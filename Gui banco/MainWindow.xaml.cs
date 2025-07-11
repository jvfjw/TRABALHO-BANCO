using ConsoleApp1;
using GalaSoft.MvvmLight.CommandWpf;
using Gui_banco.View.UserControls;
using System.Windows;
using System.Windows.Input;

namespace Gui_banco;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
   
    private ContaDoBanco? Conta { get; }
    private ContaDoBanco? Conta2 { get; }
    public ICommand MeuComando { get; }
    public MainWindow()
    {

    InitializeComponent();
       
        Cliente cliente = new Cliente()
        {
            Nome = "João Silva",
            IdCliente = "12345",
            Endereço = "Rua Exemplo, 123"
        };
        Cliente cliente2 = new Cliente()
        {
            Nome = "Brenda",
            IdCliente = "123456",
            Endereço = "Rua Exemplo, 123"
        };
        ContaDoBanco conta2 = new ContaDoBanco(1001, 500.0, cliente, TipoConta.Corrente);
        ContaDoBanco conta3 = new ContaDoBanco(1001, 500.0, cliente, TipoConta.Corrente);
        MeuComando = new RelayCommand(ExecutarBotao);
        btnConfirmar.BotaoCommand = MeuComando;
        this.Conta = conta2;
        this.Conta2 = conta3;
        ClienteColuna1.nomeCliente.Text = cliente.Nome;
        ClienteColuna1.enderecoCliente.Text = cliente.Endereço;
        ClienteColuna1.idCliente.Text = cliente.IdCliente;
        ClienteColuna2.nomeCliente.Text = cliente2.Nome;
        ClienteColuna2.enderecoCliente.Text = cliente2.Endereço;
        ClienteColuna2.idCliente.Text = cliente2.IdCliente;
    }

    private void ExecutarBotao()
    {
        Conta.Depositar(double.Parse(btnConfirmar.TextoBox), "Depósito");
        tSaldo.Saldo = Conta.Saldo;
    }
    private void BotaoOperacao_Loaded(object sender, RoutedEventArgs e)
    {
        btnConfirmar.tbPlaceholder.Text = "Insirá um valor a depositar";
        btnConfirmar.Margin = new Thickness(5, 0, 0, 0);
    }

    private void btnConfirmar_Clicado(object sender, RoutedEventArgs e)
    {
    }
    private void telaSaldo_Loaded(object sender, RoutedEventArgs e)
    {
        tSaldo.Saldo = Conta.Saldo;
    }


}