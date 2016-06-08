using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConsoleApplication1
{
    class Program
    {
        static string url = "https://www.xiaoying.com/invest/list?interest=900";
        static int i=0;
        static int tickTime = 30;
        static void Main(string[] args)
        {

            Console.Write("检测周期（s）：");
            tickTime = Console.Read();

            Thread thread = new Thread(() =>
            {

                while (true)
                {
                   
                    WebRequest request = WebRequest.Create(url.Trim());
                    WebResponse response = request.GetResponse();

                    string rl;
                    Stream resStream = response.GetResponseStream();

                    StreamReader sr = new StreamReader(resStream, Encoding.UTF8);
                    StringBuilder sb = new StringBuilder();
                    while ((rl = sr.ReadLine()) != null)
                    {
                        sb.Append(rl);
                    }
                    string str = sb.ToString().ToLower();


                    Regex regex = new Regex("<a href=\".*\" class=\"btn btn-1\" title=\"立即投资\">立即投资</a>", RegexOptions.IgnoreCase);

                    if (regex.IsMatch(str))
                    {
                        MessageBox.Show("干货来了^_^~", "hi ^_^~", MessageBoxButtons.OKCancel, 
MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
                    }

                    Console.WriteLine(string.Format("第{0}次尝试，时间：{1}", ++i, DateTime.Now.ToString()));
                    Thread.Sleep(1000 * tickTime);

                }



            });
            thread.Start();

            Console.Read();

        }
    }
}
