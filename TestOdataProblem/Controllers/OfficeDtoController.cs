using Microsoft.AspNet.OData;
using Microsoft.AspNet.OData.Query;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestOdataProblem.Db;
using TestOdataProblem.DTO;

namespace TestOdataProblem.Controllers
{
   //  [Route("api/[controller]")]
    // [ApiExplorerSettings(IgnoreApi = false)]
    public class OfficeDtoController : ODataController
    {
        private static readonly ODataValidationSettings VALIDATIONSETTINGS = new ODataValidationSettings()
        {
            MaxTop = 1000,
            MaxAnyAllExpressionDepth = 10,
            MaxExpansionDepth = 10,
            AllowedFunctions = AllowedFunctions.AllFunctions,
            AllowedQueryOptions = AllowedQueryOptions.All,
            AllowedLogicalOperators = AllowedLogicalOperators.All
        };

        private TestOdataContext _context;
        public OfficeDtoController(TestOdataContext context)
        {
            _context = context;
        }

        [HttpGet]
        [EnableQuery(EnsureStableOrdering = false)]
        public IActionResult GetOfficeDto(ODataQueryOptions<OfficeDto> queryOptions)
        {
            try
            {
                queryOptions.Validate(VALIDATIONSETTINGS);
            }
            catch (Microsoft.Data.OData.ODataException ex)
            {
                return BadRequest(ex.Message);
            }

            var resultt = _context.Offices.Select(z => new OfficeDto()
            {
                Id = z.Id,
                AddressLine = z.AddressLine,
                ZipCode = z.ZipCode,
                City = z.City,
                Active = z.Active,
                Employees = z.Employees.Select(f => new EmployeeDto()
                {
                    Id = f.Id,
                    Name = f.Name
                })
            });

            return Ok(resultt);
        }
    }
}
