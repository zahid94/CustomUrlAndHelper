using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace CustomUrlAndHelper.Helper
{
    public static class URLHelper
    {
        public static string Gets(this UrlHelper helper, string controller)
        {
            var routeDictionary = new RouteValueDictionary();
            routeDictionary.Add("controller", controller);

            var route = helper.RouteUrl("UserList", routeDictionary);
            return HttpUtility.UrlDecode(route, System.Text.Encoding.UTF8).ToLower();
        }

        public static string Create(this UrlHelper helper,string controller)
        {
            var routeDictionary = new RouteValueDictionary();
            routeDictionary.Add("controller", controller);

            var route = helper.RouteUrl("UserCreate", routeDictionary);
            return HttpUtility.UrlDecode(route, System.Text.Encoding.UTF8).ToLower();
        }

        public static string Edit(this UrlHelper helper, string controller,int id)
        {
            var routeDictionary = new RouteValueDictionary();
            routeDictionary.Add("controller", controller);
            routeDictionary.Add("id", id);

            var route = helper.RouteUrl("UserEdit", routeDictionary);
            return HttpUtility.UrlDecode(route, System.Text.Encoding.UTF8).ToLower();
        }
        public static string Details(this UrlHelper helper, string controller, int id)
        {
            var routeDictionary = new RouteValueDictionary();
            routeDictionary.Add("controller", controller);
            routeDictionary.Add("id", id);

            var route = helper.RouteUrl("UserDetails", routeDictionary);
            return HttpUtility.UrlDecode(route, System.Text.Encoding.UTF8).ToLower();
        }
        public static string Delete(this UrlHelper helper, string controller, int id)
        {
            var routeDictionary = new RouteValueDictionary();
            routeDictionary.Add("controller", controller);
            routeDictionary.Add("id", id);

            var route = helper.RouteUrl("UserDelete", routeDictionary);
            return HttpUtility.UrlDecode(route, System.Text.Encoding.UTF8).ToLower();
        }
    }
}