
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace coqueiros_modulo1_semana10_exercicio.Model
{
    [Table("Marca")]

    public class MarcaModel
    {

        [Key]
        [Column("Id")]
        public int id { get; set; }

        [MaxLength(100)]
        public string? Nome { get; set; }


    }
}