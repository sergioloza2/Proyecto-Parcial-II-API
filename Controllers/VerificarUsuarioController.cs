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
    public class VerificarUsuarioController : ControllerBase
    {

        private readonly AppDbContext _context;

        public VerificarUsuarioController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<Usuario>> VerificarUsuario(String username, String contraseña)
        {
            var usuariosLista = await _context.Usuario_1.Where(m => m.NUsuario == username).ToListAsync();

            if(usuariosLista == null || !usuariosLista.Any())
            {
                return NotFound();
            }
            var usuario = usuariosLista.First();
            if( usuario.Contraseña == contraseña )
            {
                return Ok(usuario);
            }

            return Unauthorized();
            
        }
    }
}
