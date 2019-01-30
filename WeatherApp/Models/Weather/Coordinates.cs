using Newtonsoft.Json;

namespace WeatherApp.Models.Weather
{
	public class Coordinates
	{
		[JsonProperty("lon")]
		public double Longitude { get; set; }
		
		[JsonProperty("lat")]
		public double Latitude { get; set; }
	}
}