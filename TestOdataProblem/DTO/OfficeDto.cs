using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestOdataProblem.DTO
{
    public class OfficeDto
    {
        public Guid Id { get; set; }

        public string City { get; set; }

        public string ZipCode { get; set; }

        public string AddressLine { get; set; }

        public bool Active { get; set; }

        public IEnumerable<EmployeeDto> Employees { get; set; }
    }
}
