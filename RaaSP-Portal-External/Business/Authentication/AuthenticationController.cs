using RaaSP_Portal_Internal.Business.Authentication.SAML;
using RaaSP_Portal_Internal.Business.Authentication.SAML.Saml;

namespace RaaSP_Portal_Internal.Business.Authentication
{
    public class AuthenticationController
    {
        public static string DirectAuthenticationMethod(string method, string variable1, string variable2)
        {
            //TODO: Offer other Methods
            var authenticationType = "";
            switch (method)
            {

                case "SAML":
                    //TODO: Build this somewhere to handle building the endpoints
                    //specify the SAML provider url here, aka "Endpoint"
                    var samlEndpoint = "https://singlesignon.gwu.edu/idp/profile/SAML2/POST/SSO";
                    var samlUrl = new AuthRequest(
                        "http://www.myapp.com", //put your app's "unique ID" here
                        "http://www.myapp.com/SamlConsume" //assertion Consumer Url - the redirect URL where the provider will send authenticated users
                        );
                    
                    var returnAuth = AuthSaml.CallProvider(samlEndpoint, samlUrl);
                    authenticationType = returnAuth;
                    break;
                default:
                    break;

            }

            return authenticationType;

        }
    }
}
