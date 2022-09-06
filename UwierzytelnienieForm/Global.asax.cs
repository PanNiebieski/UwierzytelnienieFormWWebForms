using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.SessionState;
using System.Security.Principal;

namespace UwierzytelnienieForm
{
    public class Global : System.Web.HttpApplication
    {

        protected void Application_Start(object sender, EventArgs e)
        {

        }

        protected void Session_Start(object sender, EventArgs e)
        {

        }

        protected void Application_BeginRequest(object sender, EventArgs e)
        {

        }

protected void Application_AuthenticateRequest(object sender, EventArgs e)
{
    if (Context.Request.IsAuthenticated)
    {
        HttpCookie authCookie = Context.Request.Cookies[FormsAuthentication.FormsCookieName];
        if (authCookie == null)
            return;

        FormsAuthenticationTicket authTicket = FormsAuthentication.Decrypt(authCookie.Value);
        string[] roles = authTicket.UserData.Split('|');

        GenericIdentity userIdentity = new GenericIdentity(authTicket.Name);
        GenericPrincipal userPrincipal = new GenericPrincipal(userIdentity, roles);

        Context.User = userPrincipal;
    }
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