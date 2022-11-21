using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using API.Data;
using API.models;
using Microsoft.AspNetCore.Cors;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonasController : ControllerBase
    {
        private readonly APIContext _context;

        public PersonasController(APIContext context)
        {
            _context = context;
        }

        // GET: api/Personas
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Personas>>> GetPersonas()
        {
            return await _context.Personas.ToListAsync();
        }

        // GET: api/Personas/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Personas>> GetPersonas(int id)
        {
            var personas = await _context.Personas.FindAsync(id);

            if (personas == null)
            {
                return NotFound();
            }

            return personas;
        }

        // PUT: api/Personas/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutPersonas(int id, Personas personas)
        {
            if (id != personas.Identificador)
            {
                return BadRequest();
            }

            _context.Entry(personas).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PersonasExists(id))
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

        // POST: api/Personas
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<Personas>> PostPersonas(Personas personas)
        {
            personas.Fecha_de_reacion = DateTime.Now;
            _context.Personas.Add(personas);
            await _context.SaveChangesAsync();

            string fechaActual = "" + personas.Fecha_de_reacion.Year + "-"+personas.Fecha_de_reacion.Month + "-"+ personas.Fecha_de_reacion.Day;

            return CreatedAtAction("GetPersonas", new { id = personas.Identificador }, personas);
        }

        // DELETE: api/Personas/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Personas>> DeletePersonas(int id)
        {
            var personas = await _context.Personas.FindAsync(id);
            if (personas == null)
            {
                return NotFound();
            }

            _context.Personas.Remove(personas);
            await _context.SaveChangesAsync();

            return personas;
        }

        private bool PersonasExists(int id)
        {
            return _context.Personas.Any(e => e.Identificador == id);
        }
    }
}
