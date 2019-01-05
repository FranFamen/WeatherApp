using System.Diagnostics;
using System.Threading.Tasks;
using System.Windows.Input;
using Prism.Commands;
using Prism.Mvvm;
using WeatherApp.Services;

namespace WeatherApp.ViewModels
{
	public class ShellViewModel : BindableBase
	{
		private const string London = "London";
		private readonly ILocationWeatherService _locationWeatherService;
		private string _weatherText;
		private string _location;
		
		public ShellViewModel(ILocationWeatherService locationWeatherService)
		{
			_locationWeatherService = locationWeatherService;
			InitializeCommands();
		}

		private void InitializeCommands()
		{
			GetWeatherCommand = new DelegateCommand(GetWeather);
		}

		private void GetWeather()
		{
			Debug.WriteLine("Twoja stara");
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
		
		public ICommand GetWeatherCommand { get; private set; }
		
		public string Location
		{
			get { return _location; }
			set
			{
				_location = value;
				RaisePropertyChanged();
			}
		}
	
	}
}