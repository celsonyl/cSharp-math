﻿using System;
using System.Globalization;


namespace Primeiro
{
    class Produto{
        private  String _nome;
        public Double Preco { get; private set; }
        public int Quantidade { get; private set; }
        public Produto(){}

        public Produto(String nome,double preco,int quantidade){
            _nome = nome;
            Preco = preco;
            Quantidade = quantidade;
        }
       public String Nome
        {
            get { return _nome; }
            set{
                if (value != null && value.Length > 1)
                {
                    _nome = value;

                }
               }
        }

        public double ValorTotalEmEstoque(){
            return Preco * Quantidade;
        }

        public void AdicionarProdutos(int quantidade){
            Quantidade += quantidade;        
        }
        public void RemoverProdutos(int quantidade)
        {
            Quantidade -= quantidade;
        }

        public override string ToString()
        {
            return _nome + 
                ", $" + Preco.ToString("F2",CultureInfo.InvariantCulture)
                + ", "
                + Quantidade
                + " unidades, Total: $"
                + ValorTotalEmEstoque().ToString("F2",CultureInfo.InvariantCulture);
        }
    }
}
