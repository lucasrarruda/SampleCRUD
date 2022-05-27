using Microsoft.Toolkit.Mvvm.DependencyInjection;
using Microsoft.UI.Xaml.Controls;
using SampleCRUD.ViewModel.ViewModels;

// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace SampleCRUD.View.Views
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MenuView : Page
    {
        public MenuView()
        {
            this.InitializeComponent();

            DataContext = Ioc.Default.GetRequiredService<MenuViewModel>();
        }
    }
}
