using System.Threading.Tasks;
using Xamarin.Forms;
using XFLiquors.ViewModel;
using XFLiquors.Views;

namespace XFLiquors.ViewModels
{
    public class MainPageViewModel : BaseViewModel
    {
        public MainPageViewModel(INavigation navigation)
        {
            Navigation = navigation;
            Company = "R & L";
            NavigateToDiscoverPageCommand = new Command(async () => await ExecuteNavigateToDiscoverPageCommand());
        }

        public Command NavigateToDiscoverPageCommand { get; }

        private string _company;
        public string Company
        {
            get { return _company; }
            set { SetProperty(ref _company, value); }
        }

        private async Task ExecuteNavigateToDiscoverPageCommand()
        {
            await Navigation.PushAsync(new DiscoverPage());
        }
    }
}
