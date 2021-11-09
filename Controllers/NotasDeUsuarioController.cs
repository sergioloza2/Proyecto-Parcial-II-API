using Microsoft.AspNetCore.Cors;
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
    public class NotasDeUsuarioController : ControllerBase
    {

        private readonly AppDbContext _context;

        public NotasDeUsuarioController(AppDbContext context)
        {
            _context = context;
        }

        // GET: api/Notas/5          -    Obtiene todas las notas de un usuario
        [EnableCors("MyPolicy")]
        [HttpGet("{usuarioId}")]
        public async Task<ActionResult<List<Nota>>> GetNota(int usuarioId)
        {

            var notas = await _context.Nota_1.Where(m => m.UsuarioId == usuarioId).ToListAsync();

            if (notas == null)
            {
                return NotFound();
            }

            return notas;
        }
    }
}
