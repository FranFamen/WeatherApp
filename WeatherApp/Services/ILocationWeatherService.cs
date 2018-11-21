using System.Threading.Tasks;

namespace WeatherApp.Services
{
	public interface ILocationWeatherService
	{
		Task<string> GetWeatherForNamedLocationAsync(string name);
	}
}