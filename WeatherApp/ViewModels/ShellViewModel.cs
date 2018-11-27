using System.Threading.Tasks;
using Prism.Mvvm;
using WeatherApp.Services;

namespace WeatherApp.ViewModels
{
	public class ShellViewModel : BindableBase
	{
		private const string London = "London";
		private readonly ILocationWeatherService _locationWeatherService;

		private string _weatherText;
		
		public ShellViewModel(ILocationWeatherService locationWeatherService)
		{
			_locationWeatherService = locationWeatherService;
		}

		public async Task OnLoadAsync()
		{
			WeatherText = await _locationWeatherService.GetWeatherForNamedLocationAsync(London);
		}

		public string WeatherText
		{
			get { return _weatherText;}
			set
			{
				_weatherText = value;
				RaisePropertyChanged();
			}
		}
	
	}
}