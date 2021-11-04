using Bisnicity.Helper;
using Bisnicity.Models;
using BisnicityApp.Entites;
using BisnicityApp.InterFaces;
using Infrastrucer;
using Infrastrucer.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Bisnicity.Controllers
{
    public class CoachController : Controller
    {
        #region Members

        private readonly DataContext dataContext;
        private readonly IBisnicity<Univircity> uni;
        private readonly IBisnicity<Educationlevel> edu;
        private readonly IHostingEnvironment hosting;
        private readonly IBisnicity<coach> Icoach;


        #endregion
        #region Ctor

        public CoachController(DataContext _dataContext, IBisnicity<Univircity> _uni, IBisnicity<Educationlevel> _edu, IHostingEnvironment _hosting, IBisnicity<coach> _Icoach)
        {
            dataContext = _dataContext;
            uni = _uni;
            edu = _edu;
            hosting = _hosting;
            Icoach = _Icoach;
        }
        #endregion
        #region Actions

        public IActionResult CompleteProfileCoach()
        {
            var objComplex = HttpContext.Session.GetObject<ApplicationUser>("UserInfo");
            int flag = dataContext.coach.Where(x => x.UserId == objComplex.Id).Select(x => x.Flag).FirstOrDefault();
            if (flag == 1)
            {
                return RedirectToAction("IndexCoach", "Coach");
            }
            else
            {
                var signview = new CoachViewModel
                {
                    Educationlevels = fillselect(),
                    univircitys = FillselectUni()
                };
                return View(nameof(CompleteProfileCoach),signview);
            }
        }
        [HttpPost]
        public IActionResult CompleteProfileCoach(CoachViewModel model)
        {
            var objComplex = HttpContext.Session.GetObject<ApplicationUser>("UserInfo");
            if (model.levelID == -1 && model.uniID == -1)
            {
                var osignview = new CoachViewModel
                {

                    Educationlevels = fillselect(),
                    univircitys = FillselectUni()
                };
                TempData["messsages"] = "please chosee Gender and Level Educations and univircity";
                return View(nameof(CompleteProfileCoach), osignview);

            }
            string crt = string.Empty;
            if (!ModelState.IsValid)
            {
                var osignview = new CoachViewModel
                {

                    Educationlevels = fillselect(),
                    univircitys = FillselectUni()
                };
                return View(nameof(CompleteProfileCoach), osignview);
            }
            if (model.Fcertificte != null)
            {
                crt = UploadedFileCv(model);
            }
            var edufind = edu.Find(model.levelID);
            var unifind = uni.Find(model.uniID);
            int eduid = edufind.EducationlevelID;
            int uniID = unifind.UnivircityID;
            var listcoach = new coach
            {
                Address=model.Address,
                Type=model.Type,
                Expireance=model.Expireance,
                EducationlevelID = eduid,
                UnivircityID = uniID,
                certificte = crt != string.Empty ? crt : string.Empty,
                UserId = objComplex.Id,
                Flag = 1

            };
            if(listcoach!=null)
            {
                Icoach.Add(listcoach);
                return RedirectToAction("IndexCoach", "Coach");
            }
            return View(nameof(CompleteProfileCoach), model);
        }


        public IActionResult IndexCoach()
        {
            var objComplex = HttpContext.Session.GetObject<ApplicationUser>("UserInfo");
            if (objComplex == null)
            {
                return RedirectToAction("Login", "Account");
            }
            else
            {
                var listcoach=dataContext.coach.SingleOrDefault(x => x.UserId == objComplex.Id);
                var coach = new CoachProfileViewModel
                {
                    FirstName = objComplex.sFirstname,
                    LastName = objComplex.sLastname,
                    Email = objComplex.Email,
                    PhoneNo = objComplex.PhoneNumber,
                    Address = listcoach.Address,
                    Type=listcoach.Type,
                    Expireance=listcoach.Expireance

                };
                return View(coach);
            }
        }
        #endregion
        #region List

        List<Educationlevel> fillselect()
        {
            var edulist = edu.List().ToList();
            edulist.Insert(0, new Educationlevel { EducationlevelID = -1, levelName = "----please select an Education Level------" });
            return edulist;

        }

        List<Univircity> FillselectUni()
        {
            var unilist = uni.List().ToList();
            unilist.Insert(0, new Univircity { UnivircityID = -1, UniName = "------ please select Univircity Name" });
            return unilist;
        }
        #endregion
        #region Methods
        private string UploadedFileCv(CoachViewModel model)
        {
            String FileExt = Path.GetExtension(model.Fcertificte.FileName).ToUpper();
            string uniqueFileName = null;
            if (FileExt == ".PDF")
            {
                string uploadsFolder = Path.Combine(hosting.WebRootPath, "uploadsCV");
                uniqueFileName = Guid.NewGuid().ToString() + "_" + model.Fcertificte.FileName;
                string filePath = Path.Combine(uploadsFolder, uniqueFileName);
                using (var fileStream = new FileStream(filePath, FileMode.Create))
                {
                    model.Fcertificte.CopyTo(fileStream);
                }

            }
            return uniqueFileName;
        }

        #endregion

    }
}
