using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace BluetoothSetting
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void OpenBluetoothSearchListButton_OnClick(object sender, RoutedEventArgs e)
        {
            try
            {
                //打开蓝牙搜索列表
                var process = new Process { StartInfo = { FileName = "Explorer", Arguments = "shell:::{28803F59-3A75-4058-995F-4EE5503B023C}" } };
                process.Start();
            }
            catch (System.Exception)
            {
                // ignored
            }
        }

        private void OpenBluetoothSettingButton_OnClick(object sender, RoutedEventArgs e)
        {
            try
            {
                //打开蓝牙设置
                var process = new Process { StartInfo = { FileName = "control", Arguments = "bthprops.cpl" } };
                process.Start();
            }
            catch (System.Exception)
            {
                // ignored
            }
        }

        private void OpenBluetoothSetting2Button_OnClick(object sender, RoutedEventArgs e)
        {
            try
            {
                //打开蓝牙设置
                ExecuteCmdHelper.ExecuteCmd("start ms-settings:bluetooth");
            }
            catch (System.Exception)
            {
                // ignored
            }
        }
    }
}
