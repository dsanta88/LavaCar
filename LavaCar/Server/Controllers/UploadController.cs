using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using LavaCar.Shared;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Hosting;

namespace LavaCar.Server.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class UploadController : ControllerBase
    {
        private readonly IHostEnvironment _envioment;

        public UploadController(IHostEnvironment envioment)
        {
            this._envioment = envioment;
        }


        [HttpPost]
        public async Task<IActionResult> Post()
        {
            string path_temp = null;
            if (HttpContext.Request.Form.Files.Any())
            {
                foreach (var file in HttpContext.Request.Form.Files)
                {
                    path_temp = $"{file.Name}{file.FileName}";
                    var path = Path.Combine(_envioment.ContentRootPath, $"wwwroot/{path_temp}");
                
                    using (var stream = new FileStream(path, FileMode.Create))
                    {
                        await file.CopyToAsync(stream);
                    }
                }
            }
            return Ok(path_temp);
        }

        [HttpPost("[action]")]
        public IActionResult EliminarRuta(FileModel file)
        {


            var path = Path.Combine(_envioment.ContentRootPath, $"wwwroot/{file.Ruta}");
          
            if (System.IO.File.Exists(path))
            {
                System.IO.File.Delete(path);
            }
            return Ok(true);
        }
    }

}

