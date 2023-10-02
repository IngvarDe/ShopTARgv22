using Shop.Core.Domain;
using Shop.Core.Dto;

namespace Shop.Core.ServiceInterface
{
    public interface IRealEstatesServices
    {
        Task<RealEstate> Create(RealEstateDto dto);
        Task<RealEstate> Update(RealEstateDto dto);
        Task<RealEstate> Delete(Guid id);
        Task<RealEstate> GetAsync(Guid id);
    }
}
