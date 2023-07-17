﻿using System;
using System.Windows.Forms;

namespace MiHoYoStarter
{
    partial class FormMain
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tab1 = new System.Windows.Forms.TabControl();
            this.tabPageGenshin = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chkGenshinAutoStart = new System.Windows.Forms.CheckBox();
            this.picHelpSatrtParam = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtGenshinStartParam = new System.Windows.Forms.TextBox();
            this.txtGenshinPath = new System.Windows.Forms.TextBox();
            this.lblPathTag = new System.Windows.Forms.Label();
            this.btnGenshinChoosePath = new System.Windows.Forms.Button();
            this.btnGenshinDelete = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnGenshinSwitch = new System.Windows.Forms.Button();
            this.btnGenshinAdd = new System.Windows.Forms.Button();
            this.lvwGenshinAcct = new System.Windows.Forms.ListView();
            this.name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabPageGenshinCloud = new System.Windows.Forms.TabPage();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.chkGenshinCloudAutoStart = new System.Windows.Forms.CheckBox();
            this.txtGenshinCloudPath = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnGenshinCloudChoosePath = new System.Windows.Forms.Button();
            this.btnGenshinCloudDelete = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.btnGenshinCloudSwitch = new System.Windows.Forms.Button();
            this.btnGenshinCloudAdd = new System.Windows.Forms.Button();
            this.lvwGenshinCloudAcct = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabPageSatrRail = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnStarRailFPSEdit = new System.Windows.Forms.Button();
            this.numericUpDownFPS = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.comboStarRailServer = new System.Windows.Forms.ComboBox();
            this.btnStarRailStart = new System.Windows.Forms.Button();
            this.chkStarRailAutoStart = new System.Windows.Forms.CheckBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtStarRailStartParam = new System.Windows.Forms.TextBox();
            this.txtStarRailPath = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnStarRailChoosePath = new System.Windows.Forms.Button();
            this.btnStarRailDelete = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.btnStarRailSwitch = new System.Windows.Forms.Button();
            this.btnStarRailAdd = new System.Windows.Forms.Button();
            this.lvwStarRailAcct = new System.Windows.Forms.ListView();
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabPageHonkaiImpact3 = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.chkHonkaiImpact3AutoStart = new System.Windows.Forms.CheckBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtHonkaiImpact3StartParam = new System.Windows.Forms.TextBox();
            this.txtHonkaiImpact3Path = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnHonkaiImpact3ChoosePath = new System.Windows.Forms.Button();
            this.btnHonkaiImpact3Delete = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.btnHonkaiImpact3Switch = new System.Windows.Forms.Button();
            this.btnHonkaiImpact3Add = new System.Windows.Forms.Button();
            this.lvwHonkaiImpact3Acct = new System.Windows.Forms.ListView();
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.设置ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DisplayGenshinTabToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DisplayGenshinCloudTabToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DisplayStarRailTabToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DisplayHonkaiImpact3TabToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.帮助ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.主页ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.请作者喝咖啡ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.显示主界面ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.退出ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tipHelp = new System.Windows.Forms.ToolTip(this.components);
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tab1.SuspendLayout();
            this.tabPageGenshin.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picHelpSatrtParam)).BeginInit();
            this.tabPageGenshinCloud.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.tabPageSatrRail.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownFPS)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabPageHonkaiImpact3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tab1
            // 
            this.tab1.Controls.Add(this.tabPageGenshin);
            this.tab1.Controls.Add(this.tabPageGenshinCloud);
            this.tab1.Controls.Add(this.tabPageSatrRail);
            this.tab1.Controls.Add(this.tabPageHonkaiImpact3);
            this.tab1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tab1.Location = new System.Drawing.Point(0, 28);
            this.tab1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tab1.Name = "tab1";
            this.tab1.SelectedIndex = 0;
            this.tab1.Size = new System.Drawing.Size(462, 408);
            this.tab1.TabIndex = 0;
            // 
            // tabPageGenshin
            // 
            this.tabPageGenshin.BackColor = System.Drawing.Color.White;
            this.tabPageGenshin.Controls.Add(this.groupBox1);
            this.tabPageGenshin.Location = new System.Drawing.Point(4, 25);
            this.tabPageGenshin.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tabPageGenshin.Name = "tabPageGenshin";
            this.tabPageGenshin.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tabPageGenshin.Size = new System.Drawing.Size(454, 379);
            this.tabPageGenshin.TabIndex = 0;
            this.tabPageGenshin.Text = "原神";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.chkGenshinAutoStart);
            this.groupBox1.Controls.Add(this.picHelpSatrtParam);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtGenshinStartParam);
            this.groupBox1.Controls.Add(this.txtGenshinPath);
            this.groupBox1.Controls.Add(this.lblPathTag);
            this.groupBox1.Controls.Add(this.btnGenshinChoosePath);
            this.groupBox1.Controls.Add(this.btnGenshinDelete);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnGenshinSwitch);
            this.groupBox1.Controls.Add(this.btnGenshinAdd);
            this.groupBox1.Controls.Add(this.lvwGenshinAcct);
            this.groupBox1.Location = new System.Drawing.Point(11, 8);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Size = new System.Drawing.Size(428, 333);
            this.groupBox1.TabIndex = 39;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "账号切换";
            // 
            // chkGenshinAutoStart
            // 
            this.chkGenshinAutoStart.AutoSize = true;
            this.chkGenshinAutoStart.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.chkGenshinAutoStart.Location = new System.Drawing.Point(149, 83);
            this.chkGenshinAutoStart.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chkGenshinAutoStart.Name = "chkGenshinAutoStart";
            this.chkGenshinAutoStart.Size = new System.Drawing.Size(104, 19);
            this.chkGenshinAutoStart.TabIndex = 39;
            this.chkGenshinAutoStart.Text = "切换时重启";
            this.chkGenshinAutoStart.UseVisualStyleBackColor = true;
            // 
            // picHelpSatrtParam
            // 
            this.picHelpSatrtParam.Image = global::MiHoYoStarter.Properties.Resources.attention;
            this.picHelpSatrtParam.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.picHelpSatrtParam.Location = new System.Drawing.Point(101, 83);
            this.picHelpSatrtParam.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.picHelpSatrtParam.Name = "picHelpSatrtParam";
            this.picHelpSatrtParam.Size = new System.Drawing.Size(21, 20);
            this.picHelpSatrtParam.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picHelpSatrtParam.TabIndex = 38;
            this.picHelpSatrtParam.TabStop = false;
            this.tipHelp.SetToolTip(this.picHelpSatrtParam, "如果你不知道什么是启动参数请不要填写。\r\n常见启动参数：\r\n无边框 -popupwindow\r\n指定分辨率 -screen-width 1600 -screen-" +
        "height 900\r\n");
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label2.Location = new System.Drawing.Point(20, 87);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 15);
            this.label2.TabIndex = 37;
            this.label2.Text = "启动参数：";
            // 
            // txtGenshinStartParam
            // 
            this.txtGenshinStartParam.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtGenshinStartParam.Location = new System.Drawing.Point(19, 105);
            this.txtGenshinStartParam.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtGenshinStartParam.Name = "txtGenshinStartParam";
            this.txtGenshinStartParam.Size = new System.Drawing.Size(400, 25);
            this.txtGenshinStartParam.TabIndex = 36;
            // 
            // txtGenshinPath
            // 
            this.txtGenshinPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtGenshinPath.Location = new System.Drawing.Point(19, 52);
            this.txtGenshinPath.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtGenshinPath.Name = "txtGenshinPath";
            this.txtGenshinPath.Size = new System.Drawing.Size(347, 25);
            this.txtGenshinPath.TabIndex = 33;
            // 
            // lblPathTag
            // 
            this.lblPathTag.AutoSize = true;
            this.lblPathTag.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblPathTag.Location = new System.Drawing.Point(20, 33);
            this.lblPathTag.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPathTag.Name = "lblPathTag";
            this.lblPathTag.Size = new System.Drawing.Size(172, 15);
            this.lblPathTag.TabIndex = 32;
            this.lblPathTag.Text = "【原神】游戏程序路径：";
            // 
            // btnGenshinChoosePath
            // 
            this.btnGenshinChoosePath.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGenshinChoosePath.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnGenshinChoosePath.Location = new System.Drawing.Point(375, 50);
            this.btnGenshinChoosePath.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnGenshinChoosePath.Name = "btnGenshinChoosePath";
            this.btnGenshinChoosePath.Size = new System.Drawing.Size(45, 28);
            this.btnGenshinChoosePath.TabIndex = 34;
            this.btnGenshinChoosePath.Text = "...";
            this.btnGenshinChoosePath.UseVisualStyleBackColor = true;
            // 
            // btnGenshinDelete
            // 
            this.btnGenshinDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGenshinDelete.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnGenshinDelete.Location = new System.Drawing.Point(300, 285);
            this.btnGenshinDelete.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnGenshinDelete.Name = "btnGenshinDelete";
            this.btnGenshinDelete.Size = new System.Drawing.Size(120, 30);
            this.btnGenshinDelete.TabIndex = 28;
            this.btnGenshinDelete.Text = "删除选中账号";
            this.btnGenshinDelete.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(20, 152);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 15);
            this.label1.TabIndex = 27;
            this.label1.Text = "保存账号列表：";
            // 
            // btnGenshinSwitch
            // 
            this.btnGenshinSwitch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGenshinSwitch.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnGenshinSwitch.Location = new System.Drawing.Point(300, 168);
            this.btnGenshinSwitch.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnGenshinSwitch.Name = "btnGenshinSwitch";
            this.btnGenshinSwitch.Size = new System.Drawing.Size(120, 75);
            this.btnGenshinSwitch.TabIndex = 26;
            this.btnGenshinSwitch.Text = "切换选中账号";
            this.btnGenshinSwitch.UseVisualStyleBackColor = true;
            // 
            // btnGenshinAdd
            // 
            this.btnGenshinAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGenshinAdd.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnGenshinAdd.Location = new System.Drawing.Point(299, 249);
            this.btnGenshinAdd.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnGenshinAdd.Name = "btnGenshinAdd";
            this.btnGenshinAdd.Size = new System.Drawing.Size(120, 30);
            this.btnGenshinAdd.TabIndex = 25;
            this.btnGenshinAdd.Text = "保存当前账号";
            this.btnGenshinAdd.UseVisualStyleBackColor = true;
            // 
            // lvwGenshinAcct
            // 
            this.lvwGenshinAcct.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.lvwGenshinAcct.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lvwGenshinAcct.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.name});
            this.lvwGenshinAcct.Cursor = System.Windows.Forms.Cursors.Default;
            this.lvwGenshinAcct.Font = new System.Drawing.Font("宋体", 12F);
            this.lvwGenshinAcct.FullRowSelect = true;
            this.lvwGenshinAcct.HideSelection = false;
            this.lvwGenshinAcct.HoverSelection = true;
            this.lvwGenshinAcct.Location = new System.Drawing.Point(19, 168);
            this.lvwGenshinAcct.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lvwGenshinAcct.MultiSelect = false;
            this.lvwGenshinAcct.Name = "lvwGenshinAcct";
            this.lvwGenshinAcct.Size = new System.Drawing.Size(273, 147);
            this.lvwGenshinAcct.TabIndex = 24;
            this.lvwGenshinAcct.UseCompatibleStateImageBehavior = false;
            this.lvwGenshinAcct.View = System.Windows.Forms.View.Details;
            this.lvwGenshinAcct.SelectedIndexChanged += new System.EventHandler(this.lvwGenshinAcct_SelectedIndexChanged);
            this.lvwGenshinAcct.MouseUp += new System.Windows.Forms.MouseEventHandler(this.lvwGenshinAcct_MouseUp);
            // 
            // name
            // 
            this.name.Text = "名称";
            this.name.Width = 200;
            // 
            // tabPageGenshinCloud
            // 
            this.tabPageGenshinCloud.BackColor = System.Drawing.Color.White;
            this.tabPageGenshinCloud.Controls.Add(this.groupBox6);
            this.tabPageGenshinCloud.Location = new System.Drawing.Point(4, 25);
            this.tabPageGenshinCloud.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tabPageGenshinCloud.Name = "tabPageGenshinCloud";
            this.tabPageGenshinCloud.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tabPageGenshinCloud.Size = new System.Drawing.Size(454, 379);
            this.tabPageGenshinCloud.TabIndex = 1;
            this.tabPageGenshinCloud.Text = "云·原神";
            // 
            // groupBox6
            // 
            this.groupBox6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox6.Controls.Add(this.chkGenshinCloudAutoStart);
            this.groupBox6.Controls.Add(this.txtGenshinCloudPath);
            this.groupBox6.Controls.Add(this.label5);
            this.groupBox6.Controls.Add(this.btnGenshinCloudChoosePath);
            this.groupBox6.Controls.Add(this.btnGenshinCloudDelete);
            this.groupBox6.Controls.Add(this.label11);
            this.groupBox6.Controls.Add(this.btnGenshinCloudSwitch);
            this.groupBox6.Controls.Add(this.btnGenshinCloudAdd);
            this.groupBox6.Controls.Add(this.lvwGenshinCloudAcct);
            this.groupBox6.Location = new System.Drawing.Point(11, 8);
            this.groupBox6.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox6.Size = new System.Drawing.Size(476, 529);
            this.groupBox6.TabIndex = 43;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "账号切换";
            // 
            // chkGenshinCloudAutoStart
            // 
            this.chkGenshinCloudAutoStart.AutoSize = true;
            this.chkGenshinCloudAutoStart.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.chkGenshinCloudAutoStart.Location = new System.Drawing.Point(350, 415);
            this.chkGenshinCloudAutoStart.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chkGenshinCloudAutoStart.Name = "chkGenshinCloudAutoStart";
            this.chkGenshinCloudAutoStart.Size = new System.Drawing.Size(104, 19);
            this.chkGenshinCloudAutoStart.TabIndex = 41;
            this.chkGenshinCloudAutoStart.Text = "切换时重启";
            this.chkGenshinCloudAutoStart.UseVisualStyleBackColor = true;
            // 
            // txtGenshinCloudPath
            // 
            this.txtGenshinCloudPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtGenshinCloudPath.Location = new System.Drawing.Point(19, 52);
            this.txtGenshinCloudPath.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtGenshinCloudPath.Name = "txtGenshinCloudPath";
            this.txtGenshinCloudPath.Size = new System.Drawing.Size(395, 25);
            this.txtGenshinCloudPath.TabIndex = 33;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label5.Location = new System.Drawing.Point(20, 33);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(202, 15);
            this.label5.TabIndex = 32;
            this.label5.Text = "【云·原神】游戏程序路径：";
            // 
            // btnGenshinCloudChoosePath
            // 
            this.btnGenshinCloudChoosePath.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGenshinCloudChoosePath.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnGenshinCloudChoosePath.Location = new System.Drawing.Point(423, 50);
            this.btnGenshinCloudChoosePath.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnGenshinCloudChoosePath.Name = "btnGenshinCloudChoosePath";
            this.btnGenshinCloudChoosePath.Size = new System.Drawing.Size(45, 28);
            this.btnGenshinCloudChoosePath.TabIndex = 34;
            this.btnGenshinCloudChoosePath.Text = "...";
            this.btnGenshinCloudChoosePath.UseVisualStyleBackColor = true;
            // 
            // btnGenshinCloudDelete
            // 
            this.btnGenshinCloudDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGenshinCloudDelete.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnGenshinCloudDelete.Location = new System.Drawing.Point(348, 478);
            this.btnGenshinCloudDelete.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnGenshinCloudDelete.Name = "btnGenshinCloudDelete";
            this.btnGenshinCloudDelete.Size = new System.Drawing.Size(120, 30);
            this.btnGenshinCloudDelete.TabIndex = 28;
            this.btnGenshinCloudDelete.Text = "删除选中账号";
            this.btnGenshinCloudDelete.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label11.Location = new System.Drawing.Point(20, 82);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(112, 15);
            this.label11.TabIndex = 27;
            this.label11.Text = "保存账号列表：";
            // 
            // btnGenshinCloudSwitch
            // 
            this.btnGenshinCloudSwitch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGenshinCloudSwitch.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnGenshinCloudSwitch.Location = new System.Drawing.Point(348, 100);
            this.btnGenshinCloudSwitch.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnGenshinCloudSwitch.Name = "btnGenshinCloudSwitch";
            this.btnGenshinCloudSwitch.Size = new System.Drawing.Size(120, 52);
            this.btnGenshinCloudSwitch.TabIndex = 26;
            this.btnGenshinCloudSwitch.Text = "切换选中账号";
            this.btnGenshinCloudSwitch.UseVisualStyleBackColor = true;
            // 
            // btnGenshinCloudAdd
            // 
            this.btnGenshinCloudAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGenshinCloudAdd.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnGenshinCloudAdd.Location = new System.Drawing.Point(348, 442);
            this.btnGenshinCloudAdd.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnGenshinCloudAdd.Name = "btnGenshinCloudAdd";
            this.btnGenshinCloudAdd.Size = new System.Drawing.Size(120, 30);
            this.btnGenshinCloudAdd.TabIndex = 25;
            this.btnGenshinCloudAdd.Text = "保存当前账号";
            this.btnGenshinCloudAdd.UseVisualStyleBackColor = true;
            // 
            // lvwGenshinCloudAcct
            // 
            this.lvwGenshinCloudAcct.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lvwGenshinCloudAcct.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.lvwGenshinCloudAcct.GridLines = true;
            this.lvwGenshinCloudAcct.HideSelection = false;
            this.lvwGenshinCloudAcct.Location = new System.Drawing.Point(19, 100);
            this.lvwGenshinCloudAcct.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lvwGenshinCloudAcct.MultiSelect = false;
            this.lvwGenshinCloudAcct.Name = "lvwGenshinCloudAcct";
            this.lvwGenshinCloudAcct.Size = new System.Drawing.Size(321, 412);
            this.lvwGenshinCloudAcct.TabIndex = 24;
            this.lvwGenshinCloudAcct.UseCompatibleStateImageBehavior = false;
            this.lvwGenshinCloudAcct.View = System.Windows.Forms.View.List;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "名称";
            this.columnHeader1.Width = 200;
            // 
            // tabPageSatrRail
            // 
            this.tabPageSatrRail.BackColor = System.Drawing.Color.White;
            this.tabPageSatrRail.Controls.Add(this.groupBox3);
            this.tabPageSatrRail.Controls.Add(this.groupBox4);
            this.tabPageSatrRail.Location = new System.Drawing.Point(4, 25);
            this.tabPageSatrRail.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tabPageSatrRail.Name = "tabPageSatrRail";
            this.tabPageSatrRail.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tabPageSatrRail.Size = new System.Drawing.Size(454, 379);
            this.tabPageSatrRail.TabIndex = 2;
            this.tabPageSatrRail.Text = "崩坏：星穹铁道";
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.pictureBox2);
            this.groupBox3.Controls.Add(this.btnStarRailFPSEdit);
            this.groupBox3.Controls.Add(this.numericUpDownFPS);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Location = new System.Drawing.Point(11, 429);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox3.Size = new System.Drawing.Size(475, 105);
            this.groupBox3.TabIndex = 42;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "游戏设置";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::MiHoYoStarter.Properties.Resources.attention;
            this.pictureBox2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pictureBox2.Location = new System.Drawing.Point(259, 38);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(21, 20);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox2.TabIndex = 39;
            this.pictureBox2.TabStop = false;
            this.tipHelp.SetToolTip(this.pictureBox2, "此帧数修改是通过修改注册表实现的，可以放心使用。\r\n可以突破60帧设置，但是具体能跑到多少要看你电脑性能了。\r\nWin+G可以查看游戏当前帧数\r\n注意：打开游戏设" +
        "置并修改后会还原帧数设置，需要重新应用下。");
            // 
            // btnStarRailFPSEdit
            // 
            this.btnStarRailFPSEdit.Location = new System.Drawing.Point(348, 32);
            this.btnStarRailFPSEdit.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnStarRailFPSEdit.Name = "btnStarRailFPSEdit";
            this.btnStarRailFPSEdit.Size = new System.Drawing.Size(100, 28);
            this.btnStarRailFPSEdit.TabIndex = 3;
            this.btnStarRailFPSEdit.Text = "应用";
            this.btnStarRailFPSEdit.UseVisualStyleBackColor = true;
            this.btnStarRailFPSEdit.Click += new System.EventHandler(this.btnStarRailFPSEdit_Click);
            // 
            // numericUpDownFPS
            // 
            this.numericUpDownFPS.Location = new System.Drawing.Point(171, 37);
            this.numericUpDownFPS.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.numericUpDownFPS.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.numericUpDownFPS.Minimum = new decimal(new int[] {
            24,
            0,
            0,
            0});
            this.numericUpDownFPS.Name = "numericUpDownFPS";
            this.numericUpDownFPS.Size = new System.Drawing.Size(80, 25);
            this.numericUpDownFPS.TabIndex = 2;
            this.numericUpDownFPS.Value = new decimal(new int[] {
            120,
            0,
            0,
            0});
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 38);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(136, 15);
            this.label6.TabIndex = 1;
            this.label6.Text = "游戏帧数（FPS）：";
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox4.Controls.Add(this.comboStarRailServer);
            this.groupBox4.Controls.Add(this.btnStarRailStart);
            this.groupBox4.Controls.Add(this.chkStarRailAutoStart);
            this.groupBox4.Controls.Add(this.pictureBox1);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.txtStarRailStartParam);
            this.groupBox4.Controls.Add(this.txtStarRailPath);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.btnStarRailChoosePath);
            this.groupBox4.Controls.Add(this.btnStarRailDelete);
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Controls.Add(this.btnStarRailSwitch);
            this.groupBox4.Controls.Add(this.btnStarRailAdd);
            this.groupBox4.Controls.Add(this.lvwStarRailAcct);
            this.groupBox4.Location = new System.Drawing.Point(11, 8);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox4.Size = new System.Drawing.Size(476, 399);
            this.groupBox4.TabIndex = 41;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "账号切换";
            // 
            // comboStarRailServer
            // 
            this.comboStarRailServer.FormattingEnabled = true;
            this.comboStarRailServer.Items.AddRange(new object[] {
            "國服",
            "國際服"});
            this.comboStarRailServer.Location = new System.Drawing.Point(359, 22);
            this.comboStarRailServer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboStarRailServer.Name = "comboStarRailServer";
            this.comboStarRailServer.Size = new System.Drawing.Size(108, 23);
            this.comboStarRailServer.TabIndex = 43;
            this.comboStarRailServer.Text = "國際服";
            this.comboStarRailServer.SelectedIndexChanged += new System.EventHandler(this.comboStarRailServer_SelectedIndexChanged);
            // 
            // btnStarRailStart
            // 
            this.btnStarRailStart.Location = new System.Drawing.Point(350, 228);
            this.btnStarRailStart.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnStarRailStart.Name = "btnStarRailStart";
            this.btnStarRailStart.Size = new System.Drawing.Size(117, 28);
            this.btnStarRailStart.TabIndex = 42;
            this.btnStarRailStart.Text = "启动游戏";
            this.btnStarRailStart.UseVisualStyleBackColor = true;
            // 
            // chkStarRailAutoStart
            // 
            this.chkStarRailAutoStart.AutoSize = true;
            this.chkStarRailAutoStart.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.chkStarRailAutoStart.Location = new System.Drawing.Point(350, 288);
            this.chkStarRailAutoStart.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chkStarRailAutoStart.Name = "chkStarRailAutoStart";
            this.chkStarRailAutoStart.Size = new System.Drawing.Size(104, 19);
            this.chkStarRailAutoStart.TabIndex = 41;
            this.chkStarRailAutoStart.Text = "切换时重启";
            this.chkStarRailAutoStart.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::MiHoYoStarter.Properties.Resources.attention;
            this.pictureBox1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pictureBox1.Location = new System.Drawing.Point(101, 83);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(21, 20);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 38;
            this.pictureBox1.TabStop = false;
            this.tipHelp.SetToolTip(this.pictureBox1, "如果你不知道什么是启动参数请不要填写。\r\n常见启动参数：\r\n无边框 -popupwindow\r\n指定分辨率 -screen-width 1600 -screen-" +
        "height 900\r\n");
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label7.Location = new System.Drawing.Point(20, 87);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 15);
            this.label7.TabIndex = 37;
            this.label7.Text = "启动参数：";
            // 
            // txtStarRailStartParam
            // 
            this.txtStarRailStartParam.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtStarRailStartParam.Location = new System.Drawing.Point(19, 105);
            this.txtStarRailStartParam.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtStarRailStartParam.Name = "txtStarRailStartParam";
            this.txtStarRailStartParam.Size = new System.Drawing.Size(448, 25);
            this.txtStarRailStartParam.TabIndex = 36;
            // 
            // txtStarRailPath
            // 
            this.txtStarRailPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtStarRailPath.Location = new System.Drawing.Point(19, 52);
            this.txtStarRailPath.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtStarRailPath.Name = "txtStarRailPath";
            this.txtStarRailPath.Size = new System.Drawing.Size(395, 25);
            this.txtStarRailPath.TabIndex = 33;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label8.Location = new System.Drawing.Point(20, 33);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(247, 15);
            this.label8.TabIndex = 32;
            this.label8.Text = "【崩坏：星穹铁道】游戏程序路径：";
            // 
            // btnStarRailChoosePath
            // 
            this.btnStarRailChoosePath.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnStarRailChoosePath.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnStarRailChoosePath.Location = new System.Drawing.Point(423, 50);
            this.btnStarRailChoosePath.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnStarRailChoosePath.Name = "btnStarRailChoosePath";
            this.btnStarRailChoosePath.Size = new System.Drawing.Size(45, 28);
            this.btnStarRailChoosePath.TabIndex = 34;
            this.btnStarRailChoosePath.Text = "...";
            this.btnStarRailChoosePath.UseVisualStyleBackColor = true;
            // 
            // btnStarRailDelete
            // 
            this.btnStarRailDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnStarRailDelete.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnStarRailDelete.Location = new System.Drawing.Point(348, 352);
            this.btnStarRailDelete.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnStarRailDelete.Name = "btnStarRailDelete";
            this.btnStarRailDelete.Size = new System.Drawing.Size(120, 30);
            this.btnStarRailDelete.TabIndex = 28;
            this.btnStarRailDelete.Text = "删除选中账号";
            this.btnStarRailDelete.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label10.Location = new System.Drawing.Point(20, 152);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(112, 15);
            this.label10.TabIndex = 27;
            this.label10.Text = "保存账号列表：";
            // 
            // btnStarRailSwitch
            // 
            this.btnStarRailSwitch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnStarRailSwitch.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnStarRailSwitch.Location = new System.Drawing.Point(349, 168);
            this.btnStarRailSwitch.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnStarRailSwitch.Name = "btnStarRailSwitch";
            this.btnStarRailSwitch.Size = new System.Drawing.Size(120, 52);
            this.btnStarRailSwitch.TabIndex = 26;
            this.btnStarRailSwitch.Text = "切换选中账号";
            this.btnStarRailSwitch.UseVisualStyleBackColor = true;
            // 
            // btnStarRailAdd
            // 
            this.btnStarRailAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnStarRailAdd.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnStarRailAdd.Location = new System.Drawing.Point(348, 313);
            this.btnStarRailAdd.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnStarRailAdd.Name = "btnStarRailAdd";
            this.btnStarRailAdd.Size = new System.Drawing.Size(120, 30);
            this.btnStarRailAdd.TabIndex = 25;
            this.btnStarRailAdd.Text = "保存当前账号";
            this.btnStarRailAdd.UseVisualStyleBackColor = true;
            // 
            // lvwStarRailAcct
            // 
            this.lvwStarRailAcct.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lvwStarRailAcct.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader2});
            this.lvwStarRailAcct.GridLines = true;
            this.lvwStarRailAcct.HideSelection = false;
            this.lvwStarRailAcct.Location = new System.Drawing.Point(19, 168);
            this.lvwStarRailAcct.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lvwStarRailAcct.MultiSelect = false;
            this.lvwStarRailAcct.Name = "lvwStarRailAcct";
            this.lvwStarRailAcct.Size = new System.Drawing.Size(321, 213);
            this.lvwStarRailAcct.TabIndex = 24;
            this.lvwStarRailAcct.UseCompatibleStateImageBehavior = false;
            this.lvwStarRailAcct.View = System.Windows.Forms.View.List;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "名称";
            this.columnHeader2.Width = 200;
            // 
            // tabPageHonkaiImpact3
            // 
            this.tabPageHonkaiImpact3.BackColor = System.Drawing.Color.White;
            this.tabPageHonkaiImpact3.Controls.Add(this.groupBox2);
            this.tabPageHonkaiImpact3.Location = new System.Drawing.Point(4, 25);
            this.tabPageHonkaiImpact3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPageHonkaiImpact3.Name = "tabPageHonkaiImpact3";
            this.tabPageHonkaiImpact3.Size = new System.Drawing.Size(454, 379);
            this.tabPageHonkaiImpact3.TabIndex = 3;
            this.tabPageHonkaiImpact3.Text = "崩坏3";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.chkHonkaiImpact3AutoStart);
            this.groupBox2.Controls.Add(this.pictureBox3);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txtHonkaiImpact3StartParam);
            this.groupBox2.Controls.Add(this.txtHonkaiImpact3Path);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.btnHonkaiImpact3ChoosePath);
            this.groupBox2.Controls.Add(this.btnHonkaiImpact3Delete);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.btnHonkaiImpact3Switch);
            this.groupBox2.Controls.Add(this.btnHonkaiImpact3Add);
            this.groupBox2.Controls.Add(this.lvwHonkaiImpact3Acct);
            this.groupBox2.Location = new System.Drawing.Point(11, 8);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox2.Size = new System.Drawing.Size(476, 529);
            this.groupBox2.TabIndex = 40;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "账号切换";
            // 
            // chkHonkaiImpact3AutoStart
            // 
            this.chkHonkaiImpact3AutoStart.AutoSize = true;
            this.chkHonkaiImpact3AutoStart.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.chkHonkaiImpact3AutoStart.Location = new System.Drawing.Point(350, 415);
            this.chkHonkaiImpact3AutoStart.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chkHonkaiImpact3AutoStart.Name = "chkHonkaiImpact3AutoStart";
            this.chkHonkaiImpact3AutoStart.Size = new System.Drawing.Size(104, 19);
            this.chkHonkaiImpact3AutoStart.TabIndex = 41;
            this.chkHonkaiImpact3AutoStart.Text = "切换时重启";
            this.chkHonkaiImpact3AutoStart.UseVisualStyleBackColor = true;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::MiHoYoStarter.Properties.Resources.attention;
            this.pictureBox3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pictureBox3.Location = new System.Drawing.Point(101, 83);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(21, 20);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox3.TabIndex = 38;
            this.pictureBox3.TabStop = false;
            this.tipHelp.SetToolTip(this.pictureBox3, "如果你不知道什么是启动参数请不要填写。\r\n常见启动参数：\r\n无边框 -popupwindow\r\n指定分辨率 -screen-width 1600 -screen-" +
        "height 900\r\n");
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label3.Location = new System.Drawing.Point(20, 87);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 15);
            this.label3.TabIndex = 37;
            this.label3.Text = "启动参数：";
            // 
            // txtHonkaiImpact3StartParam
            // 
            this.txtHonkaiImpact3StartParam.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtHonkaiImpact3StartParam.Location = new System.Drawing.Point(19, 105);
            this.txtHonkaiImpact3StartParam.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtHonkaiImpact3StartParam.Name = "txtHonkaiImpact3StartParam";
            this.txtHonkaiImpact3StartParam.Size = new System.Drawing.Size(448, 25);
            this.txtHonkaiImpact3StartParam.TabIndex = 36;
            // 
            // txtHonkaiImpact3Path
            // 
            this.txtHonkaiImpact3Path.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtHonkaiImpact3Path.Location = new System.Drawing.Point(19, 52);
            this.txtHonkaiImpact3Path.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtHonkaiImpact3Path.Name = "txtHonkaiImpact3Path";
            this.txtHonkaiImpact3Path.Size = new System.Drawing.Size(395, 25);
            this.txtHonkaiImpact3Path.TabIndex = 33;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label4.Location = new System.Drawing.Point(20, 33);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(180, 15);
            this.label4.TabIndex = 32;
            this.label4.Text = "【崩坏3】游戏程序路径：";
            // 
            // btnHonkaiImpact3ChoosePath
            // 
            this.btnHonkaiImpact3ChoosePath.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnHonkaiImpact3ChoosePath.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnHonkaiImpact3ChoosePath.Location = new System.Drawing.Point(423, 50);
            this.btnHonkaiImpact3ChoosePath.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnHonkaiImpact3ChoosePath.Name = "btnHonkaiImpact3ChoosePath";
            this.btnHonkaiImpact3ChoosePath.Size = new System.Drawing.Size(45, 28);
            this.btnHonkaiImpact3ChoosePath.TabIndex = 34;
            this.btnHonkaiImpact3ChoosePath.Text = "...";
            this.btnHonkaiImpact3ChoosePath.UseVisualStyleBackColor = true;
            // 
            // btnHonkaiImpact3Delete
            // 
            this.btnHonkaiImpact3Delete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnHonkaiImpact3Delete.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnHonkaiImpact3Delete.Location = new System.Drawing.Point(348, 478);
            this.btnHonkaiImpact3Delete.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnHonkaiImpact3Delete.Name = "btnHonkaiImpact3Delete";
            this.btnHonkaiImpact3Delete.Size = new System.Drawing.Size(120, 30);
            this.btnHonkaiImpact3Delete.TabIndex = 28;
            this.btnHonkaiImpact3Delete.Text = "删除选中账号";
            this.btnHonkaiImpact3Delete.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label9.Location = new System.Drawing.Point(20, 152);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(112, 15);
            this.label9.TabIndex = 27;
            this.label9.Text = "保存账号列表：";
            // 
            // btnHonkaiImpact3Switch
            // 
            this.btnHonkaiImpact3Switch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnHonkaiImpact3Switch.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnHonkaiImpact3Switch.Location = new System.Drawing.Point(349, 168);
            this.btnHonkaiImpact3Switch.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnHonkaiImpact3Switch.Name = "btnHonkaiImpact3Switch";
            this.btnHonkaiImpact3Switch.Size = new System.Drawing.Size(120, 52);
            this.btnHonkaiImpact3Switch.TabIndex = 26;
            this.btnHonkaiImpact3Switch.Text = "切换选中账号";
            this.btnHonkaiImpact3Switch.UseVisualStyleBackColor = true;
            // 
            // btnHonkaiImpact3Add
            // 
            this.btnHonkaiImpact3Add.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnHonkaiImpact3Add.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnHonkaiImpact3Add.Location = new System.Drawing.Point(348, 442);
            this.btnHonkaiImpact3Add.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnHonkaiImpact3Add.Name = "btnHonkaiImpact3Add";
            this.btnHonkaiImpact3Add.Size = new System.Drawing.Size(120, 30);
            this.btnHonkaiImpact3Add.TabIndex = 25;
            this.btnHonkaiImpact3Add.Text = "保存当前账号";
            this.btnHonkaiImpact3Add.UseVisualStyleBackColor = true;
            // 
            // lvwHonkaiImpact3Acct
            // 
            this.lvwHonkaiImpact3Acct.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lvwHonkaiImpact3Acct.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader3});
            this.lvwHonkaiImpact3Acct.GridLines = true;
            this.lvwHonkaiImpact3Acct.HideSelection = false;
            this.lvwHonkaiImpact3Acct.Location = new System.Drawing.Point(19, 168);
            this.lvwHonkaiImpact3Acct.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lvwHonkaiImpact3Acct.MultiSelect = false;
            this.lvwHonkaiImpact3Acct.Name = "lvwHonkaiImpact3Acct";
            this.lvwHonkaiImpact3Acct.Size = new System.Drawing.Size(321, 343);
            this.lvwHonkaiImpact3Acct.TabIndex = 24;
            this.lvwHonkaiImpact3Acct.UseCompatibleStateImageBehavior = false;
            this.lvwHonkaiImpact3Acct.View = System.Windows.Forms.View.List;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "名称";
            this.columnHeader3.Width = 200;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.设置ToolStripMenuItem,
            this.帮助ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(462, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 设置ToolStripMenuItem
            // 
            this.设置ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.DisplayGenshinTabToolStripMenuItem,
            this.DisplayGenshinCloudTabToolStripMenuItem,
            this.DisplayStarRailTabToolStripMenuItem,
            this.DisplayHonkaiImpact3TabToolStripMenuItem});
            this.设置ToolStripMenuItem.Name = "设置ToolStripMenuItem";
            this.设置ToolStripMenuItem.Size = new System.Drawing.Size(83, 24);
            this.设置ToolStripMenuItem.Text = "界面显示";
            // 
            // DisplayGenshinTabToolStripMenuItem
            // 
            this.DisplayGenshinTabToolStripMenuItem.Checked = true;
            this.DisplayGenshinTabToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.DisplayGenshinTabToolStripMenuItem.Name = "DisplayGenshinTabToolStripMenuItem";
            this.DisplayGenshinTabToolStripMenuItem.Size = new System.Drawing.Size(197, 26);
            this.DisplayGenshinTabToolStripMenuItem.Text = "原神";
            this.DisplayGenshinTabToolStripMenuItem.Click += new System.EventHandler(this.DisplayGenshinTabToolStripMenuItem_Click);
            // 
            // DisplayGenshinCloudTabToolStripMenuItem
            // 
            this.DisplayGenshinCloudTabToolStripMenuItem.Checked = true;
            this.DisplayGenshinCloudTabToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.DisplayGenshinCloudTabToolStripMenuItem.Name = "DisplayGenshinCloudTabToolStripMenuItem";
            this.DisplayGenshinCloudTabToolStripMenuItem.Size = new System.Drawing.Size(197, 26);
            this.DisplayGenshinCloudTabToolStripMenuItem.Text = "云·原神";
            this.DisplayGenshinCloudTabToolStripMenuItem.Click += new System.EventHandler(this.DisplayGenshinCloudTabToolStripMenuItem_Click);
            // 
            // DisplayStarRailTabToolStripMenuItem
            // 
            this.DisplayStarRailTabToolStripMenuItem.Checked = true;
            this.DisplayStarRailTabToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.DisplayStarRailTabToolStripMenuItem.Name = "DisplayStarRailTabToolStripMenuItem";
            this.DisplayStarRailTabToolStripMenuItem.Size = new System.Drawing.Size(197, 26);
            this.DisplayStarRailTabToolStripMenuItem.Text = "崩坏：星穹铁道";
            this.DisplayStarRailTabToolStripMenuItem.Click += new System.EventHandler(this.DisplayStarRailTabToolStripMenuItem_Click);
            // 
            // DisplayHonkaiImpact3TabToolStripMenuItem
            // 
            this.DisplayHonkaiImpact3TabToolStripMenuItem.Checked = true;
            this.DisplayHonkaiImpact3TabToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.DisplayHonkaiImpact3TabToolStripMenuItem.Name = "DisplayHonkaiImpact3TabToolStripMenuItem";
            this.DisplayHonkaiImpact3TabToolStripMenuItem.Size = new System.Drawing.Size(197, 26);
            this.DisplayHonkaiImpact3TabToolStripMenuItem.Text = "崩坏3";
            this.DisplayHonkaiImpact3TabToolStripMenuItem.Click += new System.EventHandler(this.DisplayHonkaiImpact3TabToolStripMenuItem_Click);
            // 
            // 帮助ToolStripMenuItem
            // 
            this.帮助ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.主页ToolStripMenuItem,
            this.请作者喝咖啡ToolStripMenuItem});
            this.帮助ToolStripMenuItem.Name = "帮助ToolStripMenuItem";
            this.帮助ToolStripMenuItem.Size = new System.Drawing.Size(53, 24);
            this.帮助ToolStripMenuItem.Text = "帮助";
            // 
            // 主页ToolStripMenuItem
            // 
            this.主页ToolStripMenuItem.Name = "主页ToolStripMenuItem";
            this.主页ToolStripMenuItem.Size = new System.Drawing.Size(182, 26);
            this.主页ToolStripMenuItem.Text = "主页";
            this.主页ToolStripMenuItem.Click += new System.EventHandler(this.主页ToolStripMenuItem_Click);
            // 
            // 请作者喝咖啡ToolStripMenuItem
            // 
            this.请作者喝咖啡ToolStripMenuItem.Name = "请作者喝咖啡ToolStripMenuItem";
            this.请作者喝咖啡ToolStripMenuItem.Size = new System.Drawing.Size(182, 26);
            this.请作者喝咖啡ToolStripMenuItem.Text = "请作者喝咖啡";
            this.请作者喝咖啡ToolStripMenuItem.Click += new System.EventHandler(this.请作者喝咖啡ToolStripMenuItem_Click);
            // 
            // notifyIcon
            // 
            this.notifyIcon.ContextMenuStrip = this.contextMenuStrip1;
            this.notifyIcon.Icon = global::MiHoYoStarter.Properties.Resources.hutao;
            this.notifyIcon.Text = "米哈游账户切换启动工具";
            this.notifyIcon.Visible = true;
            this.notifyIcon.Click += new System.EventHandler(this.notifyIcon_Click);
            this.notifyIcon.DoubleClick += new System.EventHandler(this.notifyIcon_DoubleClick);
            this.notifyIcon.MouseDown += new System.Windows.Forms.MouseEventHandler(this.notifyIcon_MouseDown);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.显示主界面ToolStripMenuItem,
            this.退出ToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(154, 52);
            // 
            // 显示主界面ToolStripMenuItem
            // 
            this.显示主界面ToolStripMenuItem.Name = "显示主界面ToolStripMenuItem";
            this.显示主界面ToolStripMenuItem.Size = new System.Drawing.Size(153, 24);
            this.显示主界面ToolStripMenuItem.Text = "显示主界面";
            this.显示主界面ToolStripMenuItem.Click += new System.EventHandler(this.显示主界面ToolStripMenuItem_Click);
            // 
            // 退出ToolStripMenuItem
            // 
            this.退出ToolStripMenuItem.Name = "退出ToolStripMenuItem";
            this.退出ToolStripMenuItem.Size = new System.Drawing.Size(153, 24);
            this.退出ToolStripMenuItem.Text = "退出";
            this.退出ToolStripMenuItem.Click += new System.EventHandler(this.退出ToolStripMenuItem_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 414);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(2, 0, 19, 0);
            this.statusStrip1.Size = new System.Drawing.Size(462, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(0, 16);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(462, 436);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.tab1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = global::MiHoYoStarter.Properties.Resources.hutao;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MHY启动器";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormMain_FormClosed);
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.SizeChanged += new System.EventHandler(this.FormMain_SizeChanged);
            this.tab1.ResumeLayout(false);
            this.tabPageGenshin.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picHelpSatrtParam)).EndInit();
            this.tabPageGenshinCloud.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.tabPageSatrRail.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownFPS)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabPageHonkaiImpact3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tab1;
        private System.Windows.Forms.TabPage tabPageGenshin;
        private System.Windows.Forms.PictureBox picHelpSatrtParam;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtGenshinStartParam;
        private System.Windows.Forms.TextBox txtGenshinPath;
        private System.Windows.Forms.Label lblPathTag;
        private System.Windows.Forms.Button btnGenshinChoosePath;
        private System.Windows.Forms.Button btnGenshinDelete;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnGenshinSwitch;
        private System.Windows.Forms.Button btnGenshinAdd;
        private System.Windows.Forms.ListView lvwGenshinAcct;
        private System.Windows.Forms.ColumnHeader name;
        private System.Windows.Forms.TabPage tabPageGenshinCloud;
        private System.Windows.Forms.TabPage tabPageSatrRail;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 设置ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem DisplayGenshinTabToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem DisplayGenshinCloudTabToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem DisplayStarRailTabToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 帮助ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 主页ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 请作者喝咖啡ToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtStarRailStartParam;
        private System.Windows.Forms.TextBox txtStarRailPath;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnStarRailChoosePath;
        private System.Windows.Forms.Button btnStarRailDelete;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnStarRailSwitch;
        private System.Windows.Forms.Button btnStarRailAdd;
        private System.Windows.Forms.ListView lvwStarRailAcct;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.NotifyIcon notifyIcon;
        private System.Windows.Forms.ToolTip tipHelp;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.TextBox txtGenshinCloudPath;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnGenshinCloudChoosePath;
        private System.Windows.Forms.Button btnGenshinCloudDelete;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnGenshinCloudSwitch;
        private System.Windows.Forms.Button btnGenshinCloudAdd;
        private System.Windows.Forms.ListView lvwGenshinCloudAcct;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.Button btnStarRailFPSEdit;
        private System.Windows.Forms.NumericUpDown numericUpDownFPS;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 显示主界面ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 退出ToolStripMenuItem;
        private System.Windows.Forms.TabPage tabPageHonkaiImpact3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtHonkaiImpact3StartParam;
        private System.Windows.Forms.TextBox txtHonkaiImpact3Path;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnHonkaiImpact3ChoosePath;
        private System.Windows.Forms.Button btnHonkaiImpact3Delete;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnHonkaiImpact3Switch;
        private System.Windows.Forms.Button btnHonkaiImpact3Add;
        private System.Windows.Forms.ListView lvwHonkaiImpact3Acct;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ToolStripMenuItem DisplayHonkaiImpact3TabToolStripMenuItem;
        private System.Windows.Forms.CheckBox chkGenshinAutoStart;
        private System.Windows.Forms.CheckBox chkGenshinCloudAutoStart;
        private System.Windows.Forms.CheckBox chkStarRailAutoStart;
        private System.Windows.Forms.CheckBox chkHonkaiImpact3AutoStart;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.Button btnStarRailStart;
        private System.Windows.Forms.ComboBox comboStarRailServer;
    }
}

