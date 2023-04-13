using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using coqueiros_modulo1_semana10_exercicio.DTO;
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
        public ActionResult<MarcaDto> Post([FromBody] MarcaDto marcaDto)
        {
            MarcaModel marcaModel = new MarcaModel();

            marcaModel.Nome = marcaDto.Nome;

            locacaoContext.Add(marcaModel);
            locacaoContext.SaveChanges();

            return Ok("Marca cadastrada com sucesso");
        }

        [HttpPut]
        public IActionResult Put([FromBody] MarcaDto marcaDto)

        {
            if (marcaDto == null || marcaDto.Codigo == 0)
            {
                return BadRequest("O objeto é nulo.");
            }

            MarcaModel _marcaModel = locacaoContext.Marca.Find(marcaDto.Codigo);

            if (_marcaModel == null)
            {
                return NotFound("Não encontrado.");
            }

            _marcaModel.Nome = marcaDto.Nome;
            _marcaModel.id = marcaDto.Codigo;

            locacaoContext.Update(_marcaModel);
            locacaoContext.SaveChanges();

            return Ok();
        }



    }
}
