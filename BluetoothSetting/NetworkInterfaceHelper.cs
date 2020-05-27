using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;

namespace BluetoothSetting
{
    public static class NetworkInterfaceHelper
    {
        /// <summary>
        /// 是否含有蓝牙适配器
        /// </summary>
        /// <returns></returns>
        public static bool HasBluetoothNetwork()
        {
            //获取本地计算机上网络接口的对象
            NetworkInterface[] adapters = NetworkInterface.GetAllNetworkInterfaces();
            return adapters.Any(i => i.Name.Contains("蓝牙"));
        }
    }
}
