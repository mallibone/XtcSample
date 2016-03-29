using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GalaSoft.MvvmLight;
using XTCSample.Models;

namespace XTCSample.ViewModels
{
    public class DetailViewModel:BaseViewModel
    {
        private Person _selectedPerson;

        public Person SelectedPerson
        {
            get { return _selectedPerson; }
            set
            {
                _selectedPerson = value;
                RaisePropertyChanged(nameof(FirstName));
                RaisePropertyChanged(nameof(LastName));
            }
        }

        public string FirstName => SelectedPerson.FirstName;
        public string LastName => SelectedPerson.LastName;

        public void Init(Person selectedPerson)
        {
            SelectedPerson = selectedPerson;
        }
    }
}
