using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HuFamily.Main;

namespace HuFamily.Wireless
{
    public partial class mainForm : Form
    {
        public mainForm()
        {
            InitializeComponent();
        }

        private void setButton_Click(object sender, EventArgs e)
        {
            if(ssidTextbox.Text != "")
            {
                debugBox.AppendText(Environment.NewLine + HostedNetwork.SetHostedNetwork(ssidTextbox.Text, passwdTextbox.Text));
                debugBox.AppendText(Environment.NewLine + HostedNetwork.SetStatus(enableCheckbox.Checked));
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
    }
}
