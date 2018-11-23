using System.Net.Http;
using System.Threading.Tasks;

namespace WeatherApp.Services.Helpers
{
	public class HttpConnection : IHttpConnection
	{
		private readonly HttpClient _httpClient = new HttpClient();
		
		public async Task<string> GetAsync(string url)
		{
			var result = await _httpClient.GetAsync("http://samples.openweathermap.org/data/2.5/weather?q=London,uk&appid=b6907d289e10d714a6e88b30761fae22");
			result.EnsureSuccessStatusCode();
			return await result.Content.ReadAsStringAsync();
		}
	}
}