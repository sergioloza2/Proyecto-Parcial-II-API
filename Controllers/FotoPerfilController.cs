using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using proyecto_api_parcial2.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace proyecto_api_parcial2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FotoPerfilController : ControllerBase
    {

        private readonly AppDbContext _context;

        public FotoPerfilController(AppDbContext context)
        {
            _context = context;
        }


        [HttpGet]
        public async Task<ActionResult<ImagenStr>> GetFotoPerfil(int id)
        {
            var usuario = await _context.Usuario_1.FindAsync(id);

            int imagenId = usuario.FotoPerfilId;

            ImagenStr imagenBase64 = await _context.ImagenStr.FindAsync(imagenId);

            if (usuario == null)
            {
                return NotFound();
            }
            return imagenBase64;

        }
    }
}
