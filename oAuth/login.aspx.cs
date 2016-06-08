using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication3
{
    public partial class login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            FormsAuthentication.SignOut();
            //if (Request.QueryString["un"] == "admin" && Request.QueryString["pwd"] == "admin")
            //{
            //    FormsAuthentication.RedirectFromLoginPage("admin", true);
            //}
        }
    }
}