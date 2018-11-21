using System.Threading.Tasks;

namespace WeatherApp.Services.Helpers
{
	public class HttpConnection : IHttpConnection
	{
		public Task<string> GetAsync(string url)
		{
			throw new System.NotImplementedException();
		}
	}
}