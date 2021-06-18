using BikeShop.Models;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Web.Mvc;

namespace BikeShop.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult HolidaysOfMonth()
        {
            List<Holidays> holidays = new List<Holidays>();

            string result;
            string request = "https://date.nager.at/api/v2/PublicHolidays/2021/RU";

            HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(request);
            httpWebRequest.ContentType = "text/json";
            httpWebRequest.Method = "GET";

            HttpWebResponse httpWebResponse = (HttpWebResponse)httpWebRequest.GetResponse();

            using (StreamReader streamReader = new StreamReader(httpWebResponse.GetResponseStream()))
            {
                result = streamReader.ReadToEnd();
                holidays = JsonConvert.DeserializeObject<List<Holidays>>(result);
            }

            if (holidays != null)
            {
                Holidays hol = holidays.FirstOrDefault(h => h.LocalName == "Новый год");

                return View(hol);
            }
            return View();
        }

    }
}