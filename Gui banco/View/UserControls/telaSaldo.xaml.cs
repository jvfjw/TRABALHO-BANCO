﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Gui_banco.View.UserControls
{
    /// <summary>
    /// Interação lógica para telaSaldo.xam
    /// </summary>
    public partial class telaSaldo : UserControl
    {
        public telaSaldo()
        {
            InitializeComponent();
        }

        private double saldo;
        public double Saldo
        {
            get { return saldo; }
            set { saldo = value;
                saldoConta.Text = $"Saldo: {Saldo:C}";  }
        }

    }
}
