using System;
using System.Web.Security;
using System.Security.Principal;
using System.Web;

namespace UwierzytelnienieForm
{
    public partial class LogOn : System.Web.UI.Page
    {
        private string[] baseRole = {"Admin","Użytkownik","Moderator","Grafik"};

        protected void btnLog_Click(object sender, EventArgs e)
        {
            if ((txtLogin.Text == "Cezary") && (txtPassword.Text == "12345"))
            {
                string[] role = {baseRole[0],baseRole[3]};
                CreateCookieAndRedirect("Cezary", role);
            }

            if ((txtLogin.Text == "Franko") && (txtPassword.Text == "09876"))
            {
                string[] role = {baseRole[1]};
                CreateCookieAndRedirect("Franko",role);
            }
        }

        private void CreateCookieAndRedirect (string userName, string[] roles)
        {
            if (roles != null)
            {
                string joinRoles = string.Join("|", roles);

                FormsAuthenticationTicket authTicket =
                  new FormsAuthenticationTicket(1,
                                                userName,
                                                DateTime.Now,
                                                DateTime.Now.AddMinutes(30),
                                                false,
                                                joinRoles);

                string encTicket = FormsAuthentication.Encrypt(authTicket);
                
                HttpCookie faCookie =
                  new HttpCookie(FormsAuthentication.FormsCookieName, encTicket);
                Response.Cookies.Add(faCookie);

                string redirectUrl =
                  FormsAuthentication.GetRedirectUrl(userName, false);
                Response.Redirect(redirectUrl);
            }
        }
    }
}