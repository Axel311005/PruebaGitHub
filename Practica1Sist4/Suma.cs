using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica1Sist4
{
    public class Suma : IPrincipal
    {

        public double num1;
        public double num2;
        public double num3;
        public void Imprimir()
        {
            Console.WriteLine($"Num 1:{num1} \nNum 2:{num2}" +
                $"\nNum 3:{num3}\nSuma:{Promedio()}");
        }

        public double Promedio()
        {
            return num1+num2+num3;  
        }
    }
}
