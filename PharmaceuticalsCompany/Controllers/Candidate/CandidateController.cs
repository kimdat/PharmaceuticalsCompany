using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PharmaceuticalsCompany.Services.Candidate;
using PharmaceuticalsCompany.Models.Candidate;
namespace PharmaceuticalsCompany.Controllers.Candidate
{
    public class CandidateController : Controller
    {
        private  ICandidateService services;
        public CandidateController(ICandidateService services)
        {
            this.services = services;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Login(CandidateModel candidate)
        {

                var model = await services.Login(candidate);
                if (model != null)
                {

                    ViewBag.Msg = "success";
                    return RedirectToAction("index", "Home");


                }
                else
                {
                    ViewBag.Msg = "invalid";
                }
               
            
           
            return View();

        }
        public IActionResult Register()
        {

            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Register(CandidateModel candidate)
        {
          
                try
                {
                    var result = await services.Register(candidate);
                    if (result != null)
                    {
                       
                        return RedirectToAction("index", "Home");
                    }
                    else
                    {
                   
                    }

                }
                catch (Exception e) 
                {

                    ModelState.AddModelError(string.Empty, e.Message);
                }
          
            return View();
        }
    }
}