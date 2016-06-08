using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZooKeeperNet;

namespace Zookeeper
{
    public class Config
    {

        private static string config_root = "/config1";
        private static string config_user = "/config1/user";
        private static string config_passwd = "/config1/passwd";

        private static string auth_type = "digest";
        private static string auth_passwd = "admin";







        public static void StartConfig()
        {
            ZooKeeperNet.ZooKeeper zk = new ZooKeeperNet.ZooKeeper("127.0.0.1:2181", new TimeSpan(1, 0, 0), new Watch());

            zk.AddAuthInfo(auth_type, auth_passwd.GetBytes());

            if (zk.Exists(config_root, true) == null)
            {
                //设置Auth后，创建Node需要使用acl访问控制列表
                zk.Create(config_root, "config".GetBytes(), Ids.CREATOR_ALL_ACL, CreateMode.Persistent);
            }
            if (zk.Exists(config_user, true) == null)
            {
                zk.Create(config_user, "admin".GetBytes(), Ids.CREATOR_ALL_ACL, CreateMode.Persistent);
            }
            if (zk.Exists(config_passwd, true) == null)
            {
                zk.Create(config_passwd, "admin".GetBytes(), Ids.CREATOR_ALL_ACL, CreateMode.Persistent);
            }
        }

    }

    public class Watch : IWatcher
    {

        public void Process(WatchedEvent @event)
        {
            if (@event.Type == EventType.NodeDataChanged)
            {
            }
        }
    }
}
