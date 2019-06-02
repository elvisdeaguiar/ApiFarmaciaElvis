using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ApiFarmaciaElvis.Entidades;
using ApiFarmarciaElvis.Repositorios;

namespace ApiFarmarciaElvis
{
    [Route("api/[controller]")]
    [ApiController]
    public class UltimaChanceProdutoController : ControllerBase
    {
        private readonly ApiFarmarciaElvisContext _context;

        public UltimaChanceProdutoController(ApiFarmarciaElvisContext context)
        {
            _context = context;
        }

        // GET: api/UltimaChanceProduto
        [HttpGet]
        public IEnumerable<UltimaChanceProduto> GetUltimaChanceProduto()
        {
            return _context.UltimaChanceProduto;
        }

        // GET: api/UltimaChanceProduto/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetUltimaChanceProduto([FromRoute] int? id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var ultimaChanceProduto = await _context.UltimaChanceProduto.FindAsync(id);

            if (ultimaChanceProduto == null)
            {
                return NotFound();
            }

            return Ok(ultimaChanceProduto);
        }

        // PUT: api/UltimaChanceProduto/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutUltimaChanceProduto([FromRoute] int? id, [FromBody] UltimaChanceProduto ultimaChanceProduto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != ultimaChanceProduto.SequenciaProduto)
            {
                return BadRequest();
            }

            _context.Entry(ultimaChanceProduto).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!UltimaChanceProdutoExists(id))
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

        // POST: api/UltimaChanceProduto
        [HttpPost]
        public async Task<IActionResult> PostUltimaChanceProduto([FromBody] UltimaChanceProduto ultimaChanceProduto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.UltimaChanceProduto.Add(ultimaChanceProduto);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetUltimaChanceProduto", new { id = ultimaChanceProduto.SequenciaProduto }, ultimaChanceProduto);
        }

        // DELETE: api/UltimaChanceProduto/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteUltimaChanceProduto([FromRoute] int? id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var ultimaChanceProduto = await _context.UltimaChanceProduto.FindAsync(id);
            if (ultimaChanceProduto == null)
            {
                return NotFound();
            }

            _context.UltimaChanceProduto.Remove(ultimaChanceProduto);
            await _context.SaveChangesAsync();

            return Ok(ultimaChanceProduto);
        }

        private bool UltimaChanceProdutoExists(int? id)
        {
            return _context.UltimaChanceProduto.Any(e => e.SequenciaProduto == id);
        }
    }
}