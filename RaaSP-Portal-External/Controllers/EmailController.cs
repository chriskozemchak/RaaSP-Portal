using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.Net;
using System.Net.Mail;
using System.Diagnostics;
using RaaSP_Portal_External.DataAccess.Models.Request;

namespace RaaSP_Portal_External.Controllers
{
    public class EmailController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public new IActionResult User()
        {
            return View();
        }

        public new IActionResult Request()
        {
            return View();
        }

        public new IActionResult Environment()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new RaasP_Portal.Models.ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Contact(User model)
        {
            if (ModelState.IsValid)
            {
                //var body = "<p>Email From: {0} ({1})</p><p>Message:</p><p>{2}</p>";
                //var message = new MailMessage();
                //message.To.Add(new MailAddress("raasp.adm@gmail.com"));  // send to admin
                //message.To.Add(new MailAddress("raasp.investigator@gmail.com"));  // send to PI
                //message.From = new MailAddress("raasp.mail@gmail.com");  // replace with valid value
                //message.Subject = "User Account Request Details";
                //message.Body = string.Format(body, model.Id, model.FirstName, model.LastName, model.UserName, model.Email, model.Phone);
                //message.IsBodyHtml = true;

                var notification = new MailMessage();
                notification.To.Add(new MailAddress("priyankarroychowdhury3@gmail.com"));  // send to admin
                //notification.To.Add(new MailAddress("raasp.investigator@gmail.com"));  // send to PI
                notification.From = new MailAddress("raasp.mail@gmail.com");  // replace with valid value
                notification.Subject = "Notification from Raasp";
                notification.Body = "System-notification: An user is requesting an account";
                notification.IsBodyHtml = false;

                using (var smtp = new SmtpClient())
                {
                    var credential = new NetworkCredential
                    {
                        UserName = "raasp.mail@gmail.com",  // replace with valid value
                        Password = "Welcome2GWU!"  // replace with valid value
                    };
                    smtp.Credentials = credential;
                    smtp.Host = "smtp.gmail.com";
                    smtp.Port = 587;
                    smtp.EnableSsl = true;
                    await smtp.SendMailAsync(notification);
                    return RedirectToAction("Submitted");
                }
            }
            return View(model);
        }
    }
}