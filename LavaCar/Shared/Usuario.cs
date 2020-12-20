using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace LavaCar.Shared
{
   public class Usuario
    {
        public int Id { get; set; }

        public int EmpresaId { get; set; }
        public int SedeId { get; set; }
        public int PerfilCodigo { get; set; }
        public string NombreCompleto { get; set; }
        public string Email { get; set; }
        public string Clave { get; set; }
        public string Identificacion { get; set; }
        public string Sexo { get; set; }
        public string Telefono { get; set; }
        public string Celular { get; set; }
        public string Direccion { get; set; }
        public string Observacion { get; set; }
        public string FotoUrl { get; set; }

        public string Estado { get; set; }
        public DateTime FechaRegistro { get; set; }


        [NotMapped]
        public string SedeNombre { get; set; }
        [NotMapped]
        public string PerfilNombre { get; set; }
    }
}
