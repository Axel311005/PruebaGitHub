using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Practica2
{
    public class Suma
    {

        public Suma(double Num1, double Num2, double Num3)
        {
            num1 = Num1;
            num2 = Num2;
            num3 = Num3;
        }

        public double num1;
        public double num2;
        public double num3;

        public double Max(double Num1, double Num2, double Num3)
        {
            double max = Num1;

            if (Num2.CompareTo(max) > 0)
            {
                max = Num2;
            }
            if(Num3.CompareTo(max) > 0)
            {
                max = Num3;
            }


           return max;
     
        }

        public double Min(double Num1, double Num2, double Num3)
        {
            double max = Num1;

            if (Num2.CompareTo(max) < 0)
            {
                max = Num2;
            }
            if (Num3.CompareTo(max) < 0)
            {
                max = Num3;
            }


            return max;

        }
        public double Sumas(double Num1, double Num2, double Num3)
        {
            return Num1 + Num2+ Num3;
        }

        public void Imprimir()
        {
            Console.WriteLine($"Suma: {Sumas}\nMaximo: {Max}, \nMinimo: {Min} ");
        }

       
    }
}
