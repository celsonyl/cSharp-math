using System;
using System.Collections.Generic;
using System.Text;

namespace Primeiro
{
    class Calculadora{

        public static void Triple(ref int x)
        {
            x = x * 3;
            
        }
        public static void Triple(int origin,out int result)
        {
            result = origin * 3;

        }

        public static int Sum(params int[] numbers)
        {
            int sum = 0;
            for(int i = 0; i < numbers.Length; i++){
                sum += numbers[i];
            }
            return sum;
        }
       
        public static double pi = 3.14;
        public static double Circunferencia(double r)
        {
           return 2.0 * pi * r;
        }

        public static double Volume(double r)
        {
            return 4.0 / 3.0 * pi * Math.Pow(r, 3.0);
        }
    }
}
