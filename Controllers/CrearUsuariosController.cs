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
    public class CrearUsuariosController : ControllerBase
    {
        private readonly AppDbContext _context;

        public CrearUsuariosController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Usuario>> GetUsuario(int id)
        {
            var usuario = await _context.Usuario_1.FindAsync(id);

            if (usuario == null)
            {
                return NotFound();
            }

            return usuario;
        }

        [HttpPost]
        public async Task<ActionResult<Usuario>> PostCrearUsuario(Usuario usuario)
        {

            var usuariosConMismoUsername = await _context.Usuario_1.Where(p => p.NUsuario == usuario.NUsuario).ToListAsync();

            if( !usuariosConMismoUsername.Any() )
            {
                _context.Usuario_1.Add(usuario);
                await _context.SaveChangesAsync();
                return CreatedAtAction("GetUsuario", new { id = usuario.UsuarioId }, usuario);
            }


            return Conflict();
        }

    }
}
