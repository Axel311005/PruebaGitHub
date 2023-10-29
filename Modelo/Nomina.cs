using System.ComponentModel.DataAnnotations;

namespace Modelo
{
    public class Nomina : IDeduccion, IIngresos, ICargos
    {
        private int idNomina;
        private DateTime fecha;
        private DateTime fechaFin;
        private decimal ingresoOrdinario;
        private decimal salarioPorDia;
        private decimal horaExtra;
        private decimal totalIngresos;
        private decimal viaticoTransporte;
        private decimal viaticoAlimentacion;
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


        [Required(ErrorMessage = "Empleado requerido.")]
        public Empleado Empleado { get; set; }

        [Required(ErrorMessage = "El ID es requerido")]
        public int IDNomina { get => idNomina; set => idNomina = value; }

        [Required(ErrorMessage = "La fecha es requerida")]
        [DataType(DataType.Date)]
        public DateTime Fecha { get => fecha; set => fecha = value; }
        [Required(ErrorMessage = "La fecha fin de la nomina es requerida")]
        [DataType(DataType.Date)]
        public DateTime FechaFin { get => fechaFin; set => fechaFin = value; }

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

        [Required(ErrorMessage = "El viático de transporte es requerido")]
        [Range(0, Double.MaxValue, ErrorMessage = "El viático transporte debe ser mayor o igual a 0")]
        public decimal ViaticoTransporte { get => viaticoTransporte; set => viaticoTransporte = value; }
        [Required(ErrorMessage = "El viático de alimentacion es requerido")]
        [Range(0, Double.MaxValue, ErrorMessage = "El viático alimentacion debe ser mayor o igual a 0")]
        public decimal ViaticoAlimentacion { get => viaticoAlimentacion; set => viaticoAlimentacion = value; }

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

    
        public int cantidadEmpleados { get; set; }
  

        public decimal CalcularComisiones()
        {
            return Comisiones;
        }

        public decimal CalcularDepreciacionVehiculo()
        {
            return DepreciacionVehiculo;
        }

        public decimal CalcularEmbargos()
        {
            return Embargos;
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
            return 0;
        }

        public decimal CalcularINSS()
        {
           return CalcularTotalIngresos() * 0.07m;
        }

        public decimal CalcularPrestamos()
        {
            return Prestamos;
        }

        public decimal CalcularRiesgoLaboral(bool enSubsidio, int diasSubsidio)
        {

            if (enSubsidio)
            {
                decimal porcentajeRiesgoLaboral = 0.04m;
                RiesgoLaboral = CalcularTotalIngresos() * porcentajeRiesgoLaboral * diasSubsidio;
            }
            else
            {
                RiesgoLaboral = 0.0m;
            }

            return RiesgoLaboral;
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
            return Empleado.SalarioOrdinario + CalcularHoraExtra() + CalcularViaticoAlimentacion() + CalcularViaticoTransporte() + CalcularComisiones() + RiesgoLaboral + CalcularNocturnidad();
        }

        public decimal CalcularViaticoAlimentacion()
        {
            return ViaticoAlimentacion;
        }

        public decimal CalcularIngresoAnual()
        {
            return (CalcularTotalIngresos()) * 12;
        }


        public decimal CalcularNocturnidad()
        {
            return (CalcularSalarioPorHora()/7) * 2;
        }

        public decimal CalcularSalarioPorHora()
        {
            return SalarioPorDia / 8;
        }

        public decimal CalcularTotalDeducciones()
        {
            return CalcularINSS() + CalcularImpuestoRenta()  + CalcularPrestamos() + CalcularEmbargos();
        }

        public decimal CalcularViaticoTransporte()
        {
            return ViaticoTransporte;
        }

        public decimal CalcularINATEC()
        {
            return CalcularTotalIngresos() * 0.02M;
        }

        public decimal CalcularINSSPatronal()
        {
            if (cantidadEmpleados > 50)
                return CalcularTotalIngresos() * 0.225M;
            else
                return CalcularTotalIngresos() * 0.215M;
        }

        public decimal MostrarVacacionesAcumuladas()
        {
            decimal tasaAcumulacionPorQuincena = 1.25m;

            // Calcula la cantidad de días trabajados
            int diasTrabajados = CalcularDiasEntreFechas(Empleado.FechaContratacion, FechaFin);

            int quincenasTrabajadas = diasTrabajados / 15; 

            decimal vacacionesAcumuladas = quincenasTrabajadas * tasaAcumulacionPorQuincena;

            return vacacionesAcumuladas;
        }

        public decimal MostrarAguinaldoAcmulado()
        {
            decimal tasaAcumulacionPorDia = 0.083m;

            // Calcula la cantidad de días trabajados desde la fecha de contratación hasta el final del período de pago
            int diasTrabajados = CalcularDiasEntreFechas(Empleado.FechaContratacion, fechaFin);

            // Calcula el aguinaldo acumulado
            decimal aguinaldoAcumulado = diasTrabajados * tasaAcumulacionPorDia;

            return aguinaldoAcumulado;
        }

        public decimal calcularPagoIndenmizacion()
        {
            decimal salarioMes = Empleado.SalarioOrdinario / 30;
            int añosTrabajados = CalcularAñosTrabajados(Empleado.FechaContratacion, Empleado.FechaCierreContrato);

            // Reglas de cálculo de la indemnización
            decimal indemnizacion = 0.0m;
            if (añosTrabajados <= 3)
            {
                indemnizacion = salarioMes * añosTrabajados;
            }
            else if (añosTrabajados <= 5)
            {
                indemnizacion = salarioMes * 3 + (salarioMes * 20 * (añosTrabajados - 3));
            }
            else
            {
                indemnizacion = salarioMes * 3 + (salarioMes * 20 * 2);
            }

            return indemnizacion;
        }

        private int CalcularAñosTrabajados(DateTime fechaContratacion, DateTime fechaFIn)
        {
            TimeSpan diferencia = fechaFIn - fechaContratacion;
            int añosTrabajados = diferencia.Days / 365; // Asumiendo un año de 365 días
            return añosTrabajados;
        }

        public int CalcularDiasEntreFechas(DateTime fechaInicio, DateTime fechaFin)
        {
            TimeSpan diferencia = fechaFin - fechaInicio;
            int dias = Math.Abs(diferencia.Days);

            return dias;
        }

    }
}
