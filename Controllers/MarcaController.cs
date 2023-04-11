using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using coqueiros_modulo1_semana10_exercicio.Model;
using Microsoft.AspNetCore.Mvc;

namespace coqueiros_modulo1_semana10_exercicio.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MarcaController : ControllerBase
    {
         private readonly LocacaoContext locacaoContext;

         public MarcaController(LocacaoContext locacaoContext)
         {
            this.locacaoContext = locacaoContext;
         }

         [HttpPost]
         public ActionResult Post([FromBody] MarcaModel marcaModel)
         {
            return Ok();
         }
    }
}