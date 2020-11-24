using Kendo.Mvc.Extensions;
using Kendo.Mvc.UI;
using PrismaLogic_TestApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PrismaLogic_TestApp.Controllers
{
    public class PersonController : Controller
    {
          Test_dbEntities1 _mycontext;

        public PersonController()
        {
            _mycontext = new Test_dbEntities1();
        }
        public ActionResult Index()
        {
            return View();
        }


        public ActionResult Index1([DataSourceRequest] DataSourceRequest request)
        {
            List<Person> persons = new List<Person>();
            persons = _mycontext.People.ToList();
            DataSourceResult result = persons.ToDataSourceResult(request);

            return Json(result, JsonRequestBehavior.AllowGet);
        }

        public ActionResult Update([DataSourceRequest] DataSourceRequest request, Person person)
        {
            if (person != null)
            {
              var perToupdate=  _mycontext.People.SingleOrDefault(m => m.Id.Equals(person.Id));

                perToupdate.FirstName = person.FirstName;
                perToupdate.LastName = person.LastName;
                perToupdate.Country = person.Country;

                _mycontext.SaveChanges();
            }
            return Json( JsonRequestBehavior.AllowGet);
        }

        public ActionResult Delete([DataSourceRequest] DataSourceRequest request, Person person)
        {
            if (person != null)
            {
                var deletedper = _mycontext.People.SingleOrDefault(m => m.Id.Equals(person.Id));
                _mycontext.People.Remove(deletedper);
                _mycontext.SaveChanges();
            }
            return Json(JsonRequestBehavior.AllowGet);
        }


        public ActionResult Create([DataSourceRequest] DataSourceRequest request, Person person)
        {
            
            if (person != null)
            {
                _mycontext.People.Add(person);
                _mycontext.SaveChanges();
            }

            return Json(JsonRequestBehavior.AllowGet);
        }


    }
}