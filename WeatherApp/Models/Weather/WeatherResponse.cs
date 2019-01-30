using System.Collections.Generic;
using System.Windows;
using Newtonsoft.Json;

namespace WeatherApp.Models.Weather
{
	public class WeatherResponse
	{
		[JsonProperty("coord")]
		public Coordinates Coordinates { get; set; }
		
		[JsonProperty("sys")]
		public System System { get; set; }

		[JsonProperty("weather")]
		public IEnumerable<Weather> Weather { get; set; } 
		
		[JsonProperty("main")]
		public Main	Main { get; set; }
		
		[JsonProperty("wind")]
		public Wind Wind { get; set; }
	}
}