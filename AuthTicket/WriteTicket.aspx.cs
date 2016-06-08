using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AuthTicket
{
    public partial class WriteTicket : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            FormsAuthenticationTicket ticket = new FormsAuthenticationTicket(1, "sa1", DateTime.Now, DateTime.Now.AddDays(1), true, "{'Username':'sa1'}");
            HttpCookie authCookie = FormsAuthentication.GetAuthCookie("sa1", true);

            authCookie.Domain = "";
            authCookie.Value = FormsAuthentication.Encrypt(ticket);
            Response.Cookies.Add(authCookie);

        }
    }
}