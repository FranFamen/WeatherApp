using Newtonsoft.Json;

namespace WeatherApp.Services.Helpers
{
	public class JsonConverter : IJsonConverter
	{
		public T ConvertTo<T>(string json)
		{ 
			return JsonConvert.DeserializeObject<T>(json);
		}

		public string ConvertFrom<T>(T objectToSerialize)
		{
			return JsonConvert.SerializeObject(objectToSerialize);
		}
	}
}