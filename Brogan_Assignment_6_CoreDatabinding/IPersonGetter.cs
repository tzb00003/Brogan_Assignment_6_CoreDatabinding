
namespace Brogan_Assignment_6_CoreDatabinding
{
    public interface IPersonGetter
    {
        void Add(Person person);
        void Delete(Person person);
        IEnumerable<Person> GetPeople(bool showDeleted);
        IEnumerable<Person> GetPeople(string filter, bool showDeleted);
        void SaveChanges();
    }
}