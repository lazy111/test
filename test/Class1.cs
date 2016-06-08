using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;

namespace test
{
    public class Class1
    {
        static string a1 = ConfigurationManager.AppSettings["aaa"];

        public static string sss() {
            return a1;
        }
        public static string sss(string a) {
            a1 = a;
            return a1;
        }
    }
}