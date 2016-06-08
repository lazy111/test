using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AuthTicket
{
    public partial class Index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            if (HttpContext.Current.User.Identity.IsAuthenticated)
            {
                ltlLoginName.Text = HttpContext.Current.User.Identity.Name;


                HttpCookie cookie = Request.Cookies["sa"];
              
            }
            //else
            //{
            //    Response.Redirect("~/Login.aspx");
            //}
        }
    }
}