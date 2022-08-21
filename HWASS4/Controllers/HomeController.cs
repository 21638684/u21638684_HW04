using HWASS4.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HWASS4.Controllers
{
    public class HomeController : Controller
    {
        //for Home page
        public ActionResult Index( )
        {
            return View();
        }
        // about page
        public ActionResult About()
        {
           
            return View();
        }
        // contact page,,,,,,displays the class details 
        public ActionResult Contact()
        {

            List<Committee> committee = GetDetails();
            return View(committee);
        }
        private List<Committee> GetDetails()
        {
            List<Committee> committes = new List<Committee>();
            Committee Com1 = new Committee("Nathan Dell", 5, "ChairMan", "nathandell@siyabongaafrica.org.za");
            Committee Com2 = new Committee("Sarah Jonah", 4, "Chief Executive Officer", "sarahjonah@siyabongaafrica.org.za");
            Committee Com3 = new Committee("Daris Froli", 5, "Center Manager", "darisfoli@siyabongaafrica.org.za");
            Committee Com4 = new Committee("Carol Mofekeng", 5, "Project Coodinator", "carolmofekeng@siyabongaafrica.org.za");
            Committee Com5 = new Committee("Khosi Sithole", 4, "Adminstrator", "khosisithole@siyabongaafrica.org.za");

            committes.Add(Com1);
            committes.Add(Com2);
            committes.Add(Com3);
            committes.Add(Com4);
            committes.Add(Com5);
            return committes;
        }
       
        // responsible for returning the class details on getinvolved view
            public ActionResult GetInvolved()
        {
            List<Models.Involvement> inv = Models.BeInvolved.GetInvolvement();
            return View(inv);
        }

        db_DonorsEntities db_Donors = new db_DonorsEntities();
        // makes it posssible to edit the entered details
        public ActionResult Donor(Donor_TB donor)
        {
            if(donor!=null)
            return View(donor);
            else
                return View();
        }
        // adds the details on a database 
        [HttpPost]
        public ActionResult AddDonor(Donor_TB Donor)
        {
            Donor_TB donor = new Donor_TB();

            donor.Name = Donor.Name;
            donor.Surname = Donor.Surname;
            donor.Email = Donor.Email;
            donor.Phone = Donor.Phone;
            donor.Amount = Donor.Amount;
            donor.Comment = Donor.Comment;

            db_Donors.Donor_TB.Add(donor);
            db_Donors.SaveChanges();
            return View("Donor");
        }
        // returns the list on a table from a database 
        public ActionResult ViewDonors()
        {
            var DonorsDetails = db_Donors.Donor_TB.ToList();
            return View(DonorsDetails);
        }

        // deletes the row in a table by using an id of a selected Donor(row of details)
        public ActionResult DeleteDonors(int id)
        {
            var DonorsDetails = db_Donors.Donor_TB.Where(y => y.ID == id).First();
            db_Donors.Donor_TB.Remove(DonorsDetails);
            db_Donors.SaveChanges();

            var Donorslist = db_Donors.Donor_TB.ToList();
            return View("ViewDonors",Donorslist);
        }
    }
}