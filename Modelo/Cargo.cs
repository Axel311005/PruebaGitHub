
using System.ComponentModel.DataAnnotations;

namespace Modelo
{
    public class Cargo
    {
        private int idCargo;
        private string nombre;
        private bool aplicaComisiones;
        private bool aplicaRiesgoLaboral;

        [Required()]
        public int IDCargo { get => idCargo; set => idCargo = value; }
        [Required(ErrorMessage = "El nombre del cargo es requerido.")]
        public string Nombre{ get => nombre; set => nombre = value; }
        [Required(ErrorMessage = "Especificar si el cargo se le aplican comisiones es requerido.")]
        public bool AplicaComisiones{ get => aplicaComisiones; set => aplicaComisiones = value; }
        [Required(ErrorMessage = "Especificar si el cargo se le aplican Riesgo laboral es requerido.")]
        public bool AplicaRiesgoLaboral{ get => aplicaRiesgoLaboral; set => aplicaRiesgoLaboral = value; }
    }
}