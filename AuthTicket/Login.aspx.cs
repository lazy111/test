using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AuthTicket
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnLogOn_Click(object sender, EventArgs e)
        {
            if (txtLoginName.Text == txtLoginName1.Text && txtLoginPwd.Text == "sa")
            {
                FormsAuthenticationTicket ticket = new FormsAuthenticationTicket(1, "sa111", DateTime.Now, DateTime.Now.AddDays(1), true, "{'Username':'sa'}");
                HttpCookie authCookie = FormsAuthentication.GetAuthCookie("sa", true);

                authCookie.Domain = "";
                authCookie.Value =  FormsAuthentication.Encrypt(ticket);
                Response.Cookies.Add(authCookie);

                Response.Redirect("~/Index.aspx");

            }
        }
    }
}