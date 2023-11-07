using Shop.Core.Dto.OpenWeatherDtos;
namespace Shop.Core.ServiceInterface
{
    public interface IWeatherForecastServices
    {
        Task<OpenWeatherResultDto> OpenWeatherResult(OpenWeatherResultDto dto);
    }
}
