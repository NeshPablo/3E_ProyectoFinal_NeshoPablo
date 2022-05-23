using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _3E_ProyectoFinal_NeshoPablo.Clases
{
    public class HistorialPaciente
    {
        public string IdConsulta { get; set; }
        public string Nit { get; set; }
        List<AgendaCitas> FechayHoraCitas { get; set; }
        public string Temperatura { get; set; }
        public string Presion { get; set; }
        List<Sintomas> Sintomas { get; set; }
        public string Diagnostico { get; set; }
        public string Tratamiento { get; set; }
        public string Receta { get; set; }
        public string  ProxVisita { get; set; }
        public string CostoConsulta { get; set; }
        List<HistorialPaciente> Imagenes { get; set; }

    }
}