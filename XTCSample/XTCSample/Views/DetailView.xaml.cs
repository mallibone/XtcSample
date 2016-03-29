using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using XTCSample.Models;

namespace XTCSample.Views
{
    public partial class DetailView : ContentPage
    {
        public DetailView(Person selectedItem)
        {
            InitializeComponent();
        }
    }
}
