
using System;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using LavaCar.Server.Data;
using LavaCar.Shared;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Extensions.Hosting;
using System.IO;

namespace LavaCar.Server.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class EmpresasController : ControllerBase
    {
        private readonly LavaCarDbContext db;



        public EmpresasController(LavaCarDbContext context)
        {
            db = context;
        }

        [HttpGet("{Id}")]
        public IActionResult Get(int id)
        {
            Response response = new Response();
            try
            {
                List<Empresa> lst = db.Empresas.Where(e => e.Id == id).ToList();
                response.IsSuccessful = true;
                response.Data = lst;
            }
            catch (Exception ex)
            {
                response.Message = ex.Message;
            }
            return Ok(response);
        }


        [HttpPut]
        public IActionResult Edit(Empresa model)
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


     

    }
}
