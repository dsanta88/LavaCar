using LavaCar.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LavaCar.Client.Helpers
{
    public class Generico
    {
        public List<EstadoAuxiliar> getEstados()
        {
            List<EstadoAuxiliar> lstEstados = new List<EstadoAuxiliar>();

            lstEstados = new List<EstadoAuxiliar>
      {
        new EstadoAuxiliar {  Codigo = "A", Descripcion= "ACTIVO" },
        new EstadoAuxiliar { Codigo = "I", Descripcion = "INACTIVO" }
      };

            return lstEstados;
        }
    }
}
