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
    public class UltimaChanceAutorizacaoController : ControllerBase
    {
        private readonly ApiFarmarciaElvisContext _context;

        public UltimaChanceAutorizacaoController(ApiFarmarciaElvisContext context)
        {
            _context = context;
        }

        // GET: api/UltimaChanceAutorizacao
        [HttpGet]
        public IEnumerable<UltimaChanceAutorizacao> GetUltimaChanceAutorizacao()
        {
            return _context.UltimaChanceAutorizacao.Include(uca => uca.UltimaChanceProduto);
        }

        // GET: api/UltimaChanceAutorizacao/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetUltimaChanceAutorizacao([FromRoute] int? id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var ultimaChanceAutorizacao = await _context.UltimaChanceAutorizacao.Include(uca => uca.UltimaChanceProduto).FirstOrDefaultAsync(uca => uca.SequenciaAutorizacao == id);

            if (ultimaChanceAutorizacao == null)
            {
                return NotFound();
            }

            return Ok(ultimaChanceAutorizacao);
        }

        // PUT: api/UltimaChanceAutorizacao/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutUltimaChanceAutorizacao([FromRoute] int? id, [FromBody] UltimaChanceAutorizacao ultimaChanceAutorizacao)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != ultimaChanceAutorizacao.SequenciaAutorizacao)
            {
                return BadRequest();
            }

            _context.Entry(ultimaChanceAutorizacao).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!UltimaChanceAutorizacaoExists(id))
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

        // POST: api/UltimaChanceAutorizacao
        [HttpPost]
        public async Task<IActionResult> PostUltimaChanceAutorizacao([FromBody] UltimaChanceAutorizacao ultimaChanceAutorizacao)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.UltimaChanceAutorizacao.Add(ultimaChanceAutorizacao);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetUltimaChanceAutorizacao", new { id = ultimaChanceAutorizacao.SequenciaAutorizacao }, ultimaChanceAutorizacao);
        }

        // DELETE: api/UltimaChanceAutorizacao/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteUltimaChanceAutorizacao([FromRoute] int? id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var ultimaChanceAutorizacao = await _context.UltimaChanceAutorizacao.FindAsync(id);
            if (ultimaChanceAutorizacao == null)
            {
                return NotFound();
            }

            _context.UltimaChanceAutorizacao.Remove(ultimaChanceAutorizacao);
            await _context.SaveChangesAsync();

            return Ok(ultimaChanceAutorizacao);
        }

        private bool UltimaChanceAutorizacaoExists(int? id)
        {
            return _context.UltimaChanceAutorizacao.Any(e => e.SequenciaAutorizacao == id);
        }
    }
}