using System;
using System.Collections.Generic;
using System.Text;

namespace Primeiro
{
    class Funcionario {
        public String Nome { get; set; }
        public double Salario { get; private set; }
        public int Id { get; set; }


        public Funcionario(int id,String nome,double salario)
        {
            Id = id;
            Nome = nome;
            Salario = salario;
        }

        public override string ToString()
        {
            return "ID:" + Id + "," + "Nome: "+ Nome + "," + "Salario: " +Salario;
        }

        public void AumentoSalario(double porcentagem)
        {
            Salario += Salario * porcentagem / 100;
        }
    }
}
