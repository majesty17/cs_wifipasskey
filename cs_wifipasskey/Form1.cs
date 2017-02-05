using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using NativeWifi;
using System.Threading;

namespace wifi万能钥匙
{
    public partial class Form1 : Form
    {
        //wlan客户端
        WlanClient client = null;//new WlanClient();
        WlanClient.WlanInterface wlanIface = null;
        Wlan.WlanBssEntry[] bssworks = null;
        public Form1()
        {
            InitializeComponent();
        }




        //开始扫描
        private void button_scan_Click(object sender, EventArgs e)
        {
            //找到当前的wlan设备
            client = new WlanClient();

            if (client.Interfaces.Length == 0) {
                MessageBox.Show("未找到无线网卡！");
                return;
            }
            //找到第一个wlan设备
            wlanIface = client.Interfaces[0];
            //开始扫描
            timer_scan.Interval = 1000;
            timer_scan.Start();


            //foreach (WlanClient.WlanInterface wlanIface in client.Interfaces)
            //{
            //    Wlan.WlanBssEntry[] bssworks = wlanIface.GetNetworkBssList();
            //    foreach (Wlan.WlanBssEntry bsswork in bssworks)
            //    {
            //        str = SsidToString(bsswork.dot11Ssid);
            //        Console.WriteLine(str);
            //        Console.WriteLine(BitConverter.ToString(bsswork.dot11Bssid));
            //        Console.WriteLine(bsswork.rssi);
            //        Console.WriteLine();
                    
            //    }
            //}
            button_scan.Enabled = false;
            button_scan.Text = "扫描中...";
        }
        //停止扫描
        private void button_stop_Click(object sender, EventArgs e)
        {
            button_scan.Enabled = true;
            button_scan.Text = "扫描";
            timer_scan.Stop();
        }
        //timer循环
        private void timer_scan_Tick(object sender, EventArgs e)
        {
            //1,获取当前检测到的AP
            
            bssworks = wlanIface.GetNetworkBssList();
            

            Console.Out.WriteLine(bssworks.Length + " 个AP检测到。");

            //2,merge到当前list中

            //listView1.Items.Clear();

            String str = null;
            String mac = null;
            foreach (Wlan.WlanBssEntry bsswork in bssworks)
            {
                str = SsidToString(bsswork.dot11Ssid);
                mac = BitConverter.ToString(bsswork.dot11Bssid);
                //Console.WriteLine(str);
                //Console.WriteLine(mac);
                //Console.WriteLine(bsswork.rssi);
                //Console.WriteLine();


                int index = FindMacInItems(listView1, mac);
                //Console.Out.WriteLine("index is " + index);
                //没有的话才加入
                if (index == -1) {
                    ListViewItem lvi = new ListViewItem(str);
                    lvi.SubItems.Add(mac);
                    lvi.SubItems.Add(bsswork.rssi + "");
                    lvi.SubItems.Add("***");
                    listView1.Items.Add(lvi);
                }
            }

            //关键，没有这个的话，每次都是一样的
            wlanIface.Scan();
        }
















        //ssid转为字符串
        private static string SsidToString(Wlan.Dot11Ssid ssid)
        {
            return Encoding.Default.GetString(ssid.SSID, 0, (int)ssid.SSIDLength);
        }
        //找在不在list里
        private static int FindMacInItems(ListView lv, String mac) {
            if (lv == null) {
                return -1;
            }
            int i = 0;
            foreach (ListViewItem item in lv.Items) {
                if(item.SubItems[1].Text.Equals(mac)){
                    return i;
                }
                i++;
            }
            return -1;
        }


        //试图查询一个密码
        private void 查询密码ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 0) {
                return;
            }

            ListViewItem item =listView1.SelectedItems[0];
            String mac = item.SubItems[1].Text;

            MessageBox.Show("mac is " + mac);




            String password = WifiPass.getPassword(mac);
            if (password != null) {
                item.SubItems[3].Text = password;
            }
        }


    }
}
