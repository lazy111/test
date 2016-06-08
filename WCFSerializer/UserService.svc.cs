using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WCFSerializer
{
    // 注意: 使用“重构”菜单上的“重命名”命令，可以同时更改代码、svc 和配置文件中的类名“UserService”。
    // 注意: 为了启动 WCF 测试客户端以测试此服务，请在解决方案资源管理器中选择 UserService.svc 或 UserService.svc.cs，然后开始调试。
    public class UserService : IUserService
    {

        private IList<UserInfo> _userlst;

        public UserService()
        {
            this._userlst = new List<UserInfo>()
            {
                new UserInfo(){ ID=1, Name="Tom", Age=11, EMail="tom@gmail.com"},
                new UserInfo(){ ID=2, Name="Jerry", Age=11, EMail="jerry@hotmail.com"},
                new UserInfo(){ ID=3, Name="Jack", Age=11, EMail="jack@163.com"},
                new UserInfo(){ ID=4, Name="Linda", Age=11, EMail="linda@gmail.com"}

            };
        }

        public IList<UserInfo> GetUserInfos()
        {
            return _userlst;
        }

        public UserInfo GetUserInfo(int id)
        {
            return _userlst.Where(item => item.ID == id).FirstOrDefault();
        }
    }
}
