using Flight_Center;
using Flight_Center.Facade;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Web;
using System.Web.Http.Controllers;
using System.Web.Http.Filters;

namespace ApiFlight_Center.BasicAuth
{
    public class BasicAuthCompanyAttribute : AuthorizationFilterAttribute
    {
        /*
                public override void OnAuthorization(HttpActionContext actionContext)
                {
                    // if you put NO response --> request will not get to destination controller
                    // if you place a response --> request will NOT get to destination controller

                    string authenticationToken = actionContext.Request.Headers.Authorization.Parameter;

                    if (authenticationToken == null)
                    {
                        actionContext.Response = actionContext.Request.CreateResponse(HttpStatusCode.Unauthorized);
                        return;
                    }

                    // Base64( username : pwd )

                    string decodedAuthenticationToken = Encoding.UTF8.GetString(Convert.FromBase64String(authenticationToken)); // base64 --> regular

                    string[] usernamePasswordArray = decodedAuthenticationToken.Split(':');
                    string username = usernamePasswordArray[0];
                    string password = usernamePasswordArray[1];

                    LoginService loginService = new LoginService();
                    if (loginService.TryAirlineLogin(username, password, out LoginToken<AirlineCompanie> token))
                    {
                        // temporary -- remove it
                        LoggedInAirlineFacade loggedAirlineFacade = new LoggedInAirlineFacade(); // will be part of login method return value (out)

                        actionContext.Request.Properties["airline_token"] = token;
                        actionContext.Request.Properties["facade"] = loggedAirlineFacade;
                    }
                    else
                    {
                        actionContext.Response = actionContext.Request.CreateResponse(HttpStatusCode.Unauthorized);
                    }

                    return;


                    ////actionContext.Request.Properties["air-line"] = CurrentAirline;

                    //string authenticationToken = actionContext.Request.Headers.Authorization.Parameter;



                    //if (username == "itay" && password == "1234")
                    //{
                    //    Thread.CurrentPrincipal = new GenericPrincipal(
                    //        new GenericIdentity(username), null);
                    //}
                    //else
                    //{
                    //    actionContext.Response = actionContext.Request
                    //        .CreateResponse(HttpStatusCode.Unauthorized);
                    //}
                }
            }*/
    }
}