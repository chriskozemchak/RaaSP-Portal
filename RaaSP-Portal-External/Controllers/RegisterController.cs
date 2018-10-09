using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RaaSP_Portal_API;
using RaaSP_Portal_Business.Authentication.SAML.Saml;
using RaaSP_Portal_DataAccess.Models.Request;



namespace RaasP_Portal_External.Controllers
{
    public class RegisterController : Controller
    {
        static HttpClient client = new HttpClient();


        // GET: Register
        public ActionResult Index()
        {
            return View();
        }

        // GET: Register/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        public ActionResult SamlConsume()
        {
            //specify the certificate that your SAML provider has given to you
            string samlCertificate = @"-----BEGIN CERTIFICATE-----
BLAHBLAHBLAHBLAHBLAHBLAHBLAHBLAHBLAHBLAHBLAHBLAH123543==
-----END CERTIFICATE-----";

            Response samlResponse = new Response(samlCertificate);
            samlResponse.LoadXmlFromBase64(Request.Form["SAMLResponse"]); //SAML providers usually POST the data into this var

            if (samlResponse.IsValid())
            {
                //WOOHOO!!! user is logged in
                //YAY!

                //Some more optional stuff for you
                //lets extract username/firstname etc
                string username, email, firstname, lastname;
                try
                {
                    username = samlResponse.GetNameID();
                    email = samlResponse.GetEmail();
                    firstname = samlResponse.GetFirstName();
                    lastname = samlResponse.GetLastName();
                }
                catch (Exception ex)
                {
                    //insert error handling code
                    //no, really, please do
                    return null;
                }

                //user has been authenticated, put your code here, like set a cookie or something...
                //or call FormsAuthentication.SetAuthCookie() or something
                return View();
            }
            return View();
        }

        // GET: Register/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Register/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> CreateAsync(IFormCollection collection)
        {
            try
            {
                var requestEnvironment = new RaaSP_Portal_DataAccess.Models.Request.Environment();
                var environment = new Microsoft.Extensions.Primitives.StringValues();
                var requestUser = new User();
                var user = new Microsoft.Extensions.Primitives.StringValues();
                collection.TryGetValue("user", out user);

                //TODO: Cast Form Object to Environment Model
                
                Uri businessUser = await CreateUserRequestAsync(requestUser);

                if (collection.ContainsKey("environment"))
                {
                                          
                    collection.TryGetValue("environment", out environment);

                    //TODO: Cast Form Object to Environment Model

                    Uri businessEnvironment = await CreateEnvironmentRequestAsync(requestEnvironment);
                        
                }
                
              

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        static async Task<Uri> CreateUserRequestAsync(User user)
        {
            HttpResponseMessage response = await client.PostAsJsonAsync(
                "api/user", user);
            response.EnsureSuccessStatusCode();

            // return URI of the created resource.
            return response.Headers.Location;
        }
        static async Task<Uri> CreateEnvironmentRequestAsync(RaaSP_Portal_DataAccess.Models.Request
            .Environment  environment)
        {
            HttpResponseMessage response = await client.PostAsJsonAsync(
                "api/environment", environment);
            response.EnsureSuccessStatusCode();

            // return URI of the created resource.
            return response.Headers.Location;
        }
    }
}