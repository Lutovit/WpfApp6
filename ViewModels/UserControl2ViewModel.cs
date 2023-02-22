using System.Windows.Input;
using WpfApp6.Model;
using WpfApp6.Services;

namespace WpfApp6.ViewModels
{
    public class UserControl2ViewModel : BaseViewModel, IPageViewModel
    {
        private ICommand _goTo1;

        public ICommand GoTo1
        {
            get
            {
                return _goTo1 ?? (_goTo1 = new RelayCommand(x =>
                {
                    Mediator.Notify("GoTo1Screen", "");
                }));
            }
        }
    }
}
