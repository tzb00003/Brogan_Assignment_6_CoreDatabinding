using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Brogan_Assignment_6_CoreDatabinding
{
    public class PersonListGetter : IPersonGetter
    {
        private readonly List<Person> _people = new();
        public PersonListGetter() 
        { 
            _people.Add(new Person { Name = "Alice", Age = 13, IsDeleted = false });
            _people.Add(new Person { Name = "Bob", Age = 15, IsDeleted = false });
            _people.Add(new Person { Name = "Charlie", Age = 23, IsDeleted = false });
        }
        public void Add(Person person)
        {
            _people.Add(person);
        }

        public void Delete(Person person)
        {
            person.IsDeleted = !person.IsDeleted;
        }

        public IEnumerable<Person> GetPeople(bool showDeleted)
        {
            if (showDeleted)
            {
                return _people
                    .OrderBy(person => person.Age)
                    .ToList();
            }
            else
            {
                return _people
                     .Where(person =>
                     !person.IsDeleted)
                     .OrderBy(person => person.Age)
                     .ToList();
            }
        }

        public IEnumerable<Person> GetPeople(string filter, bool showDeleted)
        {
            if (String.IsNullOrEmpty(filter))
            {
                GetPeople(showDeleted);
            }
            if (showDeleted)
            {
                return _people
                    .Where(person => (person.Name! ?? "").ToLower()!.Contains(filter.ToLower()))
                    .OrderBy(person => person.Age)
                    .ToList();
            }
            else
            {
                return _people
                     .Where(person => (person.Name! ?? "").ToLower()!.Contains(filter.ToLower())
                     && person.IsDeleted == false)
                     .OrderBy(person => person.Age)
                     .ToList();
            }
        }

        public void SaveChanges()
        {
            
        }
    }
}
