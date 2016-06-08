using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SvcUtilInvoker
{
    class Program
    {
        static void Main(string[] args)
        {

            UserServiceClient client = new UserServiceClient();
            WCFSerializer.UserInfo info = client.GetUserInfo(1);
            Console.WriteLine(info.Name);
            Console.Read();

        }
    }
}
