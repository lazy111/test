using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Web;
using System.Xml.Serialization;

namespace WcfRestful
{
    [DataContract, DataContractFormat]
    public class UserInfo
    {
        [DataMember]
        public int ID { get; set; }
        [DataMember]
        public string Name { get; set; }
        [DataMember]
        public int Sex { get; set; }
    }
}