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
    public partial class DetailView : ContentPage
    {
        public DetailViewModel Vm => (DetailViewModel) BindingContext;

        public DetailView(Person selectedPerson)
        {
            InitializeComponent();

            BindingContext = App.Locator.Detail;

            Vm.Init(selectedPerson);
        }
    }
}
