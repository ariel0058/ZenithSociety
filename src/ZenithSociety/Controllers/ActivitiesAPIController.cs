using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ZenithSociety.Data;
using ZenithSociety.Models;
using Microsoft.EntityFrameworkCore;

namespace ZenithSociety.Controllers
{
    [Produces("application/json")]
    [Route("api/ActivitiesAPI")]
    public class ActivitiesApiController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ActivitiesApiController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/ActivitiesApi
        [HttpGet]
        public IEnumerable<Activity> GetActivities()
        {
            return _context.Activities;
        }

        // GET: api/ActivitiesApi/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetActivity([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            Activity activity = await _context.Activities.SingleOrDefaultAsync(m => m.activityId == id);

            if (activity == null)
            {
                return NotFound();
            }

            return Ok(activity);
        }

        // PUT: api/ActivitiesApi/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutActivity([FromRoute] int id, [FromBody] Activity activity)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != activity.activityId)
            {
                return BadRequest();
            }

            _context.Entry(activity).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ActivityExists(id))
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

        // POST: api/ActivitiesApi
        [HttpPost]
        public async Task<IActionResult> PostActivity([FromBody] Activity activity)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.Activities.Add(activity);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (ActivityExists(activity.activityId))
                {
                    return new StatusCodeResult(StatusCodes.Status409Conflict);
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetActivity", new { id = activity.activityId }, activity);
        }

        // DELETE: api/ActivitiesApi/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteActivity([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            Activity activity = await _context.Activities.SingleOrDefaultAsync(m => m.activityId == id);
            if (activity == null)
            {
                return NotFound();
            }

            _context.Activities.Remove(activity);
            await _context.SaveChangesAsync();

            return Ok(activity);
        }

        private bool ActivityExists(int id)
        {
            return _context.Activities.Any(e => e.activityId == id);
        }
    }
}