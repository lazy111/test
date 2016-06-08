using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Collections.ObjectModel;

namespace WcfWorkService
{
    public class RouteMapping
    {
        public string Address { get; set; }
        public Type ServiceType { get; set; }
        public RouteMapping(string address, Type serviceType)
        {
            this.Address = address;
            this.ServiceType = serviceType;
        }

    }
    public class RouteTable : Collection<RouteMapping>
    {
        public static RouteTable Routes { get; private set; }

        static RouteTable()
        {
            Routes = new RouteTable();
        }
        public Type Find(string address)
        {
            //return this.Where(item => item.Address == address).FirstOrDefault().ServiceType;

            RouteMapping mapping = (
                from route in this
                where String.Compare(route.Address, address, true) == 0
                select route
            ).FirstOrDefault();

            return mapping == null ? null : mapping.ServiceType;




        }

        public void Register<T>(string address)
        {
            this.Add(new RouteMapping(address, typeof(T)));
        }


    }
}