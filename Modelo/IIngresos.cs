using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public interface IIngresos
    {
        decimal CalcularSalarioPorHora();
        decimal CalcularSalarioPorDia();
        decimal CalcularHoraExtra();
        decimal CalcularTotalIngresos();
        decimal CalcularViatico();
        decimal CalcularDepreciacionVehiculo();
        decimal CalcularRiesgoLaboral();
        decimal CalcularComisiones();
        decimal CalcularIngresoVacaciones();
        decimal CalcularIngresoAnual();
        decimal CalcularINATEC();
        decimal CalcularNocturnidad();
    }
}
