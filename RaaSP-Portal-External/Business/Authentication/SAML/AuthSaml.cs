using RaaSP_Portal_Internal.Business.Authentication.SAML.Saml;

namespace RaaSP_Portal_Internal.Business.Authentication.SAML
{
    class AuthSaml
    {
        public static string CallProvider(string samlEndpoint, AuthRequest request)
        {
            //generate the provider URL
            string url = request.GetRedirectUrl(samlEndpoint);

            //then redirect your user to the above "url" var
            //for example, like this:
           return url;
        }
    }
}
