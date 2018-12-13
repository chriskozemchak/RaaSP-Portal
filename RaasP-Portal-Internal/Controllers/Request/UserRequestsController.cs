
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace RaasP_Portal_Internal.Controllers.Request
{
    [Microsoft.AspNetCore.Authorization.Authorize]
    public class UserRequestsController : Controller
    {
        // GET: UserRequests
        public ActionResult Index()
        {
            return View();
        }

        // GET: UserRequests/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: UserRequests/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: UserRequests/Create
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

        // GET: UserRequests/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: UserRequests/Edit/5
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

        // GET: UserRequests/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: UserRequests/Delete/5
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