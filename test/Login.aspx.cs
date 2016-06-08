using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            HttpCookie cookie = new HttpCookie("sso");
            cookie.Domain = "sso.com";
            cookie.Expires = DateTime.Now.AddDays(1);
            cookie.Value = "hello.sso";
            Response.Cookies.Add(cookie);





            List<DayDataModel> list = new List<DayDataModel>();
            double v = (from item in list select item).Average(item => item.value);//item.value是指DayDataModel里的要求平均值的属性
        }
    }

    public class DayDataModel {
        public int value;
    }
}