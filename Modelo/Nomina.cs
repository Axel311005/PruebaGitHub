using System.ComponentModel.DataAnnotations;

namespace Modelo
{ 
    public class Nomina : IDeduccion, IIngresos
    {
        private int idNomina;
        private DateTime fecha;
        private decimal ingresoOrdinario;
        private decimal salarioPorDia;
        private decimal horaExtra;
        private decimal totalIngresos;
        private decimal viatico;
        private decimal depreciacionVehiculo;
        private decimal riesgoLaboral;
        private decimal comisiones;
        private decimal ingresoVacaciones;
        private decimal _INSS;
        private decimal impuestoRenta;
        private decimal prestamos;
        private decimal embargos;
        private decimal salarioNeto;
        private int idEmpleado;
        public static decimal tarifaHoraExtra { get; set; }
        public static decimal tarifaComisiones { get; set; }
        

        private Empleado Empleado { get; set; }

        [Required(ErrorMessage ="El ID es requerido")]
        public int IDNomina { get => idNomina; set => idNomina = value; }

        [Required(ErrorMessage = "La fecha es requerida")]
        [DataType(DataType.Date)]
        public DateTime Fecha { get => fecha; set => fecha = value; }

        [Required(ErrorMessage = "El ingreso ordinario es requerido")]
        [Range(0, Double.MaxValue, ErrorMessage = "El ingreso ordinario debe ser mayor o igual a 0")]
        public decimal IngresoOrdinario { get => ingresoOrdinario; set => ingresoOrdinario = value; }

        [Required(ErrorMessage = "El salario por día es requerido")]
        [Range(0, Double.MaxValue, ErrorMessage = "El salario por día debe ser mayor o igual a 0")]
        public decimal SalarioPorDia { get => salarioPorDia; set => salarioPorDia = value; }

        [Required(ErrorMessage = "La hora extra es requerida")]
        [Range(0, Double.MaxValue, ErrorMessage = "La hora extra debe ser mayor o igual a 0")]
        public decimal HoraExtra { get => horaExtra; set => horaExtra = value; }

        [Required(ErrorMessage = "El total de ingresos es requerido")]
        [Range(0, Double.MaxValue, ErrorMessage = "El total de ingresos debe ser mayor o igual a 0")]
        public decimal TotalIngresos { get => totalIngresos; set => totalIngresos = value; }

        [Required(ErrorMessage = "El viático es requerido")]
        [Range(0, Double.MaxValue, ErrorMessage = "El viático debe ser mayor o igual a 0")]
        public decimal Viatico { get => viatico; set => viatico = value; }

        [Required(ErrorMessage = "La depreciación de vehículo es requerida")]
        [Range(0, Double.MaxValue, ErrorMessage = "La depreciación de vehículo debe ser mayor o igual a 0")]
        public decimal DepreciacionVehiculo { get => depreciacionVehiculo; set => depreciacionVehiculo = value; }

        [Required(ErrorMessage = "El pago por riesgo laboral es requerido")]
        [Range(0, Double.MaxValue, ErrorMessage = "El pago por riesgo laboral debe ser mayor o igual a 0")]
        public decimal RiesgoLaboral { get => riesgoLaboral; set => riesgoLaboral = value; }

        [Required(ErrorMessage = "El pago de comisiones es requerido")]
        [Range(0, Double.MaxValue, ErrorMessage = "El pago de comisiones debe ser mayor o igual a 0")]
        public decimal Comisiones { get => comisiones; set => comisiones = value; }

        [Required(ErrorMessage = "El ingreso por vacaciones es requerido")]
        [Range(0, Double.MaxValue, ErrorMessage = "El ingreso por vacaciones debe ser mayor o igual a 0")]
        public decimal IngresoVacaciones { get => ingresoVacaciones; set => ingresoVacaciones = value; }

        [Required(ErrorMessage = "El INSS es requerido")]
        [Range(0, Double.MaxValue, ErrorMessage = "El INSS debe ser mayor o igual a 0")]
        public decimal INSS { get => _INSS; set => _INSS = value; }

        [Required(ErrorMessage = "El impuesto sobre la renta es requerido")]
        [Range(0, Double.MaxValue, ErrorMessage = "El impuesto sobre la renta debe ser mayor o igual a 0")]
        public decimal ImpuestoRenta { get => impuestoRenta; set => impuestoRenta = value; }

        [Required(ErrorMessage = "El pago de préstamos es requerido")]
        [Range(0, Double.MaxValue, ErrorMessage = "El pago de préstamos debe ser mayor o igual a 0")]
        public decimal Prestamos { get => prestamos; set => prestamos = value; }

        [Required(ErrorMessage = "El monto de embargos es requerido")]
        [Range(0, Double.MaxValue, ErrorMessage = "El monto de embargos debe ser mayor o igual a 0")]
        public decimal Embargos { get => embargos; set => embargos = value; }

        [Required(ErrorMessage = "El salario neto es requerido")]
        [Range(0, Double.MaxValue, ErrorMessage = "El salario neto debe ser mayor o igual a 0")]
        public decimal SalarioNeto { get => salarioNeto; set => salarioNeto = value; }

        [Required(ErrorMessage = "El ID del empleado es requerido")]
        public int IDEmpleado { get => idEmpleado; set => idEmpleado = value; }

        [Required(ErrorMessage = "La cantidad de días de vacaciones tomados es requerida")]
        [Range(0, Double.MaxValue, ErrorMessage = "La cantidad de días de vacaciones tomados debe ser mayor o igual a 0")]
        public int DiasVacacionesTomados { get; set; }

        public decimal CalcularComisiones()
        {
            return Comisiones * tarifaComisiones;
        }

        public decimal CalcularDepreciacionVehiculo()
        {
            throw new NotImplementedException();
        }

        public decimal CalcularEmbargos()
        {
            throw new NotImplementedException();
        }
        public decimal CalcularHoraExtra()
        {
            if (HoraExtra != 0)
            {
                return CalcularSalarioPorHora() * 2 * HoraExtra;
            }
            else
            {
                return 0;
            }
        }

        public decimal CalcularImpuestoRenta()
        {
            decimal ingresoAnual = CalcularIngresoAnual();

            decimal IR = 0; 

            if (ingresoAnual > 500000.01m)
            {
                decimal calculo3 = (ingresoAnual - 500000m) * 0.30m;
                IR = (calculo3 + 82500m) / 12;
            }
            else if (ingresoAnual >= 350000.01m)
            {
                decimal calculo2 = (ingresoAnual - 350000m) * 0.25m;
                IR = (calculo2 + 45000m) / 12;
            }
            else if (ingresoAnual >= 200000.01m)
            {
                decimal calculo1 = (ingresoAnual - 200000m) * 0.2m;
                IR = (calculo1 + 15000m) / 12;
            }
            else if (ingresoAnual >= 100000.01m)
            {
                decimal sobreexceso1 = 100000m;
                decimal totalDeducir1 = ingresoAnual - sobreexceso1;
                IR = (totalDeducir1 * 0.15m) / 12;
            }

            return IR/2;//De forma quincenal
        }

        public decimal CalcularIngresoVacaciones()
        {
            throw new NotImplementedException();
        }

        public decimal CalcularINSS()
        {
           return CalcularTotalIngresos() * 0.07m;
        }

        public decimal CalcularPrestamos()
        {
            throw new NotImplementedException();
        }

        public decimal CalcularRiesgoLaboral()
        {
            return SalarioPorDia * 0.02m;
        }

        public decimal CalcularSalarioNeto()
        {
            return CalcularTotalIngresos() - CalcularTotalDeducciones();
        }

        public decimal CalcularSalarioPorDia()
        {
            return Empleado.SalarioOrdinario / 30;
        }

        public decimal CalcularTotalIngresos()
        {
            return IngresoOrdinario + CalcularHoraExtra() + Viatico + Comisiones + CalcularIngresoVacaciones();
        }

        public decimal CalcularViatico()
        {
            throw new NotImplementedException();
        }

        public decimal CalcularIngresoAnual()
        {
            return (CalcularTotalIngresos()) * 12;
        }

        public decimal CalcularINATEC()
        {
            return CalcularTotalIngresos() * 0.02m;
        }

        public decimal CalcularINSSPatronal()
        {
            throw new NotImplementedException();
        }

        public decimal CalcularNocturnidad()
        {
            decimal nocturnidad = Empleado.SalarioOrdinario * 0.2m;
            return nocturnidad;
        }

        public decimal CalcularSalarioPorHora()
        {
            return SalarioPorDia / 8;
        }

        public decimal CalcularTotalDeducciones()
        {
            decimal totalDeducciones = INSS + ImpuestoRenta + Prestamos + Embargos;
            return totalDeducciones;
        }
    }
}
