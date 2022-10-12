﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using QRSCS.Models;
using QRSCS.Manager;
using QRSCS.Filters;
using System.IO;
using Newtonsoft.Json;
using System.Data.Entity;
using System.Diagnostics;
using System.Web.UI.WebControls;

namespace QRSCS_Database
{
    [AuthorizedUser]
    public class AdminController : Controller
    {

        public ActionResult Index(DashboardModel dbm)
        {
            DashboardManager obj = new DashboardManager();
            var request = obj.Cards(dbm);
            return View(request);
        }


        [HttpGet]
        public ActionResult CreateUser()
        {
            ViewBag.Message = "";
            return View();
        }

        [HttpPost]
        public ActionResult CreateUser(CreateUserModel Users, HttpPostedFileBase ImageFile)
        {
            if (ModelState.IsValid)
            {
                if (ImageFile == null)
                {
                    TempData["Message"] = "Upload User Picture !";
                    return View();
                }
                else
                {
                    if (Path.GetExtension(ImageFile.FileName) == ".jpg" || Path.GetExtension(ImageFile.FileName) == ".jpeg" || Path.GetExtension(ImageFile.FileName) == ".png")
                    {
                        string Filename = Path.GetFileNameWithoutExtension(ImageFile.FileName);
                        string Extension = Path.GetExtension(ImageFile.FileName);
                        Filename = Filename + DateTime.Now.ToString("yymmssfff") + Extension;
                        Users.Picture = "~/ProjectData/" + Filename;
                        Filename = Path.Combine(Server.MapPath("~/ProjectData/"), Filename);
                        ImageFile.SaveAs(Filename);

                        CreateUserManager obj = new CreateUserManager();
                        Users.Created_By = Convert.ToString(Session["User_ID"]);
                        Users.Creation_Date = DateTime.Now;
                        int u_id = obj.AddUser(Users);
                        if (u_id > 0)
                        {
                            TempData["Message"] = "User Created Successfuly and User Id is " + u_id;
                            return RedirectToAction("ViewAllUser");
                        }

                        else
                        {
                            TempData["Message"] = "User Not Created !";
                        }
                    }
                    else
                    {
                        TempData["Message"] = "This is not Image file!";
                    }

                }
            }
            else
            {
                TempData["Message"] = "User Not Created Kindly Fill Complete Form !";
            }
            return View();
        }
        [HttpPost]

        public ActionResult UpdateUserStatus(bool Status, int userId)
        {
            CreateUserManager obj = new CreateUserManager();
            var response = obj.UpdateUserStatus(Status, userId);

            return Json(response, JsonRequestBehavior.AllowGet);
        }
        [HttpPost]

        public ActionResult UpdateStudentStatus(bool Status, int userId)
        {
            CreateUserManager obj = new CreateUserManager();
            var response = obj.UpdateStudentStatus(Status, userId);

            return Json(response, JsonRequestBehavior.AllowGet);
        }

        public ActionResult ViewAllUser()
        {
            CreateUserManager obj = new CreateUserManager();
            List<CreateUserModel> User = obj.selectUser();
            //return Json(User,JsonRequestBehavior.AllowGet);
            return View(User);
        }

        public ActionResult ViewAllTeachers()
        {
            CreateTeacherManager obj = new CreateTeacherManager();
            List<CreateTeacherModel> User = obj.selectTeacher();
            return View(User);
        }

        [HttpGet]
        public ActionResult UpdateUser(int User_ID)
        {
            CreateUserManager obj = new CreateUserManager();
            CreateUserModel user = obj.GetUser(User_ID);

            if (user == null)
            {
                TempData["Message"] = "Data not Found";
                return RedirectToAction("ViewAllUser");
            }

            else
            {
                return View(user);
            }
        }

        public JsonResult UpdateUserProfile(int User_ID)
        {
            CreateUserManager obj = new CreateUserManager();
            CreateUserModel user = obj.GetUser(User_ID);

            string value = string.Empty;
            value = JsonConvert.SerializeObject(user, Formatting.Indented, new JsonSerializerSettings
            {
                ReferenceLoopHandling = ReferenceLoopHandling.Ignore,
            });
            return Json(value, JsonRequestBehavior.AllowGet);

        }


        [HttpGet]
        public ActionResult UpdateTeacher(int Teacher_ID)
        {
            CreateTeacherManager obj = new CreateTeacherManager();
            CreateTeacherModel user = obj.GetTeacher(Teacher_ID);
            if (user == null)
            {
                TempData["Message"] = "Data not Found";
                return RedirectToAction("ViewAllTeachers");
            }

            else
            {
                return View(user);
            }
        }

        [HttpPost]
        public ActionResult UpdateUser(CreateUserModel user, HttpPostedFileBase ImageFile)
        {
            if (ModelState.IsValid)
            {
                if (ImageFile != null)
                {
                    string Filename = Path.GetFileNameWithoutExtension(ImageFile.FileName);
                    string Extension = Path.GetExtension(ImageFile.FileName);
                    Filename = Filename + DateTime.Now.ToString("yymmssfff") + Extension;
                    user.Picture = "~/ProjectData/" + Filename;
                    Filename = Path.Combine(Server.MapPath("~/ProjectData/"), Filename);
                    ImageFile.SaveAs(Filename);
                }

                CreateUserManager obj = new CreateUserManager();
                user.Updated_By = Convert.ToString(Session["User_ID"]);
                user.Update_Date = DateTime.Now;

                bool check = obj.UpdateUser(user);
                if (check)
                {
                    TempData["Message"] = "Data Update Successully";
                    return RedirectToAction("ViewAllUser");
                }
                else
                {
                    return View();
                }
            }
            else
            {
                TempData["Message"] = "Data Not Updated";
                return View();
            }
        }

        public ActionResult Logout()
        {
            Session.Clear();
            return RedirectToAction("Login", "Login");
        }
        public JsonResult SaveDataInDatabase(CreateUserModel user, HttpPostedFileBase ImageFile)
        {

            Debug.WriteLine(user.UserName);
            Debug.WriteLine(ImageFile);

            //if (user is null)
            //{ 
            //    throw new ArgumentNullException(nameof(user));
            //}

            bool check = false;
            //Debug.WriteLine("debug information");
            //try
            //{
            //    if (user.Picture != null) {
            //        Debug.WriteLine("debug information----");
            //        string Filename = Path.GetFileNameWithoutExtension(user.Picture);
            //        string Extension = Path.GetExtension(user.Picture);
            //        Filename = Filename + DateTime.Now.ToString("yymmssfff") + Extension;
            //        user.Picture = "~/ProjectData/" + Filename;
                    

            //    }

            //    CreateUserManager obj = new CreateUserManager();
            //    user.Updated_By = Convert.ToString(Session["User_ID"]);
            //    user.Update_Date = DateTime.Now;
            //    user.Picture = "c:\\users\\daniy\\desktop\\version1\\version2\\qrscs-.net-mvc\\qrscs\\projectdata\\whatsapp image 2020-03-21 at 1.27.11 am211743849.jpg";
            //    check = obj.UpdateUser(user);
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine("This is C#");
            //    throw ex;
            //}


            return Json(check, JsonRequestBehavior.AllowGet);
        }
    }
}