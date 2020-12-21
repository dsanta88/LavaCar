
namespace LavaCar.Client
{
    public class ServicioSingleton
    {
        public int UsuarioId { get; set; }
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
            UsuarioId = 27;
            Nombre = "DAVID SANTA";
            Email = "";
            EmpresaId = 22;
            SedeId = 11;
            EmpresaNombre = "";
            EmpresaLogo = "";
            IsLogueado = false;
            PerfilCodigo = 1;
        }
    }
}
