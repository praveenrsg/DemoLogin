using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Mvc;
using DemoLogin;
using DemoLogin.Models;
using Newtonsoft.Json;

namespace LoginDemo.Controllers
{
    public class PatientDetailsController : Controller
    {
        DemoLogin.Models.LoginModel regfammodel = new DemoLogin.Models.LoginModel();

        
        public ActionResult PatientDetailsAction()
        {
            return View("PatientDetails", regfammodel);
        }
       
        // GET: All Patient
        [HttpGet]
        public JsonResult GetAllData()
        {
            using (StreamReader r = new StreamReader(Server.MapPath("~/App_Data/patientData.json")))
            {
                string json = r.ReadToEnd();
                List<PatientDetailsModel> items = JsonConvert.DeserializeObject<List<PatientDetailsModel>>(json);
                return Json(items.ToList(), JsonRequestBehavior.AllowGet);
            }

        }

        // GET: Get Single Patient
        [HttpGet]
        public JsonResult GetbyID(int id)
        {
            using (StreamReader r = new StreamReader(Server.MapPath("~/App_Data/patientData.json")))
            {
                string json = r.ReadToEnd();
                List<PatientDetailsModel> items = JsonConvert.DeserializeObject<List<PatientDetailsModel>>(json);
                return Json(items.Where(a => a.PatientID == id).ToList(), JsonRequestBehavior.AllowGet);
            }
        }

        public ActionResult LogoutPatient()
        {

            return RedirectToAction("Index", "Home");
        }

        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }
    }
}