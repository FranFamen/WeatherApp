using System.Windows;
using WeatherApp.ViewModels;

namespace WeatherApp.Views
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class ShellView : Window
    {
        public ShellView()
        {
            InitializeComponent();
            this.Loaded += async (sender, args) =>
            {
                var viewModel = DataContext as ShellViewModel;
                await viewModel.OnLoadAsync();
            };
        }
        
        
    }
}
