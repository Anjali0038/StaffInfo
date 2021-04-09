using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Staffinfo.Entities;
using Staffinfo.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Staffinfo.Controllers
{
    public class UIController : Controller
    {
        private DBContext _connection;
        private readonly IWebHostEnvironment _webHostEnvironment;
        public UIController(DBContext connection, IWebHostEnvironment webHostEnvironment)
        {
            _connection = connection;
            _webHostEnvironment = webHostEnvironment;
        }

        public IActionResult Index()
        {
            //initializing viewmodel here
            StaffViewModel model = new StaffViewModel();
            //initailizing list here
            var list = new List<StaffViewModel>();
            //get data from database
            var data = _connection.Staffs.ToList();
            //assigning entity values in viewmodel or mapping entity to viewmodel
            //check if data is null
            if (data.Count > 0)
            {
                foreach (var item in data)
                {
                    StaffViewModel objModel = new StaffViewModel();
                    objModel.Id = item.Id;
                    objModel.FullName = item.FullName;
                    objModel.Address = item.Address;
                    objModel.Gender = item.Gender;
                    objModel.FilePath = item.ProfilePath;
                    list.Add(objModel);
                }
                model.StaffList = list;
            }

            return View(model);
        }
        public ActionResult Add()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Add(StaffViewModel model)
        {
            if (model.File == null)
            {
                ModelState.AddModelError("", "File is not selected.");
                return View();
            }
            string rootFolder = _webHostEnvironment.WebRootPath;
            var guid = Guid.NewGuid().ToString();
            string fileName = @"StoreFolder/" + guid + model.File.FileName;
            string filePath = Path.Combine(rootFolder, fileName);
            using (var fileStream = new FileStream(filePath, FileMode.Create))
            {
                model.File.CopyToAsync(fileStream);
            }

            FileViewModel newfile = new FileViewModel();
            newfile.FilePath = fileName;
            newfile.FileName = model.File.FileName;
            // _connection.Staffs.Add(staffs);
            // _connection.SaveChanges();
            //return RedirectToAction("Index");
            Staff entityStaff = new Staff();
            entityStaff.FullName = model.FullName;
            entityStaff.Address = model.Address;
            entityStaff.Gender = model.Gender;
            entityStaff.ProfilePath = fileName;
            _connection.Staffs.Add(entityStaff);
            _connection.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult Delete(int id)
        {
            var item = _connection.Staffs.Where(x => x.Id == id).FirstOrDefault();
            _connection.Staffs.Remove(item);
            _connection.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult Edit(int Id)
        {

            var data = _connection.Staffs.Find(Id);
            StaffViewModel model = new StaffViewModel();
            model.FullName = data.FullName;
            model.Id = data.Id;
            model.Address = data.Address;
            model.Gender = data.Gender;
            model.FilePath = data.ProfilePath;
            return View(model);
        }
        [HttpPost]
        public ActionResult Edit(StaffViewModel model)
        {


            string rootFolder = _webHostEnvironment.WebRootPath;
            var guid = Guid.NewGuid().ToString();
            string fileName = @"StoreFolder/" + guid + model.File.FileName;
            string filePath = Path.Combine(rootFolder, fileName);
            using (var fileStream = new FileStream(filePath, FileMode.Create))
            {
                model.File.CopyToAsync(fileStream);
            }

            FileViewModel newfile = new FileViewModel();
            newfile.FilePath = fileName;
            newfile.FileName = model.File.FileName;
            //
            Staff entityStaff = new Staff();
            entityStaff.Id = model.Id;
            entityStaff.FullName = model.FullName;
            entityStaff.Address = model.Address;
            entityStaff.Gender = model.Gender;
            entityStaff.ProfilePath = fileName;
            _connection.Staffs.Update(entityStaff);
            _connection.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult _PartialStaff(string val)
        {
            StaffViewModel model = new StaffViewModel();

            model.StaffList = (from s in _connection.Staffs
                        where s.FullName.Contains(val) || s.Address.Contains(val)
                        select new StaffViewModel
                        {
                            Id=s.Id,
                            FullName=s.FullName,
                            Address=s.Address
                        }).ToList();
            //var list = new List<StaffViewModel>();

           
            ////var data = _connection.Staffs.ToList();
            ////if (data.Count > 0)
            ////{
            ////    foreach (var item in data)
            ////    {
            ////        StaffViewModel objModel = new StaffViewModel();
            ////        objModel.Id = item.Id;
            ////        objModel.FullName = item.FullName;
            ////        objModel.Address = item.Address;
            ////        objModel.Gender = item.Gender;
            ////        objModel.FilePath = item.ProfilePath;
            ////        list.Add(objModel);
            ////    }
            ////    model.StaffList = list;
            ////}

            return View(model);
        }
        public JsonResult BindDataInDropDownList()
        {
            var list = new List<StaffViewModel>();
            var data = _connection.Staffs.ToList();
            if (data.Count > 0)
            {
                foreach (var item in data)
                {
                    StaffViewModel objModel = new StaffViewModel();
                    objModel.Id = item.Id;
                    objModel.FullName = item.FullName;
                    objModel.Address = item.Address;
                    objModel.Gender = item.Gender;
                    objModel.FilePath = item.ProfilePath;
                    list.Add(objModel);
                }
            }
            return Json(data);
        }
    }
}
