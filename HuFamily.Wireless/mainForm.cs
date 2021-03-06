﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using HuFamily.Main;
using Microsoft.Win32;

namespace HuFamily.Wireless
{
    public partial class mainForm : Form
    {
        public mainForm()
        {
            InitializeComponent();
        }

        public static class CtrlVar
        {
            public static bool enableAP = false;
            public static bool autoStart = false;
            public static string ssidName = string.Empty;
            public static string passWord = string.Empty;
        }

        private void setButton_Click(object sender, EventArgs e)
        {
            if(ssidTextbox.Text != "")
            {
                debugBox.AppendText(Environment.NewLine + HostedNetwork.SetHostedNetwork(ssidTextbox.Text, passwdTextbox.Text));
                debugBox.AppendText(Environment.NewLine + HostedNetwork.SetStatus(enableCheckbox.Checked));
                LocalSetting.WriteSetting(ssidTextbox.Text, passwdTextbox.Text, enableCheckbox.Checked, autoStartCheckbox.Checked);
                MessageBox.Show("设置信息已写入，请检查右边的调试信息是否正确！", "设置成功", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("SSID填写不正确，可能是未填写或存在非法字符！", "SSID错误", MessageBoxButtons.OK);
            }
        }

        private void readButton_Click(object sender, EventArgs e)
        {
            string[] result = HostedNetwork.GetHostedWirelessStatus();
            wirelessStatusLabel.Text = result[0] + ", " + result[5];
            ssidLabel.Text = result[1];
            bssidLabel.Text = result[6];
            encryptLabel.Text = result[3];
            wirelessTypeLabel.Text = result[7];
            channelLabel.Text = result[8];
        }

        private void mainForm_Load(object sender, EventArgs e)
        { 
            string[] result = LocalSetting.ReadSetting();
            CtrlVar.ssidName = ssidTextbox.Text = result[0];
            CtrlVar.passWord = passwdTextbox.Text = result[1];
            Boolean.TryParse(result[2], out CtrlVar.enableAP);
            Boolean.TryParse(result[3], out CtrlVar.autoStart);

            if(CtrlVar.autoStart)
            {
                addAutoStart();
            }
            else
            {

            }
        }

        private void addAutoStart()
        {
            debugBox.AppendText("**************\r\n自动启动即将生效，5秒后将应用相关设置\r\n**************");
            Thread.Sleep(5000);
            RegistryKey registerAutoStart = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);
            registerAutoStart.SetValue("HuFamilyWifi", Application.ExecutablePath);

            debugBox.AppendText(Environment.NewLine + HostedNetwork.SetHostedNetwork(ssidTextbox.Text, passwdTextbox.Text));
            debugBox.AppendText(Environment.NewLine + HostedNetwork.SetStatus(enableCheckbox.Checked));
        }

        private void remoteAutoStart()
        {
            debugBox.AppendText("**************\r\n自动启动即将生效\r\n***********************");
            RegistryKey registerAutoStart = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);
            registerAutoStart.DeleteValue("HuFamilyWifi");

            debugBox.AppendText(Environment.NewLine + HostedNetwork.SetHostedNetwork(ssidTextbox.Text, passwdTextbox.Text));
            debugBox.AppendText(Environment.NewLine + HostedNetwork.SetStatus(enableCheckbox.Checked));
        }

    }
}
