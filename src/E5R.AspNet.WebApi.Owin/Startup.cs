﻿using Owin;
using System.Web.Http;

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