using Lab1.Entities;
using System.Linq;
using System.Web.Mvc;
using Lab1.Infrastructure;
using Lab1.Models;
using System.Web.Helpers;

namespace Lab1.Controllers
{
    public class HomeController : Controller
    {
        private avdbContext _avdb;

        public HomeController(avdbContext dbContext)
        {
            _avdb = dbContext;
        }

        public ActionResult Index()
        {
            return View(_avdb.Clients.AsEnumerable().Select(e => e.ToModel()));
        }

        public ActionResult Create()
        {
            ViewBag.Cities = new SelectList(_avdb.Cities, "Id", "Title");
            ViewBag.Disabilities = new SelectList(_avdb.Disabilities, "Id", "Title");
            ViewBag.MaritalStatuses = new SelectList(_avdb.MaritalStatuses, "Id", "Title");
            ViewBag.Nationalities = new SelectList(_avdb.Nationalities, "Id", "Title");
            ViewBag.Genders = new SelectList(_avdb.Genders, "Id", "Title");

            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(ClientModel clientmodel)
        {
            if (_avdb.Clients.Any(x => x.Email == clientmodel.Email))
            {
                ModelState.AddModelError("Email", "Client with this E-mail already exists");
            }

            if (_avdb.Clients.Any(x => x.MobilePhoneNumber == clientmodel.MobilePhoneNumber))
            {
                ModelState.AddModelError("MobilePhoneNumber", "Client with this Mobile Phone already exists");
            }

            if (_avdb.Clients.Any(x => (x.PassportNumber == clientmodel.PassportNumber && x.PassportSerie == clientmodel.PassportSerie)))
            {
                ModelState.AddModelError("PassportNumber", "Client with this Passport Number already exists");
            }

            if (_avdb.Clients.Any(x => (x.IndentityNo == clientmodel.IndentityNo)))
            {
                ModelState.AddModelError("IndentityNo", "Client with this Indentity Number already exists");
            }
            if (ModelState.IsValid)
            {
                _avdb.Clients.Add(clientmodel.ToEntity());
                var errors = _avdb.GetValidationErrors();
                _avdb.SaveChanges();

                return RedirectToAction("Index");
            }

            ViewBag.Cities = new SelectList(_avdb.Cities, "Id", "Title");
            ViewBag.Disabilities = new SelectList(_avdb.Disabilities, "Id", "Title");
            ViewBag.MaritalStatuses = new SelectList(_avdb.MaritalStatuses, "Id", "Title");
            ViewBag.Nationalities = new SelectList(_avdb.Nationalities, "Id", "Title");
            ViewBag.Genders = new SelectList(_avdb.Genders, "Id", "Title");

            return View(clientmodel);

        }

        public ActionResult Edit(int id)
        {
            ViewBag.Cities = new SelectList(_avdb.Cities, "Id", "Title");
            ViewBag.Disabilities = new SelectList(_avdb.Disabilities, "Id", "Title");
            ViewBag.MaritalStatuses = new SelectList(_avdb.MaritalStatuses, "Id", "Title");
            ViewBag.Nationalities = new SelectList(_avdb.Nationalities, "Id", "Title");
            ViewBag.Genders = new SelectList(_avdb.Genders, "Id", "Title");
            var client = _avdb.Clients.FirstOrDefault(i => i.Id == id);

            return View(client.ToModel());
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(ClientModel clientmodel)
        {
            if (_avdb.Clients.Any(x => x.Email == clientmodel.Email && x.Id != clientmodel.Id))
            {
                ModelState.AddModelError("Email", "Client with this E-mail already exists");
            }

            if (_avdb.Clients.Any(x => x.MobilePhoneNumber == clientmodel.MobilePhoneNumber && x.Id != clientmodel.Id))
            {
                ModelState.AddModelError("MobilePhoneNumber", "Client with this Mobile Phone already exists");
            }

            if (_avdb.Clients.Any(x => (x.PassportNumber == clientmodel.PassportNumber && x.PassportSerie == clientmodel.PassportSerie && x.Id != clientmodel.Id)))
            {
                ModelState.AddModelError("PassportNumber", "Client with this Passport Number already exists");
            }

            if (_avdb.Clients.Any(x => (x.IndentityNo == clientmodel.IndentityNo && x.Id != clientmodel.Id)))
            {
                ModelState.AddModelError("IndentityNo", "Client with this Indentity Number already exists");
            }

            if (ModelState.IsValid)
            {
                var clientEntity = _avdb.Clients.Find(clientmodel.Id);

                clientEntity.Birthdate = clientmodel.Birthdate;
                clientEntity.DisabilityId = clientmodel.DisabilityId;
                clientEntity.Email = clientmodel.Email;
                clientEntity.FirstName = clientmodel.FirstName;
                clientEntity.GenderId = clientmodel.GenderId;
                clientEntity.IndentityNo = clientmodel.IndentityNo;
                clientEntity.IssueDate = clientmodel.IssueDate;
                clientEntity.JobPosition = clientmodel.JobPosition;
                clientEntity.LastName = clientmodel.LastName;
                clientEntity.Liable = clientmodel.Liable;
                clientEntity.LocationAddress = clientmodel.LocationAddress;
                clientEntity.LocationCityId = clientmodel.LocationCityId;
                clientEntity.MaritalStatusId = clientmodel.MaritalStatusId;
                clientEntity.MobilePhoneNumber = clientmodel.MobilePhoneNumber;
                clientEntity.MonthlyIncome = clientmodel.MonthlyIncome;
                clientEntity.NationalityId = clientmodel.NationalityId;
                clientEntity.PassportIssuingAuthority = clientmodel.PassportIssuingAuthority;
                clientEntity.PassportNumber = clientmodel.PassportNumber;
                clientEntity.PassportSerie = clientmodel.PassportSerie;
                clientEntity.Pensioner = clientmodel.Pensioner;
                clientEntity.RegistrationAddress = clientmodel.RegistrationAddress;
                clientEntity.RegistrationCityId = clientmodel.RegistrationCityId;
                clientEntity.Work = clientmodel.Job;
                _avdb.SaveChanges();

                return RedirectToAction("Index");
            }
            ViewBag.Cities = new SelectList(_avdb.Cities, "Id", "Title");
            ViewBag.Disabilities = new SelectList(_avdb.Disabilities, "Id", "Title");
            ViewBag.MaritalStatuses = new SelectList(_avdb.MaritalStatuses, "Id", "Title");
            ViewBag.Nationalities = new SelectList(_avdb.Nationalities, "Id", "Title");
            ViewBag.Genders = new SelectList(_avdb.Genders, "Id", "Title");

            return View(clientmodel);
        }

        public ActionResult Remove(int id)
        {
            var client = _avdb.Clients.Find(id);
            _avdb.Clients.Remove(client);
            _avdb.SaveChanges();

            return RedirectToAction("Index");
        }

        public ActionResult About()
        {
            ViewBag.Message = "Application allows you to Create new clients and to get all ones.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Contact page.";

            return View();
        }
    }
}