using MonkeyHubApp.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace MonkeyHubApp
{
    public partial class CategoriaPage 
    {
        private CategoriaViewModel ViewModel => BindingContext as CategoriaViewModel;

        public CategoriaPage()
        {
            InitializeComponent();
        }

        protected override async void OnAppearing()
        {
            base.OnAppearing();

            if (ViewModel != null)
                await ViewModel.LoadAsync();
        }
    }
}
