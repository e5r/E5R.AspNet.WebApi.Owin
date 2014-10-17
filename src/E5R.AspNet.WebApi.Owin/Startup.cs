using Owin;
using System.Web.Http;

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
        }
    }
}