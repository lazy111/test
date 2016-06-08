using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebAPI.Models;

namespace WebAPI.Controllers
{
    public class IPAddressController : ApiController
    {
        public static IList<Address> Address = new List<Address>(){
            new Address(){IPAddress="192.168.1.1",Provice="北京市", City="北京市"},
            new Address(){IPAddress="51.112.15.11",Provice="河北省",City="邯郸市"},
            new Address(){IPAddress="221.124.57.8",Provice="北京市", City="北京市"}
        };

        public IEnumerable<Address> GetIPAddresses()
        {
            return Address;
        }
        public IEnumerable<Address> GetBeiJingIPAddresses() {
            return Address.Where<Address>(item => item.Provice == "北京市").ToList();
        }
        public Address GetIPAddressByIP(string ip)
        {
            return Address.Where(item => item.IPAddress == ip).FirstOrDefault();
        }


    }
}
