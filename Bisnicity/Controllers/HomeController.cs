/*************************************************************************************************************/
/*Class Name    : HomeController.cs                                                                       /
/*Created By    : samer sami                                                                            */
/*Ceation Date  :                                                                            */
/******************************************************************************************************/
using Bisnicity.Helper;
using Bisnicity.Models;
using BisnicityApp.Entites;
using BisnicityApp.InterFaces;
using Infrastrucer;
using Infrastrucer.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Localization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Bisnicity.Controllers
{
    [AllowAnonymous]
    public class HomeController : Controller
    {
        #region Members
        private readonly DataContext dataContext;
        private readonly IBisnicity<PostCompany> addpost;
        private readonly IBisnicity<Gender> gender;
        private readonly IBisnicity<Datavocational> addvocational ;
        private readonly IBisnicity<ContactUs> contactus;
        private readonly IBisnicity<volunteer> ovolunteer;
        private readonly IHostingEnvironment hosting;
        private readonly IBisnicity<yourstatus> status;
        private readonly IBisnicity<CareerPath> career;
        private readonly SignInManager<ApplicationUser> osignInManager;


        public HomeController( DataContext _dataContext, IBisnicity<PostCompany> _addpost,IHostingEnvironment hosting,IBisnicity<Gender> _gender, IBisnicity<Datavocational> _addvocational , 
            IBisnicity<ContactUs> _contactus,IBisnicity<volunteer> _volunteer, IBisnicity<yourstatus> _status, IBisnicity<CareerPath> _career, SignInManager<ApplicationUser> _osignInManager)
        {
            dataContext = _dataContext;
            addpost = _addpost;
            this.hosting = hosting;
            gender = _gender;
            addvocational = _addvocational;
            contactus = _contactus;
            ovolunteer = _volunteer;
            status = _status;
            career = _career;
            osignInManager = _osignInManager;
        }
        #endregion
        #region Methods
        [HttpPost]
        public  IActionResult SetLanguage(string culture,string returnurl)
        {
            Response.Cookies.Append(
                CookieRequestCultureProvider.DefaultCookieName,
                CookieRequestCultureProvider.MakeCookieValue(new RequestCulture(culture)),new CookieOptions { Expires=DateTimeOffset.UtcNow.AddYears(1)}
                );
            return LocalRedirect(returnurl);
        }
        public IActionResult Index1()
        {

            return View();
        }
        public IActionResult BuntEN()
        {
            return View();

        }
        public IActionResult TypeOFTranning()
        {
            return View();
        }
        public IActionResult BlogsEN()
        {
            var listpost = addpost.List();


            return View(listpost);
        }
    
        public IActionResult TraAndJobEn()
        {
            return View();
        }


        public IActionResult BenefitsOfTranning()
        {
            return View();
        }


       public IActionResult ShowTran()
        {
            return View();
        }

        public async Task<IActionResult> Logout()
        {
            HttpContext.Session.Clear();
            await osignInManager.SignOutAsync();

            return RedirectToAction("Index1", "Home");
        }

        public IActionResult LogoutPerson()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("Index1", "Home");
        }

        public IActionResult AboutUs()
        {
                return View();  
        }

        public  IActionResult IdeashowEn()
        {
            return View();
        }


        public IActionResult VocationalEn()
        {
            return View();
        }
        public IActionResult AddVocational()
        {
            var signview = new DataVocationalViewModel
            {

                CareerPaths = fillselectcareer(),
                yourstatuses = fillselectstatus(),
                Genders = fillselectgender()
            };
            return View(signview);
        }
        [HttpPost]
        public IActionResult AddVocational(DataVocationalViewModel model)
        {
            if (model.carereid == -1 && model.genderID == -1 && model.statusid == -1)
            {

                var osignview = new DataVocationalViewModel
                {
                    CareerPaths = fillselectcareer(),
                    yourstatuses = fillselectstatus(),
                    Genders = fillselectgender()
                };
                TempData["messsages"] = "please chosee ";
                return View(osignview);
            }

            var findcareer = career.Find(model.carereid);
            int careerid = findcareer.CareerPathID;

            var findstsatus = status.Find(model.statusid);
            int idstatus = findstsatus.yourstatusID;

            var findgender = gender.Find(model.genderID);
            int idgender = findgender.GenderID;

            var addvaco = new Datavocational
            {
                Name = model.Name,
                Email = model.Email,
                phoneeNo = model.phoneeNo,
                DateOfBirth = model.DateOfBirth,
                CareerPathID = careerid,
                GenderID = idgender,
                yourstatusID = idstatus
            };

            addvocational.Add(addvaco);
            return RedirectToAction("VocationalEn", "Home", TempData["message"] = "Sucssfuly");
        }
        public IActionResult volunteer()
        {
            var signview = new volunteerViewModel
            {
                Genders = fillselectgender()
            };
            return View(nameof(volunteer),signview);
        }

        [HttpPost]
        public IActionResult volunteer(volunteerViewModel model)
        {
            if (model.genderID == -1)
            {
               
                var osignview = new volunteerViewModel
                {
                    Genders = fillselectgender()
                };
                TempData["messsages"] = "please chosee gender ";
                return View(nameof(volunteer), osignview);
            }
            var findgender = gender.Find(model.genderID);
            int idgender = findgender.GenderID;
            var addovolunteer = new volunteer
            {
                Name=model.Name,
                NationalID=model.NationalID,
                Major=model.Major,
                GenderID=idgender,
                BirthDay=model.BirthDay,
                PhoneNo=model.PhoneNo,
                Email=model.Email,
                Address=model.Address,
                City=model.City,
                Descrption=model.Descrption
            };
            ovolunteer.Add(addovolunteer);
            TempData["message"] = "Sucssfuly";
            return RedirectToAction("volunteer", "Home");
        }
        public IActionResult ShowCompanyJob(string job)
        {
            if (job != null)
            {
                List<ShowCompanyViewmodel> oShowCompanyViewModelq = new List<ShowCompanyViewmodel>();

                jobVacancy[] listjobq = dataContext.jobVacancy.Where(x => x.JobType.Contains(job)).ToList().ToArray();

                if (listjobq != null && listjobq.Length > 0)
                {
                    foreach (var item in listjobq.ToList())
                    {

                        oShowCompanyViewModelq.Add(new ShowCompanyViewmodel
                        {
                            Email = item.Email,
                            CompanyName = item.CompanyName,
                            PhoneNo = item.PhoneNo,
                            Linklinkedin = item.LinkkedIn,
                            Experience = item.Experience,
                            Requirements = item.Requirements,
                            City = item.Address,
                            userid = item.UserId,
                            NameJob = item.JobName,
                            jobvacancyid = item.jobVacancyID,
                        });

                    }
                    //return View(postdata);
                    return View(oShowCompanyViewModelq.ToList());
                }
            }
            List<ShowCompanyViewmodel> oShowCompanyViewModel = new List<ShowCompanyViewmodel>();
            jobVacancy[] listjob = dataContext.jobVacancy.ToList().ToArray();
            if (listjob != null && listjob.Length > 0)
            {
                foreach (var item in listjob.ToList())
                {

                    oShowCompanyViewModel.Add(new ShowCompanyViewmodel
                    {
                        Email = item.Email,
                        CompanyName = item.CompanyName,
                        PhoneNo = item.PhoneNo,
                        Linklinkedin = item.LinkkedIn,
                        Experience = item.Experience,
                        Requirements = item.Requirements,
                        City = item.Address,
                        userid = item.UserId,
                        NameJob = item.JobName,
                        jobvacancyid = item.jobVacancyID,
                    });

                }

                return View(oShowCompanyViewModel.ToList());
            }
            else
            {
                return View();
            }
        }


        public IActionResult TranningEN()
        {
            return View();
        }
        public IActionResult ITsolution()
        {

            return View();
            
        }

        public IActionResult ContactUs()
        {
            return View();
        }

        [HttpPost]
        public IActionResult ContactUs(ContactUs model)
        {
            if(!ModelState.IsValid)
            {
                return View();
            }
            else
            {
                contactus.Add(model);
                return RedirectToAction("ContactUs","Home", TempData["message"] = "Add Succ");
            }
          
        }

        public IActionResult indexshowcomp()
        {
            return View();
        }
        #endregion
        #region List
        List<Gender> fillselectgender()
        {
            var genderlist = gender.List().ToList();
            genderlist.Insert(0, new Gender { GenderID = -1, GenderName = "----please select Gender------" });
            return genderlist;

        }
        List<yourstatus> fillselectstatus()
        {
            var typelist = status.List().ToList();
            typelist.Insert(0, new yourstatus { yourstatusID = -1, NameStatus = "----please select an Your Status------" });
            return typelist;

        }

        List<CareerPath> fillselectcareer()
        {
            var typelist = career.List().ToList();
            typelist.Insert(0, new CareerPath { CareerPathID = -1, NameCareer = "----please select an Career Path------" });
            return typelist;

        }
       
        #endregion

    }
}
