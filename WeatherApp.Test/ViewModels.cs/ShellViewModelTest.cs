using System.Threading.Tasks;
using FluentAssertions;
using NSubstitute;
using WeatherApp.Services;
using WeatherApp.ViewModels;
using Xunit;

namespace WeatherApp.Test.ViewModels.cs
{
	public class ShellViewModelTest
	{
		private const string London = "London";
		private const string Success = "Success";
		private ShellViewModel _sut;
		private ILocationWeatherService _locationWeatherServiceMock;
		
		public ShellViewModelTest()
		{
			_locationWeatherServiceMock = Substitute.For<ILocationWeatherService>();
			_sut = new ShellViewModel(_locationWeatherServiceMock);
		}

		[Fact]
		public async Task LoadingViewModelShouldRequestWeatherForSavedLocation()
		{
			var result = "";
			_locationWeatherServiceMock.GetWeatherForNamedLocationAsync(London).Returns(x =>
			{
				result = Success;
				return Task.FromResult(Success);
			});
			
			await _sut.OnLoadAsync();

			result.Should().Be(Success);
		}
	}
}