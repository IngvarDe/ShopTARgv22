using System.Text.Json.Serialization;

namespace Shop.Core.Dto.OpenWeatherDtos
{
    public class Coord
    {
        [JsonPropertyName("lon")]
        public double Lon { get; set; }

        [JsonPropertyName("lat")]
        public double Lat { get; set; }
    }
}
