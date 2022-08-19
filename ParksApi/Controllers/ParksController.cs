using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ParksApi.Models;

namespace ParksApi.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class ParksController : ControllerBase
  {
    private readonly ParksApiContext _db;
    
    public ParksApiController(ParksApiContet db)
    {
      _db = db;
    }
    
    [HttpGet("All")]
    public async Task<ActionResult<IEnumerable<Park>> Get()
    {
      return await _db.Parks.ToListAsync();
    }
    
    [HttpGet("{id}")]
    public async Task<ActionResult<Park>> GetPark(int id)
    {
      var park =  await _db.Parks.FindAsync(id);
      
      if(park == null)
      {
        return NotFound();
      }
      
      return park;
    }
    
    [HttpPost]
    public async Task<ActionResult<Park>> Post(Park park)
    {
      _db.Parks.Add(park);
      await _db.SaveChangesAsync();
      
      return CreatedAtAction(nameof(GetPark), new { id= park.ParkId }, park );
    }
    
    [HttpPut("{id}")]
    public async Task<IActionResult> PutPark(int id, Park park)
    {
      if (id != park.ParkId)
      {
        return BadRequest();
      }
      
      _db.Entry(park).State = EntityState.Modified;
      
      try
      {
        await _db.SaveChangesAsync();
      }
      catch (DbUpdateConcurrencyExeception)
      {
        if (!ParkExists(id))
        {
          return NotFound();
        }
        else
        {
          {
            throw;
          }
        }
        
        return NoContent();
      }
    }
    
    [HttpDelete("{id}")]
    public async Task<IActionResult> DeletePark(int id)
    {
      var park =  await _db.Parks.FindAsync(id);
      if (park == null)
      {
        return NotFound();
      }
      
      _db.Parks.Remove(park);
      await _db.SaveChangesAsync();
      
      return NoContent();
    }
    
    private bool ParkExists(int id)
    {
      return _db.Parks.Any(e => e.ParkId == id);
    }
    
    
  }
     
     
}