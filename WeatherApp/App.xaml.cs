using System.Windows;
using Prism.Ioc;
using WeatherApp.Views;

namespace WeatherApp
{
    public partial class App
    {
        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            
        }

        protected override Window CreateShell()
        {
            return Container.Resolve<ShellView>();
        }
    }
}
