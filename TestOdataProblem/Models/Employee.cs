using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace TestOdataProblem.Models
{
    public class Employee
    {
        public Guid Id { get; set; }
        public string Name { get; set; }

        public DateTime Birthday { get; set; }

        [ForeignKey("Office")]
        public Guid OfficeId { get; set; }
        public Office Office { get; set; }
    }
}
