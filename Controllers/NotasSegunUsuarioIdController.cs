using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using proyecto_api_parcial2.Data;
using proyecto_api_parcial2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace proyecto_api_parcial2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NotasSegunUsuarioIdController : ControllerBase
    {
        private readonly AppDbContext _context;

        public NotasSegunUsuarioIdController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<List<Nota>>> GetNotasDeUsuario2(int id)
        {
            var notas = await _context.Nota_1.Where(p => p.UsuarioId == id).ToListAsync();


            if (notas == null)
            {
                return NotFound();
            }

            return notas;
        }

    }
}
