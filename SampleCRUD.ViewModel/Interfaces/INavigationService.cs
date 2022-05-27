using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleCRUD.ViewModel.Interfaces
{
    public interface INavigationService
    {
        public void GoBack();
        public bool CanGoBack();
        public void Navigate<TViewModel>(object parameter = null);
    }
}
