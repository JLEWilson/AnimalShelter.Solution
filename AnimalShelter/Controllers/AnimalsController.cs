using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using AnimalShelter.Models;
using System.Linq;

namespace AnimalShelter.AddControllers
{
  [Produces("application/json")]
  [Route("api/[controller]")]
  [ApiVersion("1.0")]
  [ApiVersion("2.0")]
  [ApiController]
  public class AnimalsController : ControllerBase
  {
    private readonly AnimalShelterContext _db;

    public AnimalsController(AnimalShelterContext db)
    {
      _db = db;
    }

    [MapToApiVersion("1.0")]
    [HttpGet]
    public async Task<ActionResult<IEnumerable<Animal>>> Get(string species, string gender, string name)
    {
      return await _db.Animals.ToListAsync();
    }
    
  }
}