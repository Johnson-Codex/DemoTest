using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace BMS.Web.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }


        public JsonResult Tweets(string hashtag)
        {
            var url = $"https://api.twitter.com/1.1/search/tweets.json?q=%23{hashtag}";
            var basicauthtoken = "YkC3JZbIuXZayFymvqagy79q2RLZpKm0b3R3aiwdbMVKWGeuP9";
            var webrequest = (HttpWebRequest)WebRequest.CreateHttp(url);
            webrequest.Method = "POST";
            webrequest.ContentType = "application/x-www-form-urlencoded";
            webrequest.Headers.Add("Authorization", basicauthtoken);

            //Make the request, get a response and pull the data out of the response stream
            var webresponse = (HttpWebResponse)webrequest.GetResponse();
            Stream responseStream = webresponse.GetResponseStream();
            var reader = new StreamReader(responseStream);

            string result = reader.ReadToEnd();



            return Json(result, JsonRequestBehavior.AllowGet);
        }
    }
}