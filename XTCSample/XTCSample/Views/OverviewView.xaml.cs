using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using XTCSample.Models;
using XTCSample.ViewModels;

namespace XTCSample.Views
{
    public partial class OverviewView : ContentPage
    {
        public MainViewModel Vm => (MainViewModel) BindingContext;

        public OverviewView()
        {
            InitializeComponent();

            BindingContext = App.Locator.Main;

            Init();
        }

        private async void Init()
        {
            await Vm.Init();
        }

        private async void ListView_OnItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var selectedPerson = (Person) PeopleListView.SelectedItem;
            await Navigation.PushAsync(new DetailView(selectedPerson));
            PeopleListView.SelectedItem = null;
        }
    }
}
