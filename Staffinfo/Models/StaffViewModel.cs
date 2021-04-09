using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace Staffinfo.Models
{
    public class StaffViewModel
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public string Address { get; set; }
        public string Gender { get; set;}
        public IFormFile File { get; set; }
        public string FilePath { get; set; }
        public List<StaffViewModel> StaffList { get; set; }
        public StaffViewModel()
        {
            StaffList = new List<StaffViewModel>();
        }
    }
}
