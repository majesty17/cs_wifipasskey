using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;

namespace wifi万能钥匙
{
    class WifiPass
    {

        public static String getPassword(String name,String mac) {

            mac = mac.Replace("-", "").ToUpper();
            WebClient client = new WebClient();

            try{
                byte[] out_byte=client.DownloadData("http://www.wifi4.cn/wifi/" + name + "/" + mac + "/");
                String out_str = Encoding.UTF8.GetString(out_byte);
                string[] str_spl = out_str.Split(new string[] { "<strong title=\"当前密码记录\">" }, StringSplitOptions.None);
                str_spl = str_spl[1].Split(new string[] { "<i>(" }, StringSplitOptions.None);
                return str_spl[0];
            }
            catch{
                return "未查询到密码";
            }


            
        }
    }
}
