using Meu_projeto.Enum;
using System;
using System.Collections.Generic;
using System.Text;

namespace Meu_projeto
{
    class Conta
    {
        

        private string Nome { get; set; }
        private double Credito { get; set; }
        private double Saldo { get; set; }
        private TipoConta TipoConta { get; set; }

        public Conta(TipoConta tipoConta, string Nome, double Credito, double Saldo)
        {
            this.TipoConta = tipoConta;
            this.Nome = Nome;
            this.Credito = Credito;
            this.Saldo = Saldo;
        }

        

        public bool Sacar(double valorSaque)
        {
            if (this.Saldo - valorSaque < this.Credito * -1) return false;
            this.Saldo -= valorSaque;
            Console.WriteLine("Saldo atual de {0} é {1}", this.Nome, this.Saldo);
            return true;
        }
        public void Depositar(double valorDepositado)
        {
            this.Saldo += valorDepositado;
            Console.WriteLine("Valor depositado! Novo saldo de {0} é {1}", this.Nome, this.Saldo);
        }
        public void Transferir(double valorTransf, Conta conta)
        {
            if (this.Sacar(valorTransf))
            {
                conta.Depositar(valorTransf);
            }
        }
        public override string ToString()
        {
            string retornar = "";
            retornar += "Tipo de conta: " + this.TipoConta;
            retornar += "\n Nome: " + this.Nome;
            retornar += "\n Saldo: " + this.Saldo;
            retornar += "\n Credito: " + this.Credito;
            return retornar;
        }
        
        
    }
}
