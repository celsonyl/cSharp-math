using System;
using System.Globalization;
using System.Numerics;

namespace Primeiro
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] vect = new string[] { "Maria", "BOBA", "XERA CU" };
            foreach(string obj in vect)
            {
                Console.WriteLine(obj);
            }


            /*OUT IN ,REF
            int s1 = Calculadora.Sum(2,3,4);
            int s2 = Calculadora.Sum(2, 3, 4,7,9,6,4,10);
            Console.WriteLine(s2);

            int a = 10;
            int triple;
            //out in
            Calculadora.Triple(a,out triple);
            Console.WriteLine(triple);

            Calculadora.Triple(ref a);
            Console.WriteLine(a);
            */

            //EX ESTUDANTE ALUGAR QUARTOS------------------------------------------------------------------------------------
            /*
                Estudante[] vetor = new Estudante[10];
                Console.WriteLine("Digite a quantidade de quartos serão alugados!");
                int n = int.Parse(Console.ReadLine());

                for(int i = 0; i < n; i++)
                {
                    Console.WriteLine();
                    Console.WriteLine($"Aluguel #{i+1}:");
                    Console.WriteLine("Digite seu Nome:");
                    string nome = Console.ReadLine();
                    Console.WriteLine("Digite seu E-mail");
                    string email = Console.ReadLine();
                    Console.WriteLine("Quarto:");
                    int q = int.Parse(Console.ReadLine());
                    vetor[q] = new Estudante(nome,email );

                }
                Console.WriteLine();
                Console.WriteLine("Quartos ocupados");
                for(int i = 0; i < 10; i++)
                {
                    if (vetor[i] != null)
                    {
                        Console.WriteLine(i + ":" + vetor[i]);
                    }
                }
            */

            //VETOR TIPO CLASS------------------------------------------------------------------------------------
            /*
            double soma = 0;
            Console.WriteLine("Digite a quantidade de produto!");
            int n = int.Parse(Console.ReadLine());

            Product[] vct = new Product[n];
            for(int i = 0; i < n; i++){
                Console.WriteLine("Digite o NOME e PREÇO dos produtos");
                string name = Console.ReadLine();
                double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                vct[i] = new Product { Name = name, Price = price };
                soma += vct[i].Price;
            }
            double media = soma / n;
            Console.WriteLine("A media dos preços é: " + media.ToString("F2", CultureInfo.InvariantCulture)); 
            */




            //VETORES TIPO STRUCT-------------------------------------------------------------
            /*
            double soma = 0;

            Console.WriteLine("Digite o numero de Pessoas");
            int n = int.Parse(Console.ReadLine());

            double[] vect = new double[n];

            for(int i = 0; i < n; i++){
                vect[i] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                soma += vect[i];
            }
            double media = soma / n;

            Console.WriteLine("A média das alturas é: " + media.ToString("F2", CultureInfo.InvariantCulture));
            */


            //Nullable-----------------------------------------------------------------
            /*
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




            //INSTANCIANDO STRUCT----------------------------------------------------------------------------
            /*
            Point p;
            p.X = 10;
            p.Y = 30;
            Console.WriteLine(p);
             */


            /* CALCULADORA----------------------------------------------------------------------------------------
            Console.WriteLine("Entre o valor do raio: ");
            double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double circ = Calculadora.Circunferencia(raio);
            double volume = Calculadora.Volume(raio);

            Console.WriteLine("Circunferencia: " + circ.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Volume: " + volume.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Valor de PI: " + Calculadora.pi.ToString("F2", CultureInfo.InvariantCulture));
            */




            // --------------------------EXERCICIO SAQUE------------------------------------------------------------
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
