using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication1
{
    public class CustomerAttribute : AuthorizeAttribute
    {
        bool HasPermisson = true;
        protected override bool AuthorizeCore(HttpContextBase httpContext)
        {
            HasPermisson = false;
            httpContext.Response.StatusCode = 401;
            return true;
        }

        protected override void HandleUnauthorizedRequest(AuthorizationContext filterContext)
        {
            if (!HasPermisson)
            {
                filterContext.Result = new RedirectResult("/Account/NoPermission");
            }
            else
            {
                base.HandleUnauthorizedRequest(filterContext);
            }
                
        }
    }
}