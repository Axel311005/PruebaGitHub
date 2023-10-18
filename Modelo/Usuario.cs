using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class Usuario
    {
        private int id;
        private string nombre;
        private string segundoNombre;
        private string primerApellido;
        private string segundoApellido;
        private string nombre_usuario;
        private string password;
        private string correo_electronico;
        private DateTime fechaNac;
        private DateTime fechaRegistro;
        private DateTime ultimoAcceso;
        private int idRol;

        [Required(ErrorMessage = "El ID es requerido")]
        public int ID {get;set;}

        [Required(ErrorMessage ="El nombre es requerido.")]
        [RegularExpression(@"^[A-Za-z]+$", ErrorMessage = "El nombre debe contener solo letras.")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "El nombre debe tener entre 3 y 50 caracteres.")]
        public string Nombre { get; set; }

        [Required(ErrorMessage = "El segundo nombre es requerido.")]
        [RegularExpression(@"^[A-Za-z]+$", ErrorMessage = "El segundo nombre debe contener solo letras.")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "El segundo nombre debe tener entre 3 y 50 caracteres.")]
        public string SegundoNombre { get; set; }


        [Required(ErrorMessage = "El primer apellido es requerido.")]
        [RegularExpression(@"^[A-Za-z]+$", ErrorMessage = "El primer apellido debe contener solo letras.")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "El primer apellido debe tener entre 3 y 50 caracteres.")]
        public string PrimerApellido { get; set; }

        [Required(ErrorMessage = "El segundo apellido es requerido.")]
        [RegularExpression(@"^[A-Za-z]+$", ErrorMessage = "El segundo apellido debe contener solo letras.")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "El segundo apellido debe tener entre 3 y 50 caracteres.")]
        public string SegundoApellido { get; set; }

        [Required(ErrorMessage = "El nombre de usuario es requerido.")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "El nombre de usuario debe tener entre 3 y 50 caracteres.")]
        public string NombreUsuario { get; set; }

        [Required(ErrorMessage = "La contraseña es requerida.")]
        [StringLength(50, MinimumLength = 8, ErrorMessage = "La contraseña debe tener al menos 8 caracteres.")]
        public string Password { get; set; }

        [Required(ErrorMessage = "El correo electrónico es requerido.")]
        [EmailAddress(ErrorMessage = "El correo electrónico no es válido.")]
        [StringLength(100, ErrorMessage = "El correo electrónico debe tener como máximo 100 caracteres.")]
        public string CorreoElectronico { get; set; }

        [Required(ErrorMessage = "La fecha de nacimiento es requerida.")]
        [DataType(DataType.Date)]
        public DateTime FechaNac { get; set; }

        public DateTime FechaRegistro { get; set; }

        public DateTime UltimoAcceso { get; set; }

        [Required(ErrorMessage = "El ID de rol es requerido.")]
        public int IdRol { get; set; }
    }
}
