using Exemplo4.Models;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Exemplo4.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            //return View("Index", "", GetSerializedStudentVMS());
            return View("Index", "", GetStudent1());
        }

        public string GetSerializedStudentVMS()
        {
            var students = new[]
                {
                    GetStudent1(),
                    GetStudent2(),
                    GetStudent3(),
                };

            //Used to make property name as camel case
            var settings = new JsonSerializerSettings { ContractResolver = new CamelCasePropertyNamesContractResolver() };

            return JsonConvert.SerializeObject(students, Formatting.None, settings); //Returns students list as JSON
        }

        private static StudentVM GetStudent3()
        {
            return new StudentVM { RollNo = 10, StudentName = "Jahid Hasan", Class = "Three", ClassTeacher = "Mr. Lutfor Rahman" };
        }

        private static StudentVM GetStudent2()
        {
            return new StudentVM { RollNo = 5, StudentName = "Kamal Hossain", Class = "Two", ClassTeacher = "Mr. Shahana Begum" };
        }

        private static StudentVM GetStudent1()
        {
            return new StudentVM { RollNo = 1, StudentName = "Jamal Uddin", Class = "One", ClassTeacher = "Mr. Anowar Hossain" };
        }

    }
}
