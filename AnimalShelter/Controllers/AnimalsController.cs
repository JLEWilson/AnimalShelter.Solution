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
  [ApiVersion("1.1")]
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
    [MapToApiVersion("1.1")]
    [HttpGet]
    public async Task<ActionResult<IEnumerable<Animal>>> Get2(string species, string gender, string name, int age = 0)
    {
      var query = _db.Animals.AsQueryable();

      if(species != null)
      {
        query = query.Where(entry => entry.Species == species);
      }

      if(gender != null)
      {
        query = query.Where(entry => entry.Gender == gender);
      }

      if(gender != null)
      {
        query = query.Where(entry => entry.Name == name);
      }

      if(age != 0)
      {
        query = query.Where(entry => entry.Age == age);
      }
      return await query.ToListAsync();
    }
    [HttpPost]
    public async Task<ActionResult<Animal>> Post(Animal animal)
    {
      _db.Animals.Add(animal);
      await _db.SaveChangesAsync();

      return CreatedAtAction(nameof(GetAnimal), new { id = animal.AnimalId }, animal);
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<Animal>> GetAnimal(int id)
    {
      var animal = await _db.Animals.FindAsync(id);

      if (animal == null)
      {
        return NotFound();
      }

      return animal;
    }
  }
}