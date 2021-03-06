using System;
using System.Threading.Tasks;
using WeatherApp.Services.Helpers;

namespace WeatherApp.Services
{
	public class LocationWeatherService : ILocationWeatherService
	{
		private const string UrlBase = "https://api.openweathermap.org/data/2.5/weather?q=";
		private const string ApiKey = "bdc71ed8c311de9acce8ce4c8ab8c7fc";
		
		private readonly IHttpConnection _connection;
		private readonly IJsonConverter _jsonConverter;

		public LocationWeatherService(IHttpConnection connection, IJsonConverter jsonConverter)
		{
			_connection = connection;
			_jsonConverter = jsonConverter;
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
			return UrlBase + name + "&appid=" + ApiKey;
		}
	}
}