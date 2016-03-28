using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
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
    }
}
