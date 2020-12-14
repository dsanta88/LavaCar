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
    public class TipoVehiculosController : ControllerBase
    {
        private readonly LavaCarDbContext db;

        public TipoVehiculosController(LavaCarDbContext context)
        {
            db = context;
        }

        [HttpGet("[action]/{id}")]
        public IActionResult GetTipoVehiculosXSede(int id)
        {
            Response response = new Response();
            try
            {
                List<TipoVehiculo> list = db.TiposVehiculos.Where(t => t.SedeId == id).ToList();
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
                TipoVehiculo emp = db.TiposVehiculos.Find(id);
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
        public IActionResult Add(TipoVehiculo model)
        {
            Response response = new Response();
            try
            {
                db.TiposVehiculos.Add(model);
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
        public IActionResult Edit(TipoVehiculo model)
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
                var model = db.TiposVehiculos.Find(id);
                db.TiposVehiculos.Remove(model);
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
