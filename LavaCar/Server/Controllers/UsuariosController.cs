using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using LavaCar.Server.Data;
using LavaCar.Shared;

namespace LavaCar.Server.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class UsuariosController : ControllerBase
    {
        private readonly LavaCarDbContext db;

        public UsuariosController(LavaCarDbContext context)
        {
            db = context;
        }

        [HttpGet("[action]/{sedeId}/{perfilCodigo}")]
        public IActionResult GetUsuarioXSede(int sedeId, int perfilCodigo)
        {
            Response response = new Response();
            try
            {

                var query = (from user in db.Usuarios
                             join sed in db.Sedes on user.SedeId equals sed.Id
                             join perf in db.Perfiles on user.PerfilCodigo equals perf.Codigo
                             where sed.Id== sedeId && user.PerfilCodigo== perfilCodigo
                             orderby user.NombreCompleto
                             select new
                             {
                                 user.Id,
                                 perfilNombre=perf.Nombre,
                                 sedeNombre=sed.Nombre,
                                 user.Email,
                                 user.NombreCompleto,
                                 user.Identificacion,
                                 user.Celular,
                                 user.Sexo,
                                 user.Estado
                               
                             }).ToList();


                List<Usuario> list = new List<Usuario>();
                foreach(var item in query)
                {
                    Usuario user = new Usuario();
                    user.Id = item.Id;
                    user.SedeNombre = item.sedeNombre;
                    user.PerfilNombre = item.perfilNombre;
                    user.NombreCompleto = item.NombreCompleto;
                    user.Email = item.Email;
                    user.Celular = item.Celular;
                    list.Add(user);
                }
                response.IsSuccessful = true;
                response.Data = list;
            }
            catch (Exception ex)
            {
                response.Message = ex.Message;
            }

            return Ok(response);
        }


        [HttpGet("{Id}")]
        public IActionResult Ge(int id)
        {
            Response response = new Response();
            try
            {
                Usuario user = db.Usuarios.Find(id);
                response.IsSuccessful = true;
                response.Data = user;
            }
            catch (Exception ex)
            {
                response.Message = ex.Message;
            }

            return Ok(response);
        }


        [HttpPost]
        public IActionResult Add(Usuario model)
        {
            Response response = new Response();
            try
            {
                db.Usuarios.Add(model);
                db.SaveChanges();
                response.IsSuccessful = true;
            }
            catch (Exception ex)
            {
                response.Message = ex.Message;
            }

            return Ok(response);
        }

        [HttpPut]
        public IActionResult Edit(Usuario model)
        {
            Response response = new Response();
            try
            {
                db.Entry(model).State = EntityState.Modified;
                db.SaveChanges();
                response.IsSuccessful = true;
            }
            catch (Exception ex)
            {
                response.Message = ex.Message;
            }

            return Ok(response);
        }

        [HttpDelete("{Id}")]
        public IActionResult Delete(int id)
        {
            Response response = new Response();
            try
            {
                var model = db.Usuarios.Find(id);
                db.Usuarios.Remove(model);
                db.SaveChanges();
                response.IsSuccessful = true;
            }
            catch (Exception ex)
            {
                response.Message = ex.Message;
            }

            return Ok(response);
        }
    }
}

