
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace RaasP_Portal_Internal.Controllers.PrincipalInvestigator
{
    [Microsoft.AspNetCore.Authorization.Authorize]
    public class PiMenuController : Controller
    {
        // GET: PiMenu
        public ActionResult Index()
        {
            return View();
        }

        // GET: PiMenu/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: PiMenu/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: PiMenu/Create
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

        // GET: PiMenu/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: PiMenu/Edit/5
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

        // GET: PiMenu/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: PiMenu/Delete/5
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