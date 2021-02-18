using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestOdataProblem.Db;
using TestOdataProblem.DTO;
using TestOdataProblem.Models;

namespace TestOdataProblem.Controllers
{
    [Route("api/Offices")]
    public class OfficesController : Controller
    {
        private TestOdataContext _context;
        public OfficesController(TestOdataContext context)
        {
            _context = context;
        }

        [HttpPost]
        public IActionResult Post(OfficeDto office)
        {
            Office officeToIns = new Office()
            {
                Id = Guid.NewGuid(),
                Active = true,
                AddressLine = office.AddressLine,
                City = office.City
            };

            this._context.Offices.Add(officeToIns);

            //foreach (EmployeeDto item in office.Employees)
            //{
            //    Employee employeeToAdd = new Employee()
            //    {
            //        Id = Guid.NewGuid(),
            //        OfficeId = officeToIns.Id,
            //        Name = item.Name,
            //        Birthday = item.Birthday
            //    };

            //    this._context.Employees.Add(employeeToAdd);
            //}

            //this._context.SaveChanges();

            return Ok();
        }
    }
}
