using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Brogan_Assignment_6_CoreDatabinding
{
    public class PersonContextGetter : IPersonGetter
    {
        private PersonContext db = new PersonContext();

        public IEnumerable<Person> GetPeople()
        {
            return db.People.Local.ToList();
        }

        public IEnumerable<Person> GetPeople(string filter, bool showDeleted)
        {
            if (showDeleted)
            { 
            return db.People.Local
                    .Where(person => (person.Name! ?? "").ToLower()!.Contains(filter.ToLower()))
                    .OrderBy(person => person.Age)
                    .ToList();
            }
            else
            {
                return db.People.Local
                    .Where(person => (person.Name! ?? "").ToLower()!.Contains(filter.ToLower())
                    && person.IsDeleted == false)
                    .OrderBy(person => person.Age)
                    .ToList();
            }
        }
    }
}
