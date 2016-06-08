using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZooKeeperNet;

namespace Zookeeper
{



    public class Client : IWatcher
    {


        private ZooKeeperNet.ZooKeeper zk;

        private string username;

        public string Username
        {
            get { return username; }
        }

        private string password;

        public string Password
        {
            get { return password; }
        }

        public Client()
        {
            zk = new ZooKeeperNet.ZooKeeper("127.0.0.1:2181", new TimeSpan(1, 0, 0, 0), this);
            InitValue();
        }

        private void InitValue()
        {
            try
            {
                username = Encoding.Default.GetString(zk.GetData("/config/user", true, null));
                password = Encoding.Default.GetString(zk.GetData("/config/passwd", true, null));

            }
            catch (Exception)
            {
            }


        }




        public void Process(WatchedEvent @event)
        {

            if (@event.Type==EventType.NodeChildrenChanged||@event.Type==EventType.NodeDataChanged)
            {
                InitValue();
            }

        }
    }
}
