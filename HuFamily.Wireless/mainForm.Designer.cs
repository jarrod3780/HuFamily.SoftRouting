namespace HuFamily.Wireless
{
    partial class mainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.settingGroup = new System.Windows.Forms.GroupBox();
            this.autoStartCheckbox = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.channelLabel = new System.Windows.Forms.Label();
            this.wirelessTypeLabel = new System.Windows.Forms.Label();
            this.encryptLabel = new System.Windows.Forms.Label();
            this.bssidLabel = new System.Windows.Forms.Label();
            this.ssidLabel = new System.Windows.Forms.Label();
            this.wirelessStatusLabel = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.enableCheckbox = new System.Windows.Forms.CheckBox();
            this.passwdTextbox = new System.Windows.Forms.TextBox();
            this.ssidTextbox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.readButton = new System.Windows.Forms.Button();
            this.setButton = new System.Windows.Forms.Button();
            this.debugBox = new System.Windows.Forms.RichTextBox();
            this.settingGroup.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // settingGroup
            // 
            this.settingGroup.Controls.Add(this.autoStartCheckbox);
            this.settingGroup.Controls.Add(this.groupBox1);
            this.settingGroup.Controls.Add(this.button4);
            this.settingGroup.Controls.Add(this.label5);
            this.settingGroup.Controls.Add(this.button3);
            this.settingGroup.Controls.Add(this.label3);
            this.settingGroup.Controls.Add(this.enableCheckbox);
            this.settingGroup.Controls.Add(this.passwdTextbox);
            this.settingGroup.Controls.Add(this.ssidTextbox);
            this.settingGroup.Controls.Add(this.label2);
            this.settingGroup.Controls.Add(this.label1);
            this.settingGroup.Controls.Add(this.readButton);
            this.settingGroup.Controls.Add(this.setButton);
            this.settingGroup.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.settingGroup.Location = new System.Drawing.Point(12, 12);
            this.settingGroup.Name = "settingGroup";
            this.settingGroup.Size = new System.Drawing.Size(762, 935);
            this.settingGroup.TabIndex = 0;
            this.settingGroup.TabStop = false;
            this.settingGroup.Text = "Hosted Network 设置";
            // 
            // autoStartCheckbox
            // 
            this.autoStartCheckbox.AutoSize = true;
            this.autoStartCheckbox.Checked = true;
            this.autoStartCheckbox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.autoStartCheckbox.Location = new System.Drawing.Point(425, 228);
            this.autoStartCheckbox.Name = "autoStartCheckbox";
            this.autoStartCheckbox.Size = new System.Drawing.Size(149, 32);
            this.autoStartCheckbox.TabIndex = 14;
            this.autoStartCheckbox.Text = "随开机启动";
            this.autoStartCheckbox.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.channelLabel);
            this.groupBox1.Controls.Add(this.wirelessTypeLabel);
            this.groupBox1.Controls.Add(this.encryptLabel);
            this.groupBox1.Controls.Add(this.bssidLabel);
            this.groupBox1.Controls.Add(this.ssidLabel);
            this.groupBox1.Controls.Add(this.wirelessStatusLabel);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Location = new System.Drawing.Point(33, 335);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(704, 373);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "无线信息";
            // 
            // channelLabel
            // 
            this.channelLabel.AutoSize = true;
            this.channelLabel.Location = new System.Drawing.Point(202, 316);
            this.channelLabel.Name = "channelLabel";
            this.channelLabel.Size = new System.Drawing.Size(54, 28);
            this.channelLabel.TabIndex = 27;
            this.channelLabel.Text = "未知";
            // 
            // wirelessTypeLabel
            // 
            this.wirelessTypeLabel.AutoSize = true;
            this.wirelessTypeLabel.Location = new System.Drawing.Point(202, 266);
            this.wirelessTypeLabel.Name = "wirelessTypeLabel";
            this.wirelessTypeLabel.Size = new System.Drawing.Size(54, 28);
            this.wirelessTypeLabel.TabIndex = 26;
            this.wirelessTypeLabel.Text = "未知";
            // 
            // encryptLabel
            // 
            this.encryptLabel.AutoSize = true;
            this.encryptLabel.Location = new System.Drawing.Point(202, 212);
            this.encryptLabel.Name = "encryptLabel";
            this.encryptLabel.Size = new System.Drawing.Size(54, 28);
            this.encryptLabel.TabIndex = 25;
            this.encryptLabel.Text = "未知";
            // 
            // bssidLabel
            // 
            this.bssidLabel.AutoSize = true;
            this.bssidLabel.Location = new System.Drawing.Point(202, 158);
            this.bssidLabel.Name = "bssidLabel";
            this.bssidLabel.Size = new System.Drawing.Size(54, 28);
            this.bssidLabel.TabIndex = 24;
            this.bssidLabel.Text = "未知";
            // 
            // ssidLabel
            // 
            this.ssidLabel.AutoSize = true;
            this.ssidLabel.Location = new System.Drawing.Point(202, 106);
            this.ssidLabel.Name = "ssidLabel";
            this.ssidLabel.Size = new System.Drawing.Size(54, 28);
            this.ssidLabel.TabIndex = 23;
            this.ssidLabel.Text = "未知";
            // 
            // wirelessStatusLabel
            // 
            this.wirelessStatusLabel.AutoSize = true;
            this.wirelessStatusLabel.Location = new System.Drawing.Point(202, 54);
            this.wirelessStatusLabel.Name = "wirelessStatusLabel";
            this.wirelessStatusLabel.Size = new System.Drawing.Size(54, 28);
            this.wirelessStatusLabel.TabIndex = 22;
            this.wirelessStatusLabel.Text = "未知";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(104, 158);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(92, 28);
            this.label11.TabIndex = 21;
            this.label11.Text = "BSSID：";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(121, 316);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(75, 28);
            this.label10.TabIndex = 20;
            this.label10.Text = "频道：";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(79, 266);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(117, 28);
            this.label8.TabIndex = 19;
            this.label8.Text = "无线类型：";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(79, 212);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(117, 28);
            this.label9.TabIndex = 18;
            this.label9.Text = "加密方式：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(67, 167);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 28);
            this.label4.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(117, 106);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 28);
            this.label7.TabIndex = 15;
            this.label7.Text = "SSID：";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(79, 54);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(117, 28);
            this.label6.TabIndex = 14;
            this.label6.Text = "是否启动：";
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button4.Location = new System.Drawing.Point(33, 851);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(703, 78);
            this.button4.TabIndex = 12;
            this.button4.Text = "关于作者";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(62, 451);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 28);
            this.label5.TabIndex = 10;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(516, 751);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(220, 83);
            this.button3.TabIndex = 8;
            this.button3.Text = "重启无线";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(99, 228);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 28);
            this.label3.TabIndex = 7;
            this.label3.Text = "无线开关：";
            // 
            // enableCheckbox
            // 
            this.enableCheckbox.AutoSize = true;
            this.enableCheckbox.Checked = true;
            this.enableCheckbox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.enableCheckbox.Location = new System.Drawing.Point(240, 228);
            this.enableCheckbox.Name = "enableCheckbox";
            this.enableCheckbox.Size = new System.Drawing.Size(156, 32);
            this.enableCheckbox.TabIndex = 6;
            this.enableCheckbox.Text = "启用无线AP";
            this.enableCheckbox.UseVisualStyleBackColor = true;
            // 
            // passwdTextbox
            // 
            this.passwdTextbox.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.passwdTextbox.Location = new System.Drawing.Point(222, 141);
            this.passwdTextbox.Name = "passwdTextbox";
            this.passwdTextbox.Size = new System.Drawing.Size(514, 42);
            this.passwdTextbox.TabIndex = 5;
            this.passwdTextbox.UseSystemPasswordChar = true;
            // 
            // ssidTextbox
            // 
            this.ssidTextbox.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ssidTextbox.Location = new System.Drawing.Point(222, 59);
            this.ssidTextbox.Name = "ssidTextbox";
            this.ssidTextbox.Size = new System.Drawing.Size(514, 42);
            this.ssidTextbox.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(141, 145);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 28);
            this.label2.TabIndex = 3;
            this.label2.Text = "密码：\r\n";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(189, 28);
            this.label1.TabIndex = 2;
            this.label1.Text = "无线名称（SSID）:";
            // 
            // readButton
            // 
            this.readButton.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.readButton.Location = new System.Drawing.Point(275, 751);
            this.readButton.Name = "readButton";
            this.readButton.Size = new System.Drawing.Size(220, 83);
            this.readButton.TabIndex = 1;
            this.readButton.Text = "读取设置";
            this.readButton.UseVisualStyleBackColor = true;
            this.readButton.Click += new System.EventHandler(this.readButton_Click);
            // 
            // setButton
            // 
            this.setButton.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.setButton.Location = new System.Drawing.Point(32, 751);
            this.setButton.Name = "setButton";
            this.setButton.Size = new System.Drawing.Size(220, 83);
            this.setButton.TabIndex = 0;
            this.setButton.Text = "写入设置";
            this.setButton.UseVisualStyleBackColor = true;
            this.setButton.Click += new System.EventHandler(this.setButton_Click);
            // 
            // debugBox
            // 
            this.debugBox.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.debugBox.Location = new System.Drawing.Point(788, 32);
            this.debugBox.Name = "debugBox";
            this.debugBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedBoth;
            this.debugBox.Size = new System.Drawing.Size(1039, 915);
            this.debugBox.TabIndex = 1;
            this.debugBox.Text = "HuFamily无线设置工具  By Jackson Ming Hu\nNetSh输出信息调试窗口\n--------------------------------" +
    "--------\n\n\n\n";
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1839, 961);
            this.Controls.Add(this.debugBox);
            this.Controls.Add(this.settingGroup);
            this.Name = "mainForm";
            this.Text = "HuFamily.Wireless Configurator - NETSH Frontend";
            this.settingGroup.ResumeLayout(false);
            this.settingGroup.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox settingGroup;
        private System.Windows.Forms.CheckBox autoStartCheckbox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label channelLabel;
        private System.Windows.Forms.Label wirelessTypeLabel;
        private System.Windows.Forms.Label encryptLabel;
        private System.Windows.Forms.Label bssidLabel;
        private System.Windows.Forms.Label ssidLabel;
        private System.Windows.Forms.Label wirelessStatusLabel;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox enableCheckbox;
        private System.Windows.Forms.TextBox passwdTextbox;
        private System.Windows.Forms.TextBox ssidTextbox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button readButton;
        private System.Windows.Forms.Button setButton;
        private System.Windows.Forms.RichTextBox debugBox;
    }
}

