using System.Windows;
using Caliburn.Micro;

namespace Fryst.ViewModels
{
    public class ShellViewModel : Screen
    {
        private readonly INavigationService _navigationService;

        public ShellViewModel(INavigationService navigationService)
        {
            _navigationService = navigationService;
            _navigationService.UriFor<MapViewModel>().Navigate();
            MessageBox.Show("Hey");
        }
    }
}