using System;
using System.Web.Security;

namespace UwierzytelnienieForm
{
    public partial class Index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            lblUserInfo.Text = Context.User.Identity.Name;
            bool test = Context.User.IsInRole("Admin");
            if (Context.User.IsInRole("Admin"))
            {
                doSomething();
            }
        }

        protected void btnLogOut_Click(object sender, EventArgs e)
        {
            FormsAuthentication.SignOut();
            Response.Redirect("LogOn.aspx");
        }
        void doSomething(){}
    }
}