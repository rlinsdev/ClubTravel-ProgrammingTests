using System.Web.Http;

namespace webApp.WebApi
{
   public static class WebApiConfig
   {
      public static void Register(HttpConfiguration config)
      {
         config.MapHttpAttributeRoutes();
      }
   }
}