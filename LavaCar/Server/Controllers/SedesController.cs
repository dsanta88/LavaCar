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
    public class SedesController : ControllerBase
    {
        private readonly LavaCarDbContext db;

        public SedesController(LavaCarDbContext context)
        {
            db = context;
        }

        [HttpGet("[action]/{id}")]
        public IActionResult GetSedesxEmpresa(int id)
        {
            Response response = new Response();
            try
            {
                List<Sede> list = db.Sedes.Where(s => s.EmpresaId == id).ToList();
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
        public IActionResult Get(int id)
        {
            Response response = new Response();
            try
            {
                Sede emp = db.Sedes.Find(id);
                response.IsSuccessful = true;
                response.Data = emp;
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
        public IActionResult Edit(Sede model)
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

