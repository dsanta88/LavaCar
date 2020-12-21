using System;
using System.Collections.Generic;
using System.Text;

namespace LavaCar.Shared
{
   public class LogEvento
    {
        public int Id { get; set; }
        public int UsuarioId { get; set; }
        public DateTime Fecha { get; set; }
        public string Mensaje { get; set; }

        public string Fuente { get; set; }
        public string Seguimiento { get; set; }
        public string Tipo { get; set; }
        public string Campo1 { get; set; }
        public string Campo2 { get; set; }
        public string Campo3 { get; set; }
    }
}
