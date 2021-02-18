using System;

namespace TestOdataProblem.DTO
{
    public class EmployeeDto
    {
        public Guid Id { get; set; }
        public string Name { get; set; }

        public DateTime Birthday { get; set; }
    }
}
