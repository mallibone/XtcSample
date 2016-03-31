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
                if(value == null || value ==_selectedPerson) return;
                _selectedPerson = value;
                RaisePropertyChanged(nameof(FirstName));
                RaisePropertyChanged(nameof(LastName));
            }
        }

        public string FirstName
        {
            get { return SelectedPerson.FirstName; }
            set
            {
                if(value == SelectedPerson.FirstName) return;
                SelectedPerson.FirstName = value;
                RaisePropertyChanged(nameof(FirstName));
            }
        }

        public string LastName
        {
            get { return SelectedPerson.LastName; }
            set
            {
                if (value == SelectedPerson.LastName) return;
                SelectedPerson.LastName = value;
                RaisePropertyChanged(nameof(LastName));
            }
        }

        public void Init(Person selectedPerson)
        {
            SelectedPerson = selectedPerson;
        }
    }
}
