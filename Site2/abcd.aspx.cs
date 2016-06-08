using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Site2
{
    public partial class abcd : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //负载均衡测试
            Response.Write("this is Site2!");
        }
    }
}