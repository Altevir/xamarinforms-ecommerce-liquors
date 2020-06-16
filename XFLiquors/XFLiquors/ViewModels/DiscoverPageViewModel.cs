using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Internals;
using XFLiquors.Models;
using XFLiquors.ViewModel;

namespace XFLiquors.ViewModels
{
    public class DiscoverPageViewModel : BaseViewModel
    {
        public DiscoverPageViewModel(INavigation navigation)
        {
            Navigation = navigation;
            Groups = new ObservableCollection<Group>();
            Products = new ObservableCollection<Product>();
            BestPrices = new ObservableCollection<Product>();
            NavigateToMainPageCommand = new Command(async () => await ExecuteNavigateToMainPageCommand());
            SelectGroupCommand = new Command<Group>((model) => ExecuteSelectGroupCommand(model));
            GetGroups();
            GetProducts();
            GetBestPrices();
        }

        public Command NavigateToMainPageCommand { get; }
        public Command SelectGroupCommand { get; }
        public ObservableCollection<Group> Groups { get; set; }
        public ObservableCollection<Product> Products { get; set; }
        public ObservableCollection<Product> BestPrices { get; set; }

        void GetGroups()
        {
            Groups.Add(new Group()
            {
                groupId = 1,
                description = "WHISKEY",
                backGroundColor = "#D99D60",
                textColor = "#FFFFFF",
                selected = true,
            });

            Groups.Add(new Group()
            {
                groupId = 2,
                description = "BEER",
                backGroundColor = "Transparent",
                textColor = "#5B5F62",
            });

            Groups.Add(new Group()
            {
                groupId = 3,
                description = "LIQUERS",
                backGroundColor = "Transparent",
                textColor = "#5B5F62",
            });

            Groups.Add(new Group()
            {
                groupId = 4,
                description = "VODKA",
                backGroundColor = "Transparent",
                textColor = "#5B5F62",
            });

            Groups.Add(new Group()
            {
                groupId = 5,
                description = "WINE",
                backGroundColor = "Transparent",
                textColor = "#5B5F62",
            });
        }

        void GetProducts()
        {
            Products.Add(new Product()
            {
                image = "octomore101.png",
                description = "Bruichladdich Octomore 10.1",
                rating = 4.5,
                weight = 750,
                price = 199.99
            });

            Products.Add(new Product()
            {
                image = "ardbeg.png",
                description = "Ardbeg An Oa",
                rating = 5,
                weight = 750,
                price = 85.99
            });

            Products.Add(new Product()
            {
                image = "jack_daniels.png",
                description = "Jack Daniel's Old No. 7 Tennessee",
                rating = 4.7,
                weight = 1.75,
                price = 45.99
            });
        }

        void GetBestPrices()
        {
            BestPrices.Add(new Product()
            {
                image = "dalmore.png",
                description = "The Dalmore 12 Year",
                weight = 750,
                price = 64.99
            });

            BestPrices.Add(new Product()
            {
                image = "charlotte.png",
                description = "Bruichladdich Port Charlotte Scotch",
                weight = 700,
                price = 63.99
            });
        }

        private async Task ExecuteNavigateToMainPageCommand()
        {
            await Navigation.PopAsync();
        }

        private void ExecuteSelectGroupCommand(Group model)
        {
            var index = Groups
                .ToList()
                .FindIndex(p => p.groupId == model.groupId);

            if (index > -1)
            {
                UnselectGroupItems();

                Groups[index].selected = true;
                Groups[index].backGroundColor = "#D99D60";
                Groups[index].textColor = "#FFFFFF";
            }
        }

        void UnselectGroupItems()
        {
            Groups.ForEach((item) =>
            {
                item.selected = false;
                item.backGroundColor = "Transparent";
                item.textColor = "#5B5F62";
            });
        }
    }
}
