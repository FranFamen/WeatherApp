namespace WeatherApp.Services.Helpers
{
	public interface IJsonConverter
	{
		T ConvertTo<T>(string json);
		string ConvertFrom<T>(T objectToSerialize);
	}
}