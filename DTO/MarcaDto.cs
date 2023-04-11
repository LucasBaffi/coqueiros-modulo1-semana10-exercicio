using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace coqueiros_modulo1_semana10_exercicio.DTO
{
    public class MarcaDto
    {
        public int Codigo { get; set; }
        public string? Nome { get; set; }
    }
}
// Codigo Int Null
// Nome String NOT NULL
// Objetivo desta classe é receber os dados para api e repassar os dados para a classe MarcaModel