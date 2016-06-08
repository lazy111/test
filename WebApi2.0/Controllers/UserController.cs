using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApi2._0.Models;

namespace WebApi2._0.Controllers
{
    public class UserController : ApiController
    {
        public User Get()
        {
            throw new Exception("未知错误！");
            return new User() { Name = "tom" };
        }
    }
}
