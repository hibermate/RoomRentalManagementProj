using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using RoomRentalManagementProj.SysModel;

namespace RoomRentalManagementProj.Controllers
{
    [Authorize]
    [RoutePrefix("api/Employee")]
    public class EmployeeController : ApiController
    {
        [AllowAnonymous]
        [Route("Register")]
        public IEnumerable<Employee> GetAllEmloyee()   
            {
            RoomRentalManagemenDBtEntities1 db = new RoomRentalManagemenDBtEntities1();
            var employees = db.Employees.ToList();
            Employee emp = new Employee();
            emp = employees.FirstOrDefault();
            return db.Employees.ToList();
            
        }

    }
}
