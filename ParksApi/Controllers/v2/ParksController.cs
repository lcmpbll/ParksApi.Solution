using System.Collections.Generic;
using System.Linq;
using System;
using Microsoft.AspNetCore.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Versioning;
using ParksApi.Models;

namespace ParksApi.Controllers.v2
{
  [ApiVersion("2.0")]
  [ApiExplorerSettings(GroupName = "v2")]
  [Route("api/v{version:apiVersion}/[controller]")]
  [ApiController]
  public class ParksController : ControllerBase
  {
    private readonly ParksApiContext _db;
    
    public ParksController(ParksApiContext db)
    {
      _db = db;
    }
    [HttpGet("Version")]
    public IActionResult GetVersion()
    {
      return new OkObjectResult("v2 controller");
    }
    [HttpGet("All")]
    public async Task<ActionResult<IEnumerable<Park>>> Get()
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
    
    [HttpGet("Filtered")]
    public async Task<List<Park>> Get(string name, bool dogsAllowed, string parkMgmt, string location, string description)
    {
      IQueryable<Park> query = _db.Parks.AsQueryable();
      
      if (name != null)
      {
        query = query.Where(entry => entry.Name.Contains(name));
      }
      if (dogsAllowed != false)
      {
        query = query.Where(entry => entry.DogsAllowed == true);
      }
      else
      {
        query = query.Where(entry => entry.DogsAllowed == false);
      }
      if (parkMgmt != null)
      {
        query = query.Where(entry => entry.ParkMgmt == parkMgmt);
      }
      if (location != null)
      {
        query = query.Where(entry => entry.Location == location);
      }
      if (description != null)
      {
        query = query.Where(entry => entry.Description.Contains(description));
      }
      return await query.ToListAsync();
       
    }
    
    [HttpPost]
    public async Task<ActionResult<Park>> Post(Park park)
    {
      _db.Parks.Add(park);
      await _db.SaveChangesAsync();
      
      return CreatedAtAction(nameof(GetPark), new { id= park.ParkId }, park );
    }
    
    [HttpPut("{id}")]
    public async Task<IActionResult> Put(int id, Park park)
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
      catch (DbUpdateConcurrencyException)
      {
        if (!ParkExists(id))
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