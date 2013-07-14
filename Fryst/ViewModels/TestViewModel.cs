using System.Windows;
using Caliburn.Micro;

namespace Fryst.ViewModels
{
    public class TestViewModel : PropertyChangedBase
    {
        public TestViewModel(
            )
        {
            MessageBox.Show("Hey");
        }
    }
}