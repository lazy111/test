using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ServiceInvoke
{
    public partial class WebForm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            UserService.UserServiceClient client = new UserService.UserServiceClient();
            UserService.UserInfo info = client.GetUserInfo(1);
            Response.Write(info.Name);
        }
    }
}