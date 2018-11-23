using System;
using System.Threading.Tasks;
using WeatherApp.Services.Helpers;

namespace WeatherApp.Services
{
	public class LocationWeatherService : ILocationWeatherService
	{
		private const string UrlBase = "https://api.openweathermap.org/data/2.5/weather?q=";
		
		private readonly IHttpConnection _connection;

		public LocationWeatherService(IHttpConnection connection)
		{
			_connection = connection;
		}
			
		public async Task<string> GetWeatherForNamedLocationAsync(string name)
		{
			if (string.IsNullOrWhiteSpace(name))
				throw new ArgumentException("Argument name was null or empty.");
			
			var url = AppendUrl(name);

			var result = await _connection.GetAsync(url);

			return result;
		}

		private string AppendUrl(string name)
		{
			return UrlBase + name;
		}
	}
}