using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Brogan_Assignment_6_CoreDatabinding
{
    public interface IPersonGetter
    {
        public IEnumerable<Person> GetPeople();
        public IEnumerable<Person> GetPeople(string filter, bool showDeleted);
    }
}
