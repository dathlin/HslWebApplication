using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace HslWebApplication2.Database
{
    public static class SoftResources
    {
        public static string SqlConnection = "Data Source = 127.0.0.1;Initial Catalog = HslDatabase;User Id = sa;Password = hushaolin;";
    }




    public class SoftAccount : HslCommunication.BasicFramework.ISqlDataType
    {
        public static List<SoftAccount> GetAllList()
        {
            return HslCommunication.BasicFramework.SoftSqlOperate.ExecuteSelectEnumerable<SoftAccount>(SoftResources.SqlConnection,
                "SELECT * FROM DBO.人员信息表");
        }


        public int Seque { get; private set; } = 0;

        public string UserName { get; set; }
        public string Password { get; set; }
        public string State { get; set; }
        public string Sex { get; set; } = "男";
        public string Department { get; set; }
        public string Branch { get; set; }
        public string Job { get; set; }
        public string Birthday { get; set; }
        public string RegTime { get; set; }
        public string LoginTime { get; set; }
        public string PhoneShort { get; set; }
        public string Phone { get; set; }
        public string EMail { get; set; }

        public void LoadBySqlDataReader(SqlDataReader sdr)
        {
            Seque = Convert.ToInt32(sdr["序号"]);
            UserName = sdr["用户名"].ToString();
            Password = sdr["密码"].ToString();
            State = sdr["状态"].ToString();
            Sex = sdr["性别"].ToString();
            Department = sdr["部门"].ToString();
            Branch = sdr["科室"].ToString();
            Job = sdr["职位"].ToString();
            Birthday = Convert.ToDateTime(sdr["出生日期"]).ToString("yyyy-MM-dd");
            RegTime = Convert.ToDateTime(sdr["注册时间"]).ToString("yyyy-MM-dd HH:mm:ss");
            LoginTime = Convert.ToDateTime(sdr["登录时间"]).ToString("yyyy-MM-dd HH:mm:ss");
            PhoneShort = sdr["手机短号"].ToString();
            Phone = sdr["手机长号"].ToString();
            EMail = sdr["邮箱"].ToString();
        }
    }
}