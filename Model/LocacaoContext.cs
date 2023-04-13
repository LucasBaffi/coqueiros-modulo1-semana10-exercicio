using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace coqueiros_modulo1_semana10_exercicio.Model
{
    public class LocacaoContext : DbContext
    {
        public LocacaoContext(DbContextOptions<LocacaoContext> options) : base(options)
        {

        }
    public DbSet<MarcaModel> Marca { get; set; }
    public DbSet<CarroModel> Carro { get; set; }
    }

}


