using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _403_GroupHW2.Controllers
{
    public class DictionaryController : Controller
    {
        // GET: Dictionary
        public ActionResult Index()
        {
            //makes new Dictionary object
            Dictionary<string, int> dictionary = new Dictionary<string, int>();

            return View();
        }

        public ActionResult Add_One()
        {
            dictionary.Add("New Entry " + (dictionary.Count + 1), (dictionary.Count + 1));//adds one item to the dictionary
        }

        public ActionResult Add_Huge()
        {
            dictionary.Clear();//empties the Dictionary object
            
            for (int iCount = 1; iCount <= 2000; iCount++)//adds 2000 keyvalue pairs to the Dictionary
            {
                public int iValue = dictionary.Count + 1;
                public string sKey = "New Entry " + iValue;//sets variables equal to the key and value for each, incrementing

                dictionary.Add(sKey, iValue);//adds an item to the dictionary and continutes in the for loop
            }
        }

        public ActionResult Display()
        {
            //LOAD ONTO VIEWBAG
            ViewBag.Output = "<table>";
            ViewBag.Output += "<tr>";
            ViewBag.Output += "<th>Key</th>";
            ViewBag.Output += "<th>Value</th>";
            ViewBag.Output += "</tr>";
​
            foreach (KeyValuePair<string, int> pair in dictionary)//concatenates keys and values into a table in html
            {
                ViewBag.Output += "<tr><td>" + pair.Key + "</td>" + "<td>" + pair.Value + "</td>" + "</tr>";
            }

            ViewBag.Output += "</table>";//ends html table

            return View();//sends to view

        }

        public ActionResult Delete()
        {

        }

        public ActionResult Clear()//deletes all the items in the dictionary
        {
            dictionary.Clear();
        }

        public ActionResult Search()
        {

        }
    }
}