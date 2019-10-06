using JobbersCafe.Data;
using JobbersCafe.UI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace JobbersCafe.UI.Controllers
{
    public class EnquiryController : Controller
    {
        //
        // GET: /Enquiry/

        public ActionResult Index()
        {
            vmEnquiry model = new vmEnquiry();
            return View(model);
        }

        [HttpPost]
        public ActionResult Index(vmEnquiry model)
        {
            JobersCafeEntities jobberContext = new JobersCafeEntities();
            JC_Enquiry enquiry = new JC_Enquiry();
            enquiry.First_Name = model.FirstName;
            enquiry.Last_Name = model.LastName;
            enquiry.Gender = "male";
            enquiry.Email_Address = model.EmailAddress;
            enquiry.Address = model.Address;
            enquiry.Phone_Number = model.PhoneNumber;

            jobberContext.JC_Enquiry.Add(enquiry);
            jobberContext.SaveChanges();
            vmEnquiry model1 = new vmEnquiry();
            return View(model1);
        }


    }
}
