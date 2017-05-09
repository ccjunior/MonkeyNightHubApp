using MonkeyHubApp.Services;
using MonkeyHubApp.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace MonkeyHubApp
{
    public partial class MainPage
    {
        private MainViewModel ViewModel => BindingContext as MainViewModel;

        public MainPage()
        {
            InitializeComponent();
            var monkeyHubApiService = DependencyService.Get<IMonkeyHubApiService>();
            BindingContext = new MainViewModel(monkeyHubApiService);
        }

        protected override async void OnAppearing()
        {
            base.OnAppearing();

            if (ViewModel != null)
                await ViewModel.LoadAsync();
        }
    }
}
