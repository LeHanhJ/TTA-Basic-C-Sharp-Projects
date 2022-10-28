using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using CarInsurance.Models;

namespace CarInsurance.Controllers
{
    public class InsureeController : Controller
    {
        private readonly string connectionString = @"Data Source=(LocalDb)\MSSQLLocalDB;
                                                    Initial Catalog=C:\USERS\DELL\DOCUMENTS\GITHUB\TTA-BASIC-C-SHARP-PROJECTS\BASIC_C#_PROGRAMS\CARINSURANCE\CARINSURANCE\APP_DATA\INSURANCE.MDF;
                                                    Integrated Security=True";

        private InsuranceEntities db = new InsuranceEntities();

        // GET: Insuree
        public ActionResult Index()
        {
            return View(db.Insurees.ToList());
        }

        public ActionResult Admin()
        {
            return View(db.Insurees.ToList());
        }

        // GET: Insuree/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Insuree insuree = db.Insurees.Find(id);
            if (insuree == null)
            {
                return HttpNotFound();
            }
            return View(insuree);
        }

        // GET: Insuree/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Insuree/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,FirstName,LastName,EmailAddress,DateOfBirth,CarYear,CarMake,CarModel,DUI,SpeedingTickets,CoverageType,Quote")] Insuree insuree)
        {
            if (ModelState.IsValid)
            {
                db.Insurees.Add(insuree);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(insuree);
        }

        // GET: Insuree/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Insuree insuree = db.Insurees.Find(id);
            if (insuree == null)
            {
                return HttpNotFound();
            }
            return View(insuree);
        }

        // POST: Insuree/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,FirstName,LastName,EmailAddress,DateOfBirth,CarYear,CarMake,CarModel,DUI,SpeedingTickets,CoverageType,Quote")] Insuree insuree)
        {
            if (ModelState.IsValid)
            {
                db.Entry(insuree).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(insuree);
        }

        // GET: Insuree/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Insuree insuree = db.Insurees.Find(id);
            if (insuree == null)
            {
                return HttpNotFound();
            }
            return View(insuree);
        }

        // POST: Insuree/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Insuree insuree = db.Insurees.Find(id);
            db.Insurees.Remove(insuree);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        public decimal QuoteCalculation(Insuree insuree)
        {
            decimal baseQuote = 50.0m;
            decimal updatedQuote = baseQuote;

            //Insuree's DoB
            if (DateTime.Now.Year - insuree.DateOfBirth.Year <= 18)
            {
                updatedQuote = baseQuote + 25;
            }
            if (DateTime.Now.Year - insuree.DateOfBirth.Year >= 19 && DateTime.Now.Year - insuree.DateOfBirth.Year <= 25)
            {
                updatedQuote += 50;
            }
            if (DateTime.Now.Year - insuree.DateOfBirth.Year > 26)
            {
                updatedQuote += 25;
            }
            //Car Year, Make, and Model
            if (insuree.CarYear < 2000)
            {
                updatedQuote += 25;
            }
            if (insuree.CarYear > 2015)
            {
                updatedQuote += 25;
            }

            if (insuree.CarMake == "Porsche")
            {
                updatedQuote += 25;
                if (insuree.CarModel == "911 Carrera")
                {
                    updatedQuote += 25;
                }
            }
            // Speeding Ticket, DUI, and Full coverage
            if (insuree.SpeedingTickets > 0)
            {
                updatedQuote += (insuree.SpeedingTickets * 10);
            }

            if (insuree.DUI)
            {
                updatedQuote += (updatedQuote * 1.25m);
            }
            if (insuree.CoverageType)
            {
                updatedQuote += (updatedQuote * 1.5m);
            }

            return updatedQuote;
        }

        //ADMIN VIEW
        //public ActionResult Admin()
        //{
        //    string queryString = @"SELECT FirstName, LastName, EmailAddress, Quote from Insuree";
        //    List<Insuree> signups = new List<Insuree>();

        //    using (SqlConnection connection = new SqlConnection(connectionString))
        //    {
        //        SqlCommand command = new SqlCommand(queryString, connection);

        //        connection.Open();

        //        SqlDataReader reader = command.ExecuteReader();

        //        while (reader.Read())
        //        {
        //            var signup = new Insuree();
        //            signup.FirstName = reader["FirstName"].ToString();
        //            signup.LastName = reader["LastName"].ToString();
        //            signup.EmailAddress = reader["EmailAddress"].ToString();
        //            signup.Quote = Convert.ToDecimal(reader["Quote"]);
        //            signups.Add(signup);

        //        }

        //    }
        //    return View(signups);
        //}
    }
}
