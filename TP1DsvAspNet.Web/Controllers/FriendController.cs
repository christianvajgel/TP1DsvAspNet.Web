using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TP1DsvAspNet.ApplicationService;
using TP1DsvAspNet.Domain;

namespace TP1DsvAspNet.Web.Controllers
{
    public class FriendController : Controller
    {

        private FriendServices Services { get; set; }

        public FriendController(FriendServices services) 
        {
            this.Services = services;
        }

        // GET: FriendController
        public ActionResult Index()
        {
            //return View(this.Services.GetAll());
            return View();
        }

        // GET: FriendController/Details/5
        public ActionResult Details(Guid id)
        {
            return View(this.Services.GetFriendById(id));
        }

        // GET: FriendController/Create
        public ActionResult Create()
        {
            return View();
        }

        public IActionResult Edit(Guid id) 
        {
            return View(this.Services.GetFriendById(id));
        }

        // POST: FriendController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Friend friend)
        {
            try
            {
                this.Services.Save(friend);
                return RedirectToAction(nameof(Index));
            }
            catch (System.Exception ex)
            {
                ModelState.AddModelError("APP_ERROR", ex.Message);
                return View();
            }
        }

        // GET: FriendController/Delete/5
        public ActionResult Delete(Guid id)
        {
            return View(this.Services.GetFriendById(id));
        }

        // POST: FriendController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(Guid id, Friend friend)
        {
            try
            {
                this.Services.Delete(id);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
