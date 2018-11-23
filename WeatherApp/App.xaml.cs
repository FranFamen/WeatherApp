using System.Windows;
using Prism.Ioc;
using WeatherApp.Services;
using WeatherApp.Services.Helpers;
using WeatherApp.Views;

namespace WeatherApp
{
    public partial class App
    {
        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.Register<IHttpConnection, HttpConnection>();
            containerRegistry.Register<ILocationWeatherService, LocationWeatherService>();
        }

        protected override Window CreateShell()
        {
            return Container.Resolve<ShellView>();
        }
    }
}
