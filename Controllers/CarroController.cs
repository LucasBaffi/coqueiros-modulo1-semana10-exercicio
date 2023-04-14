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
    public class CarroController : ControllerBase
    {
        private readonly LocacaoContext locacaoContext;

        public CarroController(LocacaoContext locacaoContext)
        {
            this.locacaoContext = locacaoContext;
        }

        [HttpPost]
        public ActionResult<MarcaDto> Post([FromBody] CarroDto carroDto)
        {
            // Criando uma instância da classe CarroModel
            CarroModel carroModel = new();

            MarcaModel marcaModel = locacaoContext.Marca.Find(carroDto.CodigoMarca);
            if (marcaModel == null)
            {
                return NotFound("Marca não encontrada!");
            }
            carroModel.id = carroDto.Codigo;
            carroModel.Nome = carroDto.Nome;
            carroModel.IdMarca = marcaModel.id;

            locacaoContext.Add(carroModel);
            locacaoContext.SaveChanges();

            return Ok("Carro salvo com sucesso!");
        }

        [HttpPut]

        public ActionResult Put([FromBody] CarroDto carroDto)
        {
             CarroModel carroModel = new();

            MarcaModel marcaModel = locacaoContext.Marca.Find(carroDto.CodigoMarca);
            if (marcaModel == null)
            {
                return NotFound("Marca não encontrada!");
            }
            carroModel.id = carroDto.Codigo;
            carroModel.Nome = carroDto.Nome;
            carroModel.IdMarca = marcaModel.id;

            locacaoContext.Update(carroModel);
            locacaoContext.SaveChanges();

            return Ok("Carro salvo com sucesso!");

        }

        [HttpDelete("{id}")]
        public ActionResult Delete([FromBody] int id)
        {
              MarcaModel marcaModel = locacaoContext.Marca.Find(id);

              if(marcaModel != null)
              {
                locacaoContext.Remove(marcaModel);
                locacaoContext.SaveChanges();

                return Ok("Carro removido com sucesso!");
              }
               return BadRequest("Carro não existe.");
        }

        [HttpGet]
        public ActionResult <List<CarroDto>> GetAll()
        {
             List<CarroDto> listaCarroDtos = new();
        }

    }
}