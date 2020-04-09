using AupaWeb.Models;
using System;
using System.Collections.Generic;
using System.Web.Mvc;
using System.Linq;
using System.Web;

namespace AupaWeb.Controllers
{
        
    public class ContactController : Controller
    {


        public ActionResult Contact()
        {
            SQLServerConnector sqlServerConnector = new SQLServerConnector();
            List<UserBasicDataObject> userlist;
            userlist = sqlServerConnector.GetUserBasicData();

            PostDataViewModel postDataViewModel = new PostDataViewModel();
            postDataViewModel.UserBasicData = userlist; 
            
            //String sqlString = "";

            //ViewBag.colValue = new SelectList(userlist);

            //if (userinfo != null && !userinfo.IsEmpty())
            //{
            //    userlist = userlist.Where(s => s.Title.Contains(sqlString));
            //}



            TempData["postDataViewModel"] = postDataViewModel;
            return Redirect("BackToContact");
            //return View(postDataViewModel);
        }
        public ActionResult BackToContact()
        {
            PostDataViewModel postDataViewModel = (PostDataViewModel)TempData["postDataViewModel"];
            return View("Contact", postDataViewModel);
        }
    }

    
}
