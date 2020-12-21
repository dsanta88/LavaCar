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
    public class LogEventosController : ControllerBase
    {
        private readonly LavaCarDbContext db;

        public LogEventosController(LavaCarDbContext context)
        {
            db = context;
        }


        [HttpPost]
        public IActionResult Add(LogEvento model)
        {
            Response response = new Response();
            try
            {
                db.LogEventos.Add(model);
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
