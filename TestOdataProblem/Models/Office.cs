using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestOdataProblem.Models
{
    public class Office
    {
        public Guid Id { get; set; }

        public string ZipCode { get; set; }

        public bool Active { get; set; }

        public string AddressLine { get; set; }

        public string City { get; set; }

        public IEnumerable<Employee> Employees { get; set; }
    }
}
