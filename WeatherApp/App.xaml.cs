using System.Windows;
using Newtonsoft.Json;
using Prism.Ioc;
using WeatherApp.Services;
using WeatherApp.Services.Helpers;
using WeatherApp.Views;
using JsonConverter = WeatherApp.Services.Helpers.JsonConverter;

namespace WeatherApp
{
    public partial class App
    {
        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.Register<IHttpConnection, HttpConnection>();
            containerRegistry.Register<ILocationWeatherService, LocationWeatherService>();
            containerRegistry.Register<IJsonConverter, JsonConverter>();
        }

        protected override Window CreateShell()
        {
            return Container.Resolve<ShellView>();
        }
    }
}
