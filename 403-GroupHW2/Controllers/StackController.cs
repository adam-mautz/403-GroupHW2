using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _403_GroupHW2.Controllers
{
    public class StackController : Controller
    {
        Stack<string> myStack = new Stack<string>();

        // GET: Stack
        public ActionResult Index()
        {
            return View();
        }

       public ActionResult AddOne()
        {
            int iPlace;
            iPlace = myStack.Count() + 1;
            myStack.Push(iPlace.ToString());

            return Redirect("Index");
        }

        public void AddHuge()
        {
            myStack.Clear();
            for (int i = 0; i < 2000; i++)
            {
                int iPosition = i + 1;
                myStack.Push("New Entry  " + iPosition.ToString());
            }
        }

        public ActionResult Display()
        {
            ViewBag.Output = "<table>";
            ViewBag.Output += "<tr>";
            ViewBag.Output += "<th>Stack Contents</th>";

            foreach (var item in myStack)
            {
                ViewBag.Output += "<tr><td>#" + myStack.Pop() + "</td>";

            }
            return Redirect("Index");

        }
    }
}