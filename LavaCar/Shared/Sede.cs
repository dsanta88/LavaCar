using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace LavaCar.Shared
{

    public class Sede
    {
        public int Id { get; set; }
        public int EmpresaId { get; set; }

        [NotMapped]
        public string EmpresaNombre { get; set; }
        public string Nombre { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public string Celular { get; set; }
        public string Email { get; set; }

        public string Estado { get; set; }
    }
}
