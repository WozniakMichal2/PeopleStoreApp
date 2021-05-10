using System.Threading.Tasks;

namespace PeopleStoreApp
{
    internal interface IPeopleClient
    {
        Task AddPersonAsync(Person person);
    }
}