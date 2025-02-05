using animals_api.Animals.Models;
using animals_api.Data.Migrations;
using AutoMapper;
using Microsoft.EntityFrameworkCore;

namespace animals_api.Animals.Repository
{
    public class AnimalRepo:IAnimalRepo
    {
        private readonly AppDbContext _appdbContext;
        private readonly IMapper _mapper;

        public AnimalRepo(AppDbContext appdbContext, IMapper mapper)
        {
            this._appdbContext = appdbContext;
            this._mapper = mapper;
        }

        public async Task<List<Animal>> GetAnimalsAsync()
        {
            return await _appdbContext.Animals.ToListAsync();
        }
    }
}
