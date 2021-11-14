using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using proyecto_api_parcial2;
using proyecto_api_parcial2.Data;

namespace proyecto_api_parcial2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ImagenStrsController : ControllerBase
    {
        private readonly AppDbContext _context;

        public ImagenStrsController(AppDbContext context)
        {
            _context = context;
        }

        // GET: api/ImagenStrs
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ImagenStr>>> GetImagenStr()
        {
            return await _context.ImagenStr.ToListAsync();
        }

        // GET: api/ImagenStrs/5
        [HttpGet("{id}")]
        public async Task<ActionResult<ImagenStr>> GetImagenStr(int id)
        {
            var imagenStr = await _context.ImagenStr.FindAsync(id);

            if (imagenStr == null)
            {
                return NotFound();
            }

            return imagenStr;
        }

        // PUT: api/ImagenStrs/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutImagenStr(int id, ImagenStr imagenStr)
        {
            if (id != imagenStr.ImagenStrId)
            {
                return BadRequest();
            }

            _context.Entry(imagenStr).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ImagenStrExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/ImagenStrs
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<ImagenStr>> PostImagenStr(ImagenStr imagenStr)
        {
            _context.ImagenStr.Add(imagenStr);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetImagenStr", new { id = imagenStr.ImagenStrId }, imagenStr);
        }

        // DELETE: api/ImagenStrs/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteImagenStr(int id)
        {
            var imagenStr = await _context.ImagenStr.FindAsync(id);
            if (imagenStr == null)
            {
                return NotFound();
            }

            _context.ImagenStr.Remove(imagenStr);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool ImagenStrExists(int id)
        {
            return _context.ImagenStr.Any(e => e.ImagenStrId == id);
        }
    }
}
