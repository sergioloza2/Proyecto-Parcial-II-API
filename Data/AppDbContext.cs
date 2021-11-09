using Microsoft.EntityFrameworkCore;
using proyecto_api_parcial2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace proyecto_api_parcial2.Data
{
    public class AppDbContext : DbContext
    {

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        public DbSet<proyecto_api_parcial2.Models.Usuario> Usuario_1 { get; set; }
        public DbSet<proyecto_api_parcial2.Models.Nota> Nota_1 { get; set; }
    }
}
