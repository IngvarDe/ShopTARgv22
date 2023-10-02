using Microsoft.EntityFrameworkCore;
using Shop.Core.Domain;
using Shop.Core.Dto;
using Shop.Core.ServiceInterface;
using Shop.Data;


namespace Shop.ApplicationServices.Services
{
    public class SpaceshipServices : ISpaceshipServices
    {
        private readonly ShopContext _context;
        private readonly IFileServices _fileServices;

        public SpaceshipServices
            (
                ShopContext context,
                IFileServices fileServices
            )
        {
            _context = context;
            _fileServices = fileServices;
        }

        public async Task<Spaceship> Create(SpaceshipDto dto)
        {

            Spaceship spaceship = new Spaceship();

            spaceship.Id = Guid.NewGuid();
            spaceship.Name = dto.Name;
            spaceship.Type = dto.Type;
            spaceship.Passengers = dto.Passengers;
            spaceship.EnginePower = dto.EnginePower;
            spaceship.Crew = dto.Crew;
            spaceship.Company = dto.Company;
            spaceship.CargoWeight = dto.CargoWeight;
            spaceship.CreatedAt = DateTime.Now;
            spaceship.ModifiedAt = DateTime.Now;
            _fileServices.FilesToApi(dto, spaceship);

            await _context.Spaceships.AddAsync(spaceship);
            await _context.SaveChangesAsync();

            return spaceship;
        }


        public async Task<Spaceship> Update(SpaceshipDto dto)
        {
            var domain = new Spaceship()
            {
                Id = dto.Id,
                Name = dto.Name,
                Type = dto.Type,
                Passengers = dto.Passengers,
                EnginePower = dto.EnginePower,
                Crew = dto.Crew,
                Company = dto.Company,
                CargoWeight = dto.CargoWeight,
                CreatedAt = dto.CreatedAt,
                ModifiedAt = DateTime.Now,
            };

            _context.Spaceships.Update(domain);
            await _context.SaveChangesAsync();

            return domain;
        }

        public async Task<Spaceship> Delete(Guid id)
        {
            var spaceshipId = await _context.Spaceships
                .FirstOrDefaultAsync(x => x.Id == id);

            var images = await _context.FileToApis
                .Where(x => x.SpaceshipId == id)
                .Select(y => new FileToApiDto
                 {
                    Id = y.Id,
                    SpaceshipId = y.SpaceshipId,
                    ExistingFilePath = y.ExistingFilePath
                 }).ToArrayAsync();

            await _fileServices.RemoveImagesFromApi(images);
            _context.Spaceships.Remove(spaceshipId);
            await _context.SaveChangesAsync();

            return spaceshipId;
        }


        public async Task<Spaceship> GetAsync(Guid id)
        {
            var result = await _context.Spaceships
                .FirstOrDefaultAsync(x => x.Id == id);

            return result;
        }
    }
}
