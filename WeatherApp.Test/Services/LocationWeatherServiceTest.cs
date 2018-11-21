using System.Threading.Tasks;
using FluentAssertions;
using NSubstitute;
using WeatherApp.Services;
using WeatherApp.Services.Helpers;
using Xunit;

namespace WeatherApp.Test.Services
{
	public class LocationWeatherServiceTest
	{
		private IHttpConnection _httpConnectionMock;
		private LocationWeatherService _sut;

		public LocationWeatherServiceTest()
		{
			_httpConnectionMock = Substitute.For<IHttpConnection>();
			_sut = new LocationWeatherService(_httpConnectionMock);
		}

		[Fact]
		public async Task ServiceCorrectlyCreatesUrlForGivenLocation()
		{
			_httpConnectionMock.GetAsync(Arg.Any<string>()).Returns( x => Task.FromResult((string)x[0]));

			var result = await _sut.GetWeatherForNamedLocationAsync("Warsaw");

			result.Should().Be("https://api.openweathermap.org/data/2.5/weather?q=Warsaw");
		}
	}
}