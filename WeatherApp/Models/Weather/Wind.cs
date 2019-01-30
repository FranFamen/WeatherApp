using Newtonsoft.Json;

namespace WeatherApp.Models.Weather
{
	public class Wind
	{
		[JsonProperty("speed")]
		public string Speed { get; set; }
		
		[JsonProperty("deg")]
		public double Degrees { get; set; }
	}
}