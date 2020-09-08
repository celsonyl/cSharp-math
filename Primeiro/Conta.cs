using System;
using System.Collections.Generic;
using System.Text;

namespace Primeiro
{
    class Conta{
        public int NumeroConta { get; private set; }
        public String TitularConta { get; private set; }
        public Double Saldo { get; private set; }

        public Conta(int numeroConta,String titularConta,Double saldo)
        {
            this.NumeroConta = numeroConta;
            this.TitularConta = titularConta;
            this.Saldo = saldo;
        }
        public Conta(int numeroConta, String titularConta)
        {
            this.NumeroConta = numeroConta;
            this.TitularConta = titularConta;
        }

        public void AdicionaSaldo(double quantidade)
        {
            Saldo += quantidade;
        }
        public void RetiraSaldo(double quantidade)
        {
            Saldo -= quantidade;
            Saldo = Saldo - 5;
        }
        public void exibirDados()
        {
            
            Console.WriteLine("Conta: " + NumeroConta.ToString() + ","+
                " Titular Da conta: " + TitularConta.ToString() +  ","+
                " Saldo: " + Saldo.ToString()+"R$\n");
        }

    }
}
