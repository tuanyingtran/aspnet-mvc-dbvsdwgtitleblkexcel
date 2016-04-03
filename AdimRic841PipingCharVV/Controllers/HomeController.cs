using AdimRic841PipingCharVV.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AdimRic841PipingCharVV.Services;
using System.Threading.Tasks;

namespace AdimRic841PipingCharVV.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppServices _appServices;

        public HomeController() : this(new AppServices()){}

        public HomeController(AppServices services)
        {
            _appServices = services;
        }
        public ActionResult Index()
        {
           //DataTablePopulate.PopulateFunctionalLocationTable();

            return View();
        }

        //Get all rows in Functional table
        public ActionResult DisplayData()
        {
            //_appServices.UpdateDbApiPipeClass();
            var funcLoc = _appServices.GetFunctionalLocationModels();
           
            return View(funcLoc);
        }//good

        public ActionResult DisplayDwgData()
        {
            var dwgData = _appServices.GetDwgData();
            return View(dwgData);
        }


        public ActionResult ValidateApiPipeClass()
        {
            var dwgData = _appServices.ValidateApiPipeClass();
            return View(dwgData);
        }

        public ActionResult ValidateRefineryPipeClass()
        {
            var dwgData = _appServices.ValidateRefineryPipeClass();
            return View(dwgData);
        }
        public ActionResult ValidateMaterialPipeClass()
        {
            var dwgData = _appServices.ValidateMaterialPipeClass();
            return View(dwgData);
        }

        public ActionResult DisplayCmWithDwgData()
        {
            var dwgData = _appServices.GetCmWithDwgData();
            return View(dwgData);
        }

        [HttpGet]
        public ActionResult AddRecord()
        {        

            return View();
        }

        [HttpPost]
        public ActionResult AddRecord(FunctionalLocationModel functionLoc)
        {
            //Not valid route
            if (!ModelState.IsValid)
            {
                return View(functionLoc);
            }
            //TODO: Add
            //Prompt message for demo maybe
            //Redirect back for now
            return Redirect("DisplayCmWithDwgData");          
        }

        public ActionResult UpdateMaterialField()
        {
            //synch material from dwg data to database
            _appServices.UpdateDbPipingMaterial();         
            return RedirectToAction("DisplayCmWithDwgData", "Home");
        }





        public ActionResult BlankMaterialFieldInDb()
        {
            _appServices.ResetMaterialField();

            return RedirectToAction("DisplayCmWithDwgData", "Home");
        }
        public ActionResult About()
        {
            ViewBag.Message = "About Us.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Contact Us.";

            return View();
        }

        
    }
}