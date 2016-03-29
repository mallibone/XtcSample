using System;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using XTCSample.Models;
using XTCSample.Services.Person;

namespace XTCSample.ViewModels
{
    public class MainViewModel:BaseViewModel
    {
        private readonly IPeopleService _peopleService;

        public MainViewModel(IPeopleService peopleService)
        {
            if (peopleService == null) throw new ArgumentNullException(nameof(peopleService));
            _peopleService = peopleService;

            People = new ObservableCollection<Person>();
        }

        public ObservableCollection<Person> People { get; }

        public async Task Init()
        {
            IsLoading = true;

            var people = await _peopleService.GetPeople(30);
            People.Clear();
            foreach (var person in people)
            {
                People.Add(person);
            }

            IsLoading = false;
        }
    }
}
