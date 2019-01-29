using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

/// <summary>
/// WebApiConfig 的摘要说明
/// </summary>
public static class WebApiConfig
{

    public static void Register(HttpConfiguration config)
    {
        config.Routes.MapHttpRoute(
            name: "DefaultApi",
            routeTemplate: "api/{controller}/{id}",
            defaults: new { id = RouteParameter.Optional }
        );
    }
}