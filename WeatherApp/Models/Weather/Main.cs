using Newtonsoft.Json;

namespace WeatherApp.Models.Weather
{
	public class Main
	{
		[JsonProperty("temp")]
		public double Temperature { get; set; }
		
		[JsonProperty("humidity")]
		public double Humidity { get; set; }
		
		[JsonProperty("pressure")]
		public double Pressure { get; set; }
		
		[JsonProperty("temp_min")]
		public double MinimalTemperature { get; set; }

		[JsonProperty("temp_max")]
		public double MaximumTemperature { get; set; }
	}
}