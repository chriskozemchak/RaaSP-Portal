﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace RaasP_Portal_Internal.Controllers.Notification
{
    public class NotificationDetailController : Controller
    {
        // GET: NotificationDetail
        public ActionResult Index()
        {
            return View();
        }

        // GET: NotificationDetail/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: NotificationDetail/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: NotificationDetail/Create
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

        // GET: NotificationDetail/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: NotificationDetail/Edit/5
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

        // GET: NotificationDetail/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: NotificationDetail/Delete/5
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