using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Banco
    {
        public enum TipoConta
        { 
            Corrente,
            Poupança
        }

        public struct Transaçao
        {
            public double Quantia { get; }
            public DateTime Data { get; }

            public string Descricao { get; }

            public Transaçao(double quantia, DateTime data, string descricao)
            {
                Quantia = quantia;
                Data = data;
                Descricao = descricao;
            }
            public override string ToString()
            {
                return $"{Data.ToShortDateString()}: {Descricao} - {Quantia:C}";
            }
        }


        public record Cliente 
        {
            public string Nome { get; init; }
            public string IdCliente { get; init; }

            public string Endereço { get; init; }

        }

        public class ContaDoBanco
        {
            public int NumeroConta { get; }
            public double Saldo { get; private set; }

            public Cliente nomeCliente { get; }

            public TipoConta Tipo { get; }

            private List<Transaçao> _transacoes = new();

            public ContaDoBanco(int numeroConta, double saldo, Cliente nomeDoCliente, TipoConta tipo) 
            {
                NumeroConta = numeroConta;
                Saldo = saldo;
                nomeCliente = nomeDoCliente;
                Tipo = tipo;
            }

            public void Depositar(double quantia, string descricao)
            {
                if (quantia > 0)
                {
                    _transacoes.Add(new Transaçao(quantia, DateTime.Now, descricao));
                    Saldo += quantia;
                }
            }

            public bool Sacar(double quantia, string descricao)
            {
                if (quantia > 0 && Saldo >= quantia)
                {
                    Saldo -= quantia;
                    _transacoes.Add(new Transaçao(-quantia, DateTime.Now, descricao));
                    return true;
                }
                return false;
            }
        }

    }
}
