using System.Windows.Input;
using WpfApp6.Model;
using WpfApp6.Services;

namespace WpfApp6.ViewModels
{
    public class UserControl1ViewModel : BaseViewModel, IPageViewModel
    {
        private ICommand _goTo2;

        public ICommand GoTo2
        {
            get
            {
                return _goTo2 ?? (_goTo2 = new RelayCommand(x =>
                {
                    Mediator.Notify("GoTo2Screen", "");
                }));
            }
        }
    }
}
