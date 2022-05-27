using Microsoft.UI.Xaml.Controls;
using SampleCRUD.ViewModel.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleCRUD.ViewModel.Services
{
    public class NavigationService : INavigationService
    {
        private readonly Frame _frameNavigator;

        public NavigationService(Frame frameNavigator) => _frameNavigator = frameNavigator;

        public bool CanGoBack()
        {
            throw new NotImplementedException();
        }

        public void GoBack()
        {
            throw new NotImplementedException();
        }

        public void Navigate<TViewModel>(object parameter = null)
        {
            _frameNavigator.Navigate(typeof(TViewModel), parameter);
        }
    }
}
