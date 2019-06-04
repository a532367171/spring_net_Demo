using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace spring.net_Demo
{
    public class UserInfo : IUserInfo
    {
        public string ShowMss()
        {
            return "Hello Spring.NET";
        }
    }
}
