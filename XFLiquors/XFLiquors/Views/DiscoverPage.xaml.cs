using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XFLiquors.ViewModels;

namespace XFLiquors.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DiscoverPage : ContentPage
    {
        public DiscoverPage()
        {
            InitializeComponent();
            BindingContext = new DiscoverPageViewModel(Navigation);
        }
    }
}