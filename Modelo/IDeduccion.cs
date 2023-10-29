using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public interface IDeduccion
    {
        decimal CalcularINSS();
        decimal CalcularImpuestoRenta();
        decimal CalcularPrestamos();
        decimal CalcularEmbargos();
        decimal CalcularSalarioNeto();

        decimal CalcularTotalDeducciones();

    }

}
