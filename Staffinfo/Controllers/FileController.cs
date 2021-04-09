using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Staffinfo.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Staffinfo.Controllers
{
    public class FileController : Controller
    {
        private readonly IHostingEnvironment _hostingEnvironment;
        public FileController(IHostingEnvironment hostingEnvironment)
        {

            _hostingEnvironment = hostingEnvironment;
        }

        [HttpGet]
        public ActionResult AddFile()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddFile(FileViewModel model)
        {
            if (model.File == null)
            {
                ModelState.AddModelError("", "File is not selected.");
                return View();
            }
            string rootFolder = _hostingEnvironment.WebRootPath;
            var guid = Guid.NewGuid().ToString();
            string fileName = @"StoreFolder/" + guid + model.File.FileName;
            string filePath = Path.Combine(rootFolder, fileName);
            using (var fileStream = new FileStream(filePath, FileMode.Create))
            {
                model.File.CopyToAsync(fileStream);
            }
            model.FilePath = fileName;
            FileViewModel newfile = new FileViewModel();
            newfile.FilePath = fileName;
            newfile.FileName = model.File.FileName;
            return RedirectToAction("Index");
        }
    }
}
