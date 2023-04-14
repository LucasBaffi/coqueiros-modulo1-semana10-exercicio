using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace coqueiros_modulo1_semana10_exercicio.DTO
{
    public class CarroDto
    {
        public int Codigo { get; set; }
         public string Nome { get; set; }
        public string DescricaoCarro { get; set; }
        public int CodigoMarca { get; set; }
        public string DescricaoMarca { get; set; }
        public DateTime DataLocacao { get; set; }
    }
}


