using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace coqueiros_modulo1_semana10_exercicio.Model
{
    [Table("Carro")]


    public class CarroModel
    {
        [Key]

        public int id { get; set; }

        public string Nome { get; set; }

        [ForeignKey("MarcaModel")]
         
         public int IdMarca { get; set; }
        public MarcaModel MarcaModel { get; internal set; }
        DateTime DataLocacao { get; set; }
    }
}

