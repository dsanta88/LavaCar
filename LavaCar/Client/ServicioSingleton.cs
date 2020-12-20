﻿
namespace LavaCar.Client
{
    public class ServicioSingleton
    {
        public int EmpleadoId { get; set; }
        public string Nombre { get; set; }

        public string Email { get; set; }

        public int EmpresaId { get; set; }
        public int SedeId { get; set; }

        public string EmpresaNombre { get; set; }
        public string EmpresaLogo { get; set; }

        public bool IsLogueado { get; set; }

        public int PerfilCodigo { get; set; }

        public ServicioSingleton()
        {
            EmpleadoId = 0;
            Nombre = "";
            Email = "";
            EmpresaId = 3;
            SedeId = 1;
            EmpresaNombre = "";
            EmpresaLogo = "";
            IsLogueado = false;
            PerfilCodigo = 1;
        }
    }
}
