using Owin;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Routing;

// TODO: E5R.Learning.AspNetWebApiOwin
namespace E5R.AspNet.WebApi.Owin
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            var config = new HttpConfiguration();

            config.MapHttpAttributeRoutes();

            app.UseWebApi(config);

            RouteTable.Routes.MapRoute(
                name: "MvcRoute",
                url: "{controller}/{action}/{id}",
                defaults: new
                {
                    controller = "home",
                    action = "index",
                    id = UrlParameter.Optional
                }
            );
        }
    }
}