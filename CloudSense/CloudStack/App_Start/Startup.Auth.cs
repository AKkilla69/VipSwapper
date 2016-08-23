﻿//----------------------------------------------------------------------------------------------
//    Licensed under the Apache License, Version 2.0 (the "License");
//    you may not use this file except in compliance with the License.
//    You may obtain a copy of the License at
//
//      http://www.apache.org/licenses/LICENSE-2.0
//
//    Unless required by applicable law or agreed to in writing, software
//    distributed under the License is distributed on an "AS IS" BASIS,
//    WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
//    See the License for the specific language governing permissions and
//    limitations under the License.
//----------------------------------------------------------------------------------------------
using Microsoft.IdentityModel.Clients.ActiveDirectory;
using Microsoft.Owin.Security;
using Microsoft.Owin.Security.Cookies;
using Microsoft.Owin.Security.OpenIdConnect;
using Owin;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Security.Claims;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Net;
using System.Web.Mvc;
using System.Security.Cryptography.X509Certificates;

namespace CloudStack
{
    public partial class Startup
    {
        private DataAccess db = new DataAccess();
        public void ConfigureAuth(IAppBuilder app)
        {
            string ClientId = ConfigurationManager.AppSettings["ClientID"];
            string Authority = string.Format(ConfigurationManager.AppSettings["Authority"], ConfigurationManager.AppSettings["AADId"]);
            string AzureResourceManagerIdentifier = ConfigurationManager.AppSettings["AzureResourceManagerIdentifier"];
                        
            app.SetDefaultSignInAsAuthenticationType(CookieAuthenticationDefaults.AuthenticationType);
            app.UseCookieAuthentication(new CookieAuthenticationOptions { });
            app.UseOpenIdConnectAuthentication(
                new OpenIdConnectAuthenticationOptions
                {
                    ClientId = ClientId,
                    Authority = Authority,
                    Notifications = new OpenIdConnectAuthenticationNotifications()
                    {
                        RedirectToIdentityProvider = (context) =>
                        {
                            // This ensures that the address used for sign in and sign out is picked up dynamically from the request
                            // this allows you to deploy your app (to Azure Web Sites, for example) without having to change settings
                            // Remember that the base URL of the address used here must be provisioned in Azure AD beforehand.
                            //string appBaseUrl = context.Request.Scheme + "://" + context.Request.Host + context.Request.PathBase;
                            
                            object obj = null;
                            if (context.OwinContext.Environment.TryGetValue("DomainHint", out obj))
                            {
                                string domainHint = obj as string;
                                if (domainHint != null)
                                {
                                    context.ProtocolMessage.SetParameter("domain_hint", domainHint);
                                }
                            }

                            context.ProtocolMessage.RedirectUri = HttpContext.Current.Request.Url.GetLeftPart(UriPartial.Path);
                            context.ProtocolMessage.PostLogoutRedirectUri = new UrlHelper(HttpContext.Current.Request.RequestContext).Action
                                ("Index", "Home", null, HttpContext.Current.Request.Url.Scheme);
                            context.ProtocolMessage.Resource = AzureResourceManagerIdentifier;
                            return Task.FromResult(0);
                        },
                        AuthorizationCodeReceived = (context) =>
                        {
                            X509Certificate2 keyCredential = new X509Certificate2(HttpContext.Current.Server.MapPath
                                (ConfigurationManager.AppSettings["KeyCredentialPath"]), "", X509KeyStorageFlags.MachineKeySet);
                            ClientAssertionCertificate clientAssertion = new ClientAssertionCertificate(ClientId, keyCredential);

                            string signedInUserUniqueName = context.AuthenticationTicket.Identity.FindFirst(ClaimTypes.Name).Value
                                .Split('#')[context.AuthenticationTicket.Identity.FindFirst(ClaimTypes.Name).Value.Split('#').Length - 1];

                            var tokenCache = new ADALTokenCache(signedInUserUniqueName);
                            tokenCache.Clear();

                            AuthenticationContext authContext = new AuthenticationContext(Authority, tokenCache);
                            AuthenticationResult result = authContext.AcquireTokenByAuthorizationCode(
                                context.Code, new Uri(HttpContext.Current.Request.Url.GetLeftPart(UriPartial.Path)), clientAssertion);

                            return Task.FromResult(0);
                        }
                    }
                });
        }
    }
}