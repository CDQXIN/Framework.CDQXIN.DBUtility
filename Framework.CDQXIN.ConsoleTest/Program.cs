using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Framework.CDQXIN.ConsoleTest
{
    class Program
    {
        static void Main(string[] args)
        {
            SQLiteHandle sh = new SQLiteHandle();
            ////增加
            //bool flag = sh.Add(new UserInfo() { UserName = "pull", Pwd = "123456", Age = 33 });
            //if (flag)
            //{
            //    Console.WriteLine("插入成功");
            //}
            //else
            //{
            //    Console.WriteLine("插入失败");
            //}

            //查询
            //var model=sh.GetModel(1);
            //Console.WriteLine(JsonConvert.SerializeObject(model));

            //修改
            //UserInfo en = new UserInfo() { 
            //ID=1,
            //UserName="jim",
            //Pwd="123456789",
            //Age=19
            //};
            //if (sh.Update(en))
            //{
            //    Console.WriteLine("操作成功！");
            //}
            //删除
            if(sh.Delete(1))
            {
                Console.WriteLine("ol");
            }

            Console.ReadLine();
        }
    }
}
