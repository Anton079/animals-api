using animals_api.Animals.Models;

namespace animals_api.Animals.Repository
{
    public interface IAnimalRepo
    {
        Task<List<Animal>> GetAnimalsAsync();
    }
}
