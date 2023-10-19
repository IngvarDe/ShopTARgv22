using Shop.Core.Dto;
using Shop.Core.ServiceInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.SpaceshipTest
{
    public class SpaceshipTest : TestBase
    {
        [Fact]
        public async Task ShouldNot_AddEmptySpaceship_WhenReturnresult()
        {
            SpaceshipDto dto = new SpaceshipDto();

            dto.Name = "Name";
            dto.Type = "Type";
            dto.Passengers = 123;
            dto.EnginePower = 123;
            dto.Crew = 123;
            dto.Company = "asd";
            dto.CargoWeight = 123;
            dto.CreatedAt = DateTime.Now;
            dto.ModifiedAt = DateTime.Now;

            var result = await Svc<ISpaceshipServices>().Create(dto);

            Assert.NotNull(result);
        }

        [Fact]
        public async Task ShouldNot_GetByIdSpaceship_WhenReturnsNotEqual()
        {
            Guid guid = Guid.Parse("2b8b9080-60ef-442b-9822-f1ad47984736");
            //kuidas teha automaatselt guidi???
            Guid wrongGuid = Guid.Parse(Guid.NewGuid().ToString());
        }
    }
}
