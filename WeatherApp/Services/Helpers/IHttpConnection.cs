using System.Threading.Tasks;

namespace WeatherApp.Services.Helpers
{
	public interface IHttpConnection
	{
		Task<string> GetAsync(string url);
	}
}