using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace coqueiros_modulo1_semana10_exercicio.DTO
{
    public class CarroDto
    {
        public int Codigo { get; set; }
        public string? DescricaoCarro { get; set; }
        public int CodigoMarca { get; set; }
        public string? DescricaoMarca { get; set; }
        public DateTime DataLocacao { get; set; }
    }
}


// Código int
// DescricaoCarro String
// CodigoMarca int Nulable
// DescricaoMarca varchar
// DataLocacao Datetime Nulable
// Objetivo desta classe é receber os dados para api e repassar os dados para a classe CarroModel