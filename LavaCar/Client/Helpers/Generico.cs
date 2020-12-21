using LavaCar.Shared;
using System;
using System.Collections.Generic;


namespace LavaCar.Client.Helpers
{
    public class Generico
    {
        public List<EstadoAuxiliar> getEstados()
        {
            List<EstadoAuxiliar> lst = new List<EstadoAuxiliar>();

            lst = new List<EstadoAuxiliar>
        {
           new EstadoAuxiliar {  Codigo = "A", Descripcion= "ACTIVO" },
            new EstadoAuxiliar { Codigo = "I", Descripcion = "INACTIVO" }
         };

            return lst;
        }


        public List<Genero> getGeneros()
        {
            List<Genero> lst = new List<Genero>();

            lst = new List<Genero>
        {
            new Genero {  Codigo = "M", Nombre= "MASCULINO" },
            new Genero { Codigo = "F", Nombre = "FEMENINO" }
         };

            return lst;
        }


        public List<Perfil> getPerfiles()
        {
            List<Perfil> lst = new List<Perfil>();

            lst = new List<Perfil>
        {
            new Perfil {  Codigo = 1, Descripcion= "ADMIN-GENERAL" },
            new Perfil { Codigo = 2, Descripcion = "ADMIN-SEDE" },
             new Perfil { Codigo = 3, Descripcion = "EMPLEADO" },
              new Perfil { Codigo = 4, Descripcion = "CLIENTE" }
         };

            return lst;
        }
    }
}
