namespace Skoruba.IdentityServer4.Admin.Api.Configuration.Constants
{
    public class AuthorizationConsts
    {
        public const string IdentityServerBaseUrl = "http://localhost:5000";
        public const string OidcSwaggerUIClientId = "wtxhub_sso_api_swaggerui";
        public const string OidcApiName = "wtxhub_sso_api";

        public const string AdministrationPolicy = "RequireAdministratorRole";
        public const string AdministrationRole = "SkorubaIdentityAdminAdministrator";
    }
}