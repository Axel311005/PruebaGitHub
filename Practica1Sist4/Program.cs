

using Practica1Sist4;
using System.Security.Principal;
int n = 0;
double valor1 = 0;
double valor2 = 0;
double valor3 = 0;  
double valor4 = 0;
string nom = "";

Suma pri = new Suma();
Notas pro = new Notas();


//[RegularExpression(@"^[^a-zA-Z]*$", ErrorMessage = "No se permiten letras.")]

//[RegularExpression("^[0-9]+$", ErrorMessage = "Solo se permiten números")]

Console.WriteLine("1.Notas 2.Suma");
n=Convert.ToInt32(Console.ReadLine());

switch (n)
{
    case 1:
    {
            Console.WriteLine("Ingrese el nombre del estudiante");

            nom = Console.ReadLine();
            Console.WriteLine("Ingrese la nota 1");
            valor1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ingrese la nota 2");
            valor2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ingrese la nota 3");
            valor3 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Ingrese la nota 4");
            valor4 = Convert.ToDouble(Console.ReadLine());

            pro.nombreEstudiante = nom;
            pro.Nota1 = valor1;
            pro.Nota2 = valor2;
            pro.Nota3 = valor3;
            pro.Nota4 = valor4;

            pro.Imprimir();
            break;

    }
    case 2:
        {
            Console.WriteLine("Ingrese el valor 1");
            valor1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ingrese el valor 2");
            valor2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ingrese elvalor 3");
            valor3 = Convert.ToDouble(Console.ReadLine());

            pri.num1= valor1;
            pri.num2= valor2;
            pri.num3= valor3;
            pri.Imprimir();
            break;

        }
}