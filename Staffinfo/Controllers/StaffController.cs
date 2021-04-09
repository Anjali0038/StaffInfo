using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Staffinfo.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
namespace Staffinfo.Controllers
{
    [Route("api/[controller]")]
    public class StaffController : ControllerBase
    {
        private readonly DBContext _connection;
        public StaffController(DBContext connection)
        {
            _connection = connection;
        }
        [HttpGet]
        [Route("GetStaffList")]
        public IActionResult GetStaffList()
        {
            var data = _connection.Staffs.ToList();
            return Ok(data);
        }
    }
}
