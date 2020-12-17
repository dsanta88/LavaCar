using System;
using System.Collections.Generic;
using System.Text;

namespace LavaCar.Shared
{
  public  class Servicio
    {
        public int Id { get; set; }

        public int TipoVehiculoId { get; set; }
        public string Nombre { get; set; }
        public decimal Valor { get; set; }
        public string Descripcion { get; set; }
        public string ImagenUrl { get; set; }
        public string Estado { get; set; }
    }
}
