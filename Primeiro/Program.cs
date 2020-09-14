using System;
using System.Globalization;
using System.Numerics;

namespace Primeiro
{
    class Program
    {

        static void Main(string[] args)
        {



            //Nullable
            double? x = null;
            double? y = 10;

            double a = x ?? 5;
            double b = y ?? 5;

            Console.WriteLine(a);
            Console.WriteLine(b);
            /*
            double? x = null;
            double? y = 10.0;
            Console.WriteLine(y.GetValueOrDefault());

            Console.WriteLine(x.HasValue);
            Console.WriteLine(y.HasValue);
            if (x.HasValue)
                Console.WriteLine(x.Value);
            else
                Console.WriteLine("X é nullo");
            if (y.HasValue)
                Console.WriteLine(y.Value);
            else
            Console.WriteLine("Y é nullo");
            */




            //INSTANCIANDO STRUCT
            /*
            Point p;
            p.X = 10;
            p.Y = 30;
            Console.WriteLine(p);
             */


            /* CALCULADORA
            Console.WriteLine("Entre o valor do raio: ");
            double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double circ = Calculadora.Circunferencia(raio);
            double volume = Calculadora.Volume(raio);

            Console.WriteLine("Circunferencia: " + circ.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Volume: " + volume.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Valor de PI: " + Calculadora.pi.ToString("F2", CultureInfo.InvariantCulture));
            */




            // --------------------------EXERCICIO SAQUE----------------------------------------
            /*
            Console.WriteLine("Entre com o numero da Conta: ");
            int numeroConta = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Entre com o titular da Conta: ");
            String titularConta = Console.ReadLine();
            Console.WriteLine("Haverá depósito Inicial? (s/n)");
            String verify = Console.ReadLine();
            if(verify == "s" || verify=="S")
            {
                Console.WriteLine("Entre com o valor do Depósito: ");
                Double deposito = Double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                Conta p = new Conta(numeroConta,titularConta,deposito);
                p.exibirDados();

                Console.WriteLine("Entre um valor para Depósito: ");
                Double quantidade = Double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                p.AdicionaSaldo(quantidade);

                Console.WriteLine("Dados Atualizados!\n");
                p.exibirDados();

                Console.WriteLine("Entre com o valor para saque: ");
                quantidade = Double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                p.RetiraSaldo(quantidade);
                Console.WriteLine("Dados Atualizados!\n");
                p.exibirDados();
            }
            else if(verify == "n" || verify=="N"){
                Conta p = new Conta(numeroConta, titularConta);
                p.exibirDados();

                Console.WriteLine("Entre um valor para Depósito: ");
                Double quantidade = Double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                p.AdicionaSaldo(quantidade);

                Console.WriteLine("Dados Atualizados!\n");
                p.exibirDados();

                Console.WriteLine("Entre com o valor para saque: ");
                quantidade = Double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                p.RetiraSaldo(quantidade);
                Console.WriteLine("Dados Atualizados!\n");
                p.exibirDados();
            }
            else
            {
                Console.WriteLine("Tecla inválida!");
            }

            */



            /*
             * -------------------------EXERCICIO CALCULAR AREA TRIANGULO-------------------------------------
            Triangulo x, y;

            x = new Triangulo();
            y = new Triangulo();
            
            Console.WriteLine("Entre com as medidas do triangulo X!");
             x.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
             x.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
             x.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Entre com as medidas do triangulo Y!");
            y.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double areaX = x.Area();
            double areaY = y.Area();
          
            Console.WriteLine("Area de x = " + areaX.ToString("F4", CultureInfo.InvariantCulture));
            Console.WriteLine("Area de Y = " + areaY.ToString("F4", CultureInfo.InvariantCulture));

            if (areaX == areaY)
            {
               Console.WriteLine("As duas áreas são iguais!");
            }else if(areaX > areaY){
                Console.WriteLine("Maior área: X ");
            }else {
                Console.WriteLine("Maior área: Y ");
            }
            */


        }
    }
}
