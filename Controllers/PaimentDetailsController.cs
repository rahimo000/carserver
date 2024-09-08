using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using carserver.models;

namespace carserver.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PaimentDetailsController : ControllerBase
    {
        private readonly PaimentDetailsContext _context;

        public PaimentDetailsController(PaimentDetailsContext context)
        {
            _context = context;
        }

        // GET: api/PaimentDetails
        [HttpGet]
        public async Task<ActionResult<IEnumerable<PaimentDetails>>> GetPaimentDetails()
        {
          if (_context.PaimentDetails == null)
          {
              return NotFound();
          }
            return await _context.PaimentDetails.ToListAsync();
        }

        // GET: api/PaimentDetails/5
        [HttpGet("{id}")]
        public async Task<ActionResult<PaimentDetails>> GetPaimentDetails(int id)
        {
          if (_context.PaimentDetails == null)
          {
              return NotFound();
          }
            var paimentDetails = await _context.PaimentDetails.FindAsync(id);

            if (paimentDetails == null)
            {
                return NotFound();
            }

            return paimentDetails;
        }

        // PUT: api/PaimentDetails/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutPaimentDetails(int id, PaimentDetails paimentDetails)
        {
            if (id != paimentDetails.Id)
            {
                return BadRequest();
            }

            _context.Entry(paimentDetails).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PaimentDetailsExists(id))
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

        // POST: api/PaimentDetails
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<PaimentDetails>> PostPaimentDetails(PaimentDetails paimentDetails)
        {
          if (_context.PaimentDetails == null)
          {
              return Problem("Entity set 'PaimentDetailsContext.PaimentDetails'  is null.");
          }
            _context.PaimentDetails.Add(paimentDetails);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetPaimentDetails", new { id = paimentDetails.Id }, paimentDetails);
        }

        // DELETE: api/PaimentDetails/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletePaimentDetails(int id)
        {
            if (_context.PaimentDetails == null)
            {
                return NotFound();
            }
            var paimentDetails = await _context.PaimentDetails.FindAsync(id);
            if (paimentDetails == null)
            {
                return NotFound();
            }

            _context.PaimentDetails.Remove(paimentDetails);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool PaimentDetailsExists(int id)
        {
            return (_context.PaimentDetails?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
