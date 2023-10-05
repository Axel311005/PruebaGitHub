using Practica2;

double valor1 = 0;
double valor2 = 0;  
double valor3 = 0;

Console.WriteLine("Num 1");
valor1=Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Num 2");
valor2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Num 3");
valor3 = Convert.ToDouble(Console.ReadLine());

Suma s = new Suma();

s.Sumas(valor1, valor2, valor3);    
s.Max(valor1,valor2, valor3);   
s.Min(valor1,valor2, valor3);
s.Imprimir();
