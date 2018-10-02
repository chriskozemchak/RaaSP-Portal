using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace RaasP_Portal_Internal.Controllers.Notification
{
    public class NotificationPanelController : Controller
    {
        // GET: NotificationPanel
        public ActionResult Index()
        {
            return View();
        }

        // GET: NotificationPanel/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: NotificationPanel/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: NotificationPanel/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: NotificationPanel/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: NotificationPanel/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: NotificationPanel/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: NotificationPanel/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}