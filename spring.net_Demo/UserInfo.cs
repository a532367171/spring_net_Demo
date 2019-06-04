using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;

namespace spring.net_Demo
{
    public class UserInfo : IUserInfo
    {
        public string ShowMss()
        {
            using (var ctx = new samplemanageguodujksEntities1())

            {

                //列名必需要Entity属性匹配

                var studentList = ctx.仪器设备表.SqlQuery("Select * from 仪器设备表").ToList<仪器设备表>();

            }
            return "Hello Spring.NET";

        }
    }
}
