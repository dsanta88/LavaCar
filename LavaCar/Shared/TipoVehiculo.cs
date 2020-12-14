using System;
using System.Collections.Generic;
using System.Text;

namespace LavaCar.Shared
{
  public  class TipoVehiculo
    {
        public int Id { get; set; }

        public int SedeId { get; set; }
        public string Nombre { get; set; }
        public string ImagenUrl { get; set; }
        public string Estado { get; set; }
    }
}
