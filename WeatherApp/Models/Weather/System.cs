using Newtonsoft.Json;

namespace WeatherApp.Models.Weather
{
	public class System
	{
		[JsonProperty("country")]
		public string Country { get; set; }
		
		[JsonProperty("sunrise")]
		public long Sunrise { get; set; }

		[JsonProperty("sunset")]
		public long Sunset { get; set; }
	}
}