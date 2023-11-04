﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public interface IIngresos
    {     

        decimal CalcularSalarioPorDia();
        decimal CalcularHoraExtra();
        decimal CalcularSalarioPorHora();
        decimal CalcularTotalIngresos();
        decimal CalcularViaticoAlimentacion();
        decimal CalcularViaticoTransporte();
        decimal CalcularDepreciacionVehiculo();
        decimal CalcularRiesgoLaboral();
        decimal CalcularNocturnidad();
        decimal CalcularComisiones();
        decimal CalcularIngresoAnual();
        
    }
}
