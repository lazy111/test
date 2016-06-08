using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml.Linq;

namespace Site1
{
    public partial class WebUserControl1 : System.Web.UI.UserControl
    {

        public static readonly string XmlPath = HttpContext.Current.Server.MapPath("~/sitemap.xml");

        private bool gameOver = false;
        private IList<object> navNodes = new List<object>();


        protected void Page_Load(object sender, EventArgs e)
        {
            string s = ConfigurationManager.AppSettings["aaaaa1111"];
            XDocument xDoc = XDocument.Load(XmlPath);
            System.Xml.Linq.XElement xRoot = xDoc.Root; //根节点 
            SiteMapMatch(xRoot, navNodes);

            string a = "";

        }



        private void SiteMapMatch(XElement ele, IList<object> nodes)
        {
            IEnumerable<XElement> eles = from e in ele.Elements("siteMapNode")
                                         select e;
            foreach (var item in eles)
            {

                string url = item.Attribute("url").Value,
                       nodeStyle = item.Attribute("nodeStyle").Value,
                       title = item.Attribute("title").Value;

                if (!gameOver)
                {
                    if (Regex.IsMatch("", url))
                    {
                        if (nodeStyle == "leaf")
                        {
                            nodes.Add(new { Title = title });
                            gameOver = true;

                            break;
                        }
                        else
                        {
                            nodes.Add(new { Title = title });
                        }
                    }

                    SiteMapMatch(item, nodes);
                }
                break;
            }
        }
    }
}