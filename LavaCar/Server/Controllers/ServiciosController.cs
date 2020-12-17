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
    public class ServiciosController : ControllerBase
    {
        private readonly LavaCarDbContext db;

        public ServiciosController(LavaCarDbContext context)
        {
            db = context;
        }

        [HttpGet("[action]/{id}")]
        public IActionResult GetServiciosXTipoVehiculo(int id)
        {
            Response response = new Response();
            try
            {
                List<Servicio> list = db.Servicios.Where(t => t.TipoVehiculoId == id).ToList();
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
                Servicio emp = db.Servicios.Find(id);
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
        public IActionResult Add(Servicio model)
        {
            Response response = new Response();
            try
            {
                db.Servicios.Add(model);
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
        public IActionResult Edit(Servicio model)
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
                var model = db.Servicios.Find(id);
                db.Servicios.Remove(model);
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
