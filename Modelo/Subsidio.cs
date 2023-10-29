using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class Subsidio
    {
        private int id;
        private int idEmpleado;
        private DateTime fechaInicio;
        private DateTime fechaFin;

        [Required(ErrorMessage = "El ID es requerido")]
        public int ID { get => id; set => id = value; }
        [Required(ErrorMessage = "El ID del empleado es requerido")]
        public int IDEmpleado { get => idEmpleado; set => idEmpleado = value; }
        [Required(ErrorMessage = "La fecha de inicio es requerida")]
        [DataType(DataType.Date)]
        public DateTime FechaInicio { get => fechaInicio;set => fechaInicio = value; }   [Required(ErrorMessage = "La fecha de inicio es requerida")]
        [DataType(DataType.Date)]
        public DateTime FechaFin { get => fechaFin;set => fechaFin = value; }
    }
}
