using Microsoft.EntityFrameworkCore;
using proyecto_api_parcial2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using proyecto_api_parcial2;

namespace proyecto_api_parcial2.Data
{
    public class AppDbContext : DbContext
    {

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        public DbSet<Usuario> Usuario_1 { get; set; }
        public DbSet<Nota> Nota_1 { get; set; }
        public DbSet<proyecto_api_parcial2.ImagenStr> ImagenStr { get; set; }

    }
}
