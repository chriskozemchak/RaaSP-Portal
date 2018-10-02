using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace RaasP_Portal_Internal.Controllers.PrincipalInvestigator
{
    public class EnvironmentController : Controller
    {
        // GET: Environment
        public ActionResult Index()
        {
            return View();
        }

        // GET: Environment/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Environment/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Environment/Create
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

        // GET: Environment/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Environment/Edit/5
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

        // GET: Environment/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Environment/Delete/5
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