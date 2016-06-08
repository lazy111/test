using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZooKeeperNet;

namespace Zookeeper
{

    public class LockWatcher : IWatcher
    {
        public void Process(WatchedEvent @event)
        {
            if (@event.Type == EventType.NodeChildrenChanged || @event.Type == EventType.NodeDataChanged)
            {

            }
        }
    }

    public class Lock
    {

        ZooKeeperNet.ZooKeeper zk;
        string serverHost;
        public Lock(string serverHost)
        {
            this.serverHost = serverHost;
            zk = new ZooKeeperNet.ZooKeeper(serverHost, new TimeSpan(1, 0, 0), new LockWatcher());
        }


        public bool ExistLock()
        {

            if (zk.Exists("/custom/lock", true) == null)
            {
                return false;
            }
            else
            {
                zk.GetData("/custom/lock", true, null);
                return true;
            }
        }
        public void SetLock()
        {
            if (zk.Exists("/custom/lock", true) == null)
            {
                zk.Create("/custom/lock", serverHost.GetBytes(), Ids.OPEN_ACL_UNSAFE, CreateMode.Ephemeral);
            }
            else
            {
                zk.SetData("/custom/lock", serverHost.GetBytes(), 0);
            }
        }
        public void ReleaseLock()
        {

            if (zk.Exists("/custom/lock", true) != null)
            {
                zk.Delete("/custom/lock", 0);
            }

        }
    }

    public class LockFactory
    {

        public static string ServerHost;
        public static object CreateLock()
        {
            Lock lk = new Lock(ServerHost);
            bool exist = lk.ExistLock();
            if (exist)
            {
                return null;
            }
            else
            {
                lk.SetLock();
                return new object();
            }
        }
        public static void ReleaseLock()
        {

            Lock lk = new Lock(ServerHost);
            lk.ReleaseLock();
        }

    }
}
