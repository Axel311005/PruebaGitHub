using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica1Sist4
{
    public class Notas : IPrincipal
    {
        //[RegularExpression(@"^[^a-zA-Z]*$", ErrorMessage = "No se permiten letras.")]

        //[RegularExpression("^[0-9]+$", ErrorMessage = "Solo se permiten números")]

        [RegularExpression(@"^[^a-zA-Z]*$", ErrorMessage = "No se permiten letras.")]
        public double Nota1 { get; set; }
        [RegularExpression("^[0-9]+$", ErrorMessage = "Solo se permiten números")]
        public string nombreEstudiante { get; set; }
        [RegularExpression(@"^[^a-zA-Z]*$", ErrorMessage = "No se permiten letras.")]
        public double Nota2 { get; set; }
        [RegularExpression(@"^[^a-zA-Z]*$", ErrorMessage = "No se permiten letras.")]
        public double Nota3 { get; set; }
        [RegularExpression(@"^[^a-zA-Z]*$", ErrorMessage = "No se permiten letras.")]
        public double Nota4 { get; set; }

        public void Imprimir()
        {
            Console.WriteLine($"{nombreEstudiante}\nNota 1:{Nota1} \nNota 2:{Nota2}" +
                $"\nNota 3:{Nota3} \nNota 4:{Nota4} \nPromedio:{Promedio()}");

        }

        

        public double Promedio()
        {
           return (Nota1+Nota2+Nota3+Nota4)/4;
        }
    }
}
