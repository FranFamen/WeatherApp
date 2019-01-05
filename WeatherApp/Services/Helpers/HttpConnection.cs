using System.Net.Http;
using System.Threading.Tasks;

namespace WeatherApp.Services.Helpers
{
	public class HttpConnection : IHttpConnection
	{
		private readonly HttpClient _httpClient = new HttpClient();
		
		public async Task<string> GetAsync(string url)
		{
			var result = await _httpClient.GetAsync(url);
			result.EnsureSuccessStatusCode();
			return await result.Content.ReadAsStringAsync();
		}
	}
}