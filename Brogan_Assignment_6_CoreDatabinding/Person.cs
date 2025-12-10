using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Brogan_Assignment_6_CoreDatabinding
{
    public class Person
    {
        public int Id { get; set; }

        public string? Name { get; set; }

        public int Age  { get; set; }

        public bool IsDeleted { get; set; } = false;

        public Person()

            { }
    }
}
