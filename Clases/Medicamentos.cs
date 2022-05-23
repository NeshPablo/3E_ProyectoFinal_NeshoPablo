using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _3E_ProyectoFinal_NeshoPablo.Clases
{
    public class Medicamentos
    {
        public string CodigoMedicamento { get; set; }
        public string Ingredientes { get; set; }
        public string Proveedor { get; set; }
        List<Medicamentos> EnfermedadesaTratar { get; set; }
    }
}