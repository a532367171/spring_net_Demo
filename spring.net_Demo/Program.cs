using Spring.Context;
using Spring.Context.Support;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace spring.net_Demo
{
    class Program
    {
        static void Main(string[] args)
        {

            IApplicationContext ctx = ContextRegistry.GetContext();

            IUserInfo userInfo = (IUserInfo)ctx.GetObject("UserInfo");

            Console.WriteLine(userInfo.ShowMss());

            Console.Read();
            
        }
    }
}
