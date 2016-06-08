using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WcfRestful
{
    // 注意: 使用“重构”菜单上的“重命名”命令，可以同时更改代码和配置文件中的接口名“IDataProvider”。
    [ServiceContract(Namespace = "WCF.REST")]
    [DataContractFormat]//只有datacontractformat支持json序列化
    public interface IDataProvider
    {

        [OperationContract]
        [WebInvoke(UriTemplate = "/dataprovider/update", BodyStyle = WebMessageBodyStyle.Wrapped, Method = "POST", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        void Update(string id, string name, string age);
        [OperationContract]
        [WebInvoke(UriTemplate = "/dataprovider/create/{name}/{age}", Method = "POST", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        void Create(string name, string age);
        [OperationContract]
        [WebGet(UriTemplate = "/dataprovider/get/{id}", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        UserInfo Get(string id);
        [OperationContract]
        [WebInvoke(UriTemplate = "/dataprovider/delete/{id}", Method = "POST", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        void Delete(string id);
    }
}
