using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using ConsoleApp1;

namespace Gui_banco.View.UserControls
{
    /// <summary>
    /// Interação lógica para BotaoOperacao.xam
    /// </summary>
    public partial class BotaoOperacao : UserControl
    {
        public BotaoOperacao()
        {       
            InitializeComponent();
            
        }

        private string textoBox { get; set; }

        public string TextoBox
        {
            get { if(!String.IsNullOrEmpty(textoBox)) 
                    return textoBox;
                else return "0";                
                }
            set { textoBox = value;
                tbPlaceholder.Text = textoBox;}
        }

        private double saldo;

        public double Saldo
        {
            get { return saldo; }
            set { saldo = value; }
        }

        private void txtInput_TextChanged(object sender, TextChangedEventArgs e)
        {
            
            if (string.IsNullOrEmpty(txtInput.Text))
            {
                tbPlaceholder.Visibility = Visibility.Visible;
            }
            else
            {
                TextoBox = txtInput.Text;
                tbPlaceholder.Visibility = Visibility.Hidden;
            }
        }

        public ICommand BotaoCommand
        {
            get { return (ICommand)GetValue(BotaoCommandProperty); }
            set { SetValue(BotaoCommandProperty, value); }
        }

        public static readonly DependencyProperty BotaoCommandProperty =
            DependencyProperty.Register("BotaoCommand", typeof(ICommand), typeof(BotaoOperacao), new PropertyMetadata(null));


        private void txtInput_TextBoxSomenteNumeros(object sender, TextCompositionEventArgs e)
        {
            e.Handled = !double.TryParse(e.Text, out _); 
        }
    }
}
