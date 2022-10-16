using System.Collections.Generic;
using System.Linq;
using System;
using Microsoft.AspNetCore.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Versioning;
using ParksApi.Models;
// using System.Web.Http;


namespace ParksApi.Controllers.v1
{
  // [EnableCors(origins:'https://localhost:5001', headers:'*', methods: '*')]
  [ApiVersion("1.0")]
  [ApiExplorerSettings(GroupName = "v1")]
  [Route("/")]
  // [Route("api/v1/[controller]")]
  [ApiController]
  public class ParksController : ControllerBase
  {
    private readonly ParksApiContext _db;
    
    public ParksController(ParksApiContext db)
    {
      _db = db;
    }
    
    /// Returns the Version of the API Queried.
    [HttpGet("Version")]
    public IActionResult GetVersion()
    {
      return new OkObjectResult("v1 controller");
    }
    
    /// Returns all Parks.
    [HttpGet("All")]
    public async Task<ActionResult<IEnumerable<Park>>> Get()
    {
      return await _db.Parks.ToListAsync();
    }
    /// Returns the park with the specified id.
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
    
    //Add's a park to the Oregon Parks API.
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