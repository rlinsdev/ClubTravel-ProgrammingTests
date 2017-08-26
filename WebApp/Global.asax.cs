using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.SessionState;
using System.Web.Http;
using System.Web.Routing;

namespace webApp.WebApi
{
   public class Global : System.Web.HttpApplication
   {
      private const string _WebApiPrefix = "api";
      private static string _WebApiExecutionPath = String.Format("~/{0}", _WebApiPrefix);
      protected void Application_PostAuthorizeRequest()
      {
         if (IsWebApiRequest())
         {
            HttpContext.Current.SetSessionStateBehavior(SessionStateBehavior.Required);
         }
      }
      private static bool IsWebApiRequest()
      {
         return HttpContext.Current.Request.AppRelativeCurrentExecutionFilePath.StartsWith(_WebApiExecutionPath);
      }

      protected void Application_Start(object sender, EventArgs e)
      {
         GlobalConfiguration.Configure(WebApiConfig.Register);

      }

      protected void Session_Start(object sender, EventArgs e)
      {

      }

      protected void Application_BeginRequest(object sender, EventArgs e)
      {

      }

      protected void Application_AuthenticateRequest(object sender, EventArgs e)
      {

      }

      protected void Application_Error(object sender, EventArgs e)
      {

      }

      protected void Session_End(object sender, EventArgs e)
      {

      }

      protected void Application_End(object sender, EventArgs e)
      {

      }
   }
}