using animals_api.Animals.Models;
using animals_api.Animals.Repository;
using Microsoft.AspNetCore.Mvc;

namespace animals_api.Animals.Controllers
{
    [ApiController]
    [Route("api/v1/[controller]")]
    public class AnimalController : ControllerBase
    {
        private IAnimalRepo _animalRepo;

        public AnimalController(IAnimalRepo animalRepo)
        {
            _animalRepo = animalRepo;
        }

        [HttpGet("all")]

        public async Task<ActionResult<List<Animal>>> GetAnimalAsync()
        {
            var animals = await _animalRepo.GetAnimalsAsync();

            return Ok(animals);
        }

        [HttpPost("add")]

        public async Task<ActionResult<List<Animal>>> GetAnimalsAsync()
        {
            var animal = await _animalRepo.GetAnimalsAsync();

            return Ok(animal);
        }
    }
}
