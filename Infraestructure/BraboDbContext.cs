using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RoboZeroAProducao.Entidades;

namespace RoboZeroAProducao.Infraestructure
{
    public class BraboDbContext : DbContext
    {
        public DbSet<Endereco> Enderecos {get; set;}
        
        public BraboDbContext(DbContextOptions options): base(options)
        {
            
        }
    }
}