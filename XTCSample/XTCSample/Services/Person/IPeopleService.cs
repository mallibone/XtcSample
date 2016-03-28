using System.Collections.Generic;
using System.Threading.Tasks;

namespace XTCSample.Services.Person
{
    public interface IPeopleService
    {
        Task<IEnumerable<Models.Person>> GetPeople(int count = 100);
    }
}