using System.Collections.Generic;
using System.Threading.Tasks;

namespace XTCSample.Services.Person.Impl
{
    public class PeopleServiceStub:IPeopleService
    {
        public Task<IEnumerable<Models.Person>> GetPeople(int count = 100)
        {
            int numberOfPeopleToGenerate = count;
            return Task.Run(() => GeneratePeople(numberOfPeopleToGenerate));
        }

        static public IEnumerable<Models.Person> GeneratePeople(int personCount)
        {
            var people = new List<Models.Person>(personCount);

            for (int i = 0; i < personCount; ++i)
            {
                people.Add(new Models.Person(NameGenerator.GenRandomFirstName(), NameGenerator.GenRandomLastName()));
            }

            return people;
        }
    }
}