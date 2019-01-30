using Newtonsoft.Json;

namespace WeatherApp.Models.Weather
{
	public class Clouds
	{
		[JsonProperty("all")]
		public double All { get; set; }
	}
}