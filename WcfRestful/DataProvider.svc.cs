using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WcfRestful
{
    // 注意: 使用“重构”菜单上的“重命名”命令，可以同时更改代码、svc 和配置文件中的类名“DataProvider”。
    // 注意: 为了启动 WCF 测试客户端以测试此服务，请在解决方案资源管理器中选择 DataProvider.svc 或 DataProvider.svc.cs，然后开始调试。
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.Single)] //单例
    public class DataProvider : IDataProvider
    {
        private IList<UserInfo> ul;

        public DataProvider()
        {
            ul = new List<UserInfo>()
            {
                new UserInfo(){ ID=1, Name="tom", Sex=1},
                new UserInfo(){ ID=2, Name="lucy", Sex=0},
                new UserInfo(){ ID=3, Name="jerry", Sex=1},
                new UserInfo(){ ID=4, Name="jack", Sex=1}
            };
        }

        public void Update(string id, string name, string sex)
        {
            var user = ul.FirstOrDefault(item => item.ID == int.Parse(id));
            user.Name = name;
            user.Sex = int.Parse(sex);
        }

        public void Create(string name, string sex)
        {
            ul.Add(new UserInfo() { ID = ul.Count() + 1, Name = name, Sex = int.Parse(sex) });
        }

        public UserInfo Get(string id)
        {
            return ul.Where(n => n.ID == int.Parse(id)).FirstOrDefault();
        }

        public void Delete(string id)
        {
            ul.Remove(ul.Where(n => n.ID == int.Parse(id)).First());
        }
    }
}
