﻿namespace RobotWorkstation
{
    partial class ManualDebugForm
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.TimerInitRobotGlobalPointDGV = new System.Windows.Forms.Timer(this.components);
            this.RefreshTimer = new System.Windows.Forms.Timer(this.components);
            this.OpenFileDialogMotionControlLoadCfg = new System.Windows.Forms.OpenFileDialog();
            this.tabControlManualDebug = new RobotWorkstation.CustomTabControl();
            this.tabPageRobot = new System.Windows.Forms.TabPage();
            this.customGroupBoxRobotGrap = new RobotWorkstation.CustomGroupBox();
            this.CBtnRobotPut = new RobotWorkstation.CustomButton();
            this.CBtnRobotGrap = new RobotWorkstation.CustomButton();
            this.CBtnRobotGrapBack = new RobotWorkstation.CustomButton();
            this.CBtnRobotGrapGo = new RobotWorkstation.CustomButton();
            this.PicBoxRobotGrapVacuumCheck = new System.Windows.Forms.PictureBox();
            this.customLabel53 = new RobotWorkstation.CustomLabel();
            this.PicBoxRobotGrapBackArrive = new System.Windows.Forms.PictureBox();
            this.CLabelRobotGrapBackArrive = new RobotWorkstation.CustomLabel();
            this.PicBoxRobotGrapGoArrive = new System.Windows.Forms.PictureBox();
            this.CLabelRobotGrapGoArrive = new RobotWorkstation.CustomLabel();
            this.groupBoxRobot = new RobotWorkstation.CustomGroupBox();
            this.CBtnRobotTestTurnOver = new RobotWorkstation.CustomButton();
            this.CBtnRobotTestRunAction = new RobotWorkstation.CustomButton();
            this.ComBoxRobotActions = new System.Windows.Forms.ComboBox();
            this.CBtnRobotTestTeachPoint = new RobotWorkstation.CustomButton();
            this.CBtnRobotTestMoveToPoint = new RobotWorkstation.CustomButton();
            this.customLabel19 = new RobotWorkstation.CustomLabel();
            this.CBtnRobotTestReadPoint = new RobotWorkstation.CustomButton();
            this.CTabControlBorderRobotTestPoints = new RobotWorkstation.CustomTabControlBorder();
            this.PageRobotTestGlobalPoint = new System.Windows.Forms.TabPage();
            this.DGV_RobotGlobalPoint = new System.Windows.Forms.DataGridView();
            this.RobotTestName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RobotTestX = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RobotTestY = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RobotTestZ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RobotTestRZ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RobotTestHand = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RobotTestUserID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RobotTestToolID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PageRobotTestUserFrame = new System.Windows.Forms.TabPage();
            this.PageRobotTestToolFrame = new System.Windows.Forms.TabPage();
            this.PageRobotTestWorkSpace = new System.Windows.Forms.TabPage();
            this.CButtonRobotDistanceRZSub = new RobotWorkstation.CustomButton();
            this.CButtonRobotDistanceRZAdd = new RobotWorkstation.CustomButton();
            this.CTextBoxRobotDistanceRZ = new RobotWorkstation.CustomTextBox();
            this.customLabel15 = new RobotWorkstation.CustomLabel();
            this.CButtonRobotDistanceZSub = new RobotWorkstation.CustomButton();
            this.CButtonRobotDistanceZAdd = new RobotWorkstation.CustomButton();
            this.CTextBoxRobotDistanceZ = new RobotWorkstation.CustomTextBox();
            this.customLabel16 = new RobotWorkstation.CustomLabel();
            this.CButtonRobotDistanceYSub = new RobotWorkstation.CustomButton();
            this.CButtonRobotDistanceYAdd = new RobotWorkstation.CustomButton();
            this.CTextBoxRobotDistanceY = new RobotWorkstation.CustomTextBox();
            this.customLabel17 = new RobotWorkstation.CustomLabel();
            this.CButtonRobotDistanceXSub = new RobotWorkstation.CustomButton();
            this.CButtonRobotDistanceXAdd = new RobotWorkstation.CustomButton();
            this.CTextBoxRobotDistanceX = new RobotWorkstation.CustomTextBox();
            this.customLabel18 = new RobotWorkstation.CustomLabel();
            this.CButtonRobotDistanceJ4Sub = new RobotWorkstation.CustomButton();
            this.CButtonRobotDistanceJ4Add = new RobotWorkstation.CustomButton();
            this.CTextBoxRobotDistanceJ4 = new RobotWorkstation.CustomTextBox();
            this.customLabel14 = new RobotWorkstation.CustomLabel();
            this.CButtonRobotDistanceJ3Sub = new RobotWorkstation.CustomButton();
            this.CButtonRobotDistanceJ3Add = new RobotWorkstation.CustomButton();
            this.CTextBoxRobotDistanceJ3 = new RobotWorkstation.CustomTextBox();
            this.customLabel13 = new RobotWorkstation.CustomLabel();
            this.CButtonRobotDistanceJ2Sub = new RobotWorkstation.CustomButton();
            this.CButtonRobotDistanceJ2Add = new RobotWorkstation.CustomButton();
            this.CTextBoxRobotDistanceJ2 = new RobotWorkstation.CustomTextBox();
            this.customLabel12 = new RobotWorkstation.CustomLabel();
            this.CButtonRobotDistanceJ1Sub = new RobotWorkstation.CustomButton();
            this.CButtonRobotDistanceJ1Add = new RobotWorkstation.CustomButton();
            this.CTextBoxRobotDistanceJ1 = new RobotWorkstation.CustomTextBox();
            this.customLabel11 = new RobotWorkstation.CustomLabel();
            this.radioButtonRobotDeviceContinuous = new System.Windows.Forms.RadioButton();
            this.radioButtonRobotDeviceJog = new System.Windows.Forms.RadioButton();
            this.customLabel9 = new RobotWorkstation.CustomLabel();
            this.CTextBoxRobotMoveSpeed = new RobotWorkstation.CustomTextBox();
            this.customLabel8 = new RobotWorkstation.CustomLabel();
            this.customLabel7 = new RobotWorkstation.CustomLabel();
            this.CTextBoxJogDistanceUm = new RobotWorkstation.CustomTextBox();
            this.customLabel6 = new RobotWorkstation.CustomLabel();
            this.CTextBoxJogDistance = new RobotWorkstation.CustomTextBox();
            this.customLabel5 = new RobotWorkstation.CustomLabel();
            this.pictureBoxRobotMove = new System.Windows.Forms.PictureBox();
            this.customLabel4 = new RobotWorkstation.CustomLabel();
            this.pictureBoxTemperature = new System.Windows.Forms.PictureBox();
            this.customLabel3 = new RobotWorkstation.CustomLabel();
            this.CButtonRobotExecStop = new RobotWorkstation.CustomButton();
            this.CButtonRobotExecPause = new RobotWorkstation.CustomButton();
            this.CButtonRobotExecRun = new RobotWorkstation.CustomButton();
            this.pictureBoxRobotExecut = new System.Windows.Forms.PictureBox();
            this.customLabel2 = new RobotWorkstation.CustomLabel();
            this.CButtonReset = new RobotWorkstation.CustomButton();
            this.pictureBoxRobotAlarm = new System.Windows.Forms.PictureBox();
            this.customLabel1 = new RobotWorkstation.CustomLabel();
            this.CButtonServoOff = new RobotWorkstation.CustomButton();
            this.CBttonServoOn = new RobotWorkstation.CustomButton();
            this.pictureBoxServo = new System.Windows.Forms.PictureBox();
            this.tabPageOthers = new System.Windows.Forms.TabPage();
            this.customGroupBox13 = new RobotWorkstation.CustomGroupBox();
            this.PicKeyReset = new System.Windows.Forms.PictureBox();
            this.PicKeyStop = new System.Windows.Forms.PictureBox();
            this.PicKeyPause = new System.Windows.Forms.PictureBox();
            this.PicKeyRun = new System.Windows.Forms.PictureBox();
            this.customLabel52 = new RobotWorkstation.CustomLabel();
            this.customLabel51 = new RobotWorkstation.CustomLabel();
            this.customLabel50 = new RobotWorkstation.CustomLabel();
            this.customLabel49 = new RobotWorkstation.CustomLabel();
            this.customGroupBox12 = new RobotWorkstation.CustomGroupBox();
            this.PicBoxEmptySalverDownArrive = new System.Windows.Forms.PictureBox();
            this.PicBoxEmptySalverUpArrive = new System.Windows.Forms.PictureBox();
            this.CButtonIoEmptyPlateUp = new RobotWorkstation.CustomButton();
            this.CButtonIoEmptyPlateDown = new RobotWorkstation.CustomButton();
            this.customGroupBox11 = new RobotWorkstation.CustomGroupBox();
            this.BtnBeepOff = new RobotWorkstation.CustomButton();
            this.BtnBeepOn = new RobotWorkstation.CustomButton();
            this.BtnLampBlueOff = new RobotWorkstation.CustomButton();
            this.BtnLampBlueOn = new RobotWorkstation.CustomButton();
            this.BtnLampGreenOff = new RobotWorkstation.CustomButton();
            this.BtnLampGreenOn = new RobotWorkstation.CustomButton();
            this.BtnLampOrangeOff = new RobotWorkstation.CustomButton();
            this.BtnLampOrangeOn = new RobotWorkstation.CustomButton();
            this.BtnLampRedOff = new RobotWorkstation.CustomButton();
            this.BtnLampRedOn = new RobotWorkstation.CustomButton();
            this.customGroupBox10 = new RobotWorkstation.CustomGroupBox();
            this.CTextBoxTrayDeviceRfidSn = new RobotWorkstation.CustomTextBox();
            this.customLabel48 = new RobotWorkstation.CustomLabel();
            this.PicTrayDeviceInRFID = new System.Windows.Forms.PictureBox();
            this.customLabel42 = new RobotWorkstation.CustomLabel();
            this.customGroupBox7 = new RobotWorkstation.CustomGroupBox();
            this.ComBoxQRCodeClear = new RobotWorkstation.CustomButton();
            this.customLabel47 = new RobotWorkstation.CustomLabel();
            this.ComBoxQRCodeReadShow = new RobotWorkstation.CustomTextBox();
            this.ComBoxQRCodeDisconnect = new RobotWorkstation.CustomButton();
            this.ComBoxQRCodeConnect = new RobotWorkstation.CustomButton();
            this.ComBoxQRCodeCom = new System.Windows.Forms.ComboBox();
            this.TimerRobotTestRunAction = new System.Windows.Forms.Timer(this.components);
            this.tabControlManualDebug.SuspendLayout();
            this.tabPageRobot.SuspendLayout();
            this.customGroupBoxRobotGrap.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicBoxRobotGrapVacuumCheck)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicBoxRobotGrapBackArrive)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicBoxRobotGrapGoArrive)).BeginInit();
            this.groupBoxRobot.SuspendLayout();
            this.CTabControlBorderRobotTestPoints.SuspendLayout();
            this.PageRobotTestGlobalPoint.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_RobotGlobalPoint)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRobotMove)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTemperature)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRobotExecut)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRobotAlarm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxServo)).BeginInit();
            this.tabPageOthers.SuspendLayout();
            this.customGroupBox13.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicKeyReset)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicKeyStop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicKeyPause)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicKeyRun)).BeginInit();
            this.customGroupBox12.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicBoxEmptySalverDownArrive)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicBoxEmptySalverUpArrive)).BeginInit();
            this.customGroupBox11.SuspendLayout();
            this.customGroupBox10.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicTrayDeviceInRFID)).BeginInit();
            this.customGroupBox7.SuspendLayout();
            this.SuspendLayout();
            // 
            // TimerInitRobotGlobalPointDGV
            // 
            this.TimerInitRobotGlobalPointDGV.Interval = 10;
            this.TimerInitRobotGlobalPointDGV.Tick += new System.EventHandler(this.timer_InitRobotGlobalPointDGV_Tick);
            // 
            // RefreshTimer
            // 
            this.RefreshTimer.Interval = 200;
            this.RefreshTimer.Tick += new System.EventHandler(this.RefreshTimer_Tick);
            // 
            // OpenFileDialogMotionControlLoadCfg
            // 
            this.OpenFileDialogMotionControlLoadCfg.FileName = "导入配置";
            // 
            // tabControlManualDebug
            // 
            this.tabControlManualDebug.Controls.Add(this.tabPageRobot);
            this.tabControlManualDebug.Controls.Add(this.tabPageOthers);
            this.tabControlManualDebug.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tabControlManualDebug.ItemSize = new System.Drawing.Size(120, 26);
            this.tabControlManualDebug.Location = new System.Drawing.Point(12, 12);
            this.tabControlManualDebug.Margin = new System.Windows.Forms.Padding(0);
            this.tabControlManualDebug.Name = "tabControlManualDebug";
            this.tabControlManualDebug.Padding = new System.Drawing.Point(20, 3);
            this.tabControlManualDebug.SelectedIndex = 0;
            this.tabControlManualDebug.Size = new System.Drawing.Size(1248, 818);
            this.tabControlManualDebug.TabIndex = 0;
            this.tabControlManualDebug.Selected += new System.Windows.Forms.TabControlEventHandler(this.tabControlManualDebug_Selected);
            // 
            // tabPageRobot
            // 
            this.tabPageRobot.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.tabPageRobot.Controls.Add(this.customGroupBoxRobotGrap);
            this.tabPageRobot.Controls.Add(this.groupBoxRobot);
            this.tabPageRobot.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tabPageRobot.Location = new System.Drawing.Point(0, 29);
            this.tabPageRobot.Name = "tabPageRobot";
            this.tabPageRobot.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageRobot.Size = new System.Drawing.Size(1248, 789);
            this.tabPageRobot.TabIndex = 0;
            this.tabPageRobot.Text = "机器人";
            // 
            // customGroupBoxRobotGrap
            // 
            this.customGroupBoxRobotGrap.Controls.Add(this.CBtnRobotPut);
            this.customGroupBoxRobotGrap.Controls.Add(this.CBtnRobotGrap);
            this.customGroupBoxRobotGrap.Controls.Add(this.CBtnRobotGrapBack);
            this.customGroupBoxRobotGrap.Controls.Add(this.CBtnRobotGrapGo);
            this.customGroupBoxRobotGrap.Controls.Add(this.PicBoxRobotGrapVacuumCheck);
            this.customGroupBoxRobotGrap.Controls.Add(this.customLabel53);
            this.customGroupBoxRobotGrap.Controls.Add(this.PicBoxRobotGrapBackArrive);
            this.customGroupBoxRobotGrap.Controls.Add(this.CLabelRobotGrapBackArrive);
            this.customGroupBoxRobotGrap.Controls.Add(this.PicBoxRobotGrapGoArrive);
            this.customGroupBoxRobotGrap.Controls.Add(this.CLabelRobotGrapGoArrive);
            this.customGroupBoxRobotGrap.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.customGroupBoxRobotGrap.Location = new System.Drawing.Point(6, 669);
            this.customGroupBoxRobotGrap.Name = "customGroupBoxRobotGrap";
            this.customGroupBoxRobotGrap.Size = new System.Drawing.Size(408, 114);
            this.customGroupBoxRobotGrap.TabIndex = 1;
            this.customGroupBoxRobotGrap.TabStop = false;
            this.customGroupBoxRobotGrap.Text = "抓手";
            // 
            // CBtnRobotPut
            // 
            this.CBtnRobotPut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(74)))), ((int)(((byte)(74)))));
            this.CBtnRobotPut.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CBtnRobotPut.Font = new System.Drawing.Font("微软雅黑", 12.5F);
            this.CBtnRobotPut.ForeColor = System.Drawing.Color.Transparent;
            this.CBtnRobotPut.Location = new System.Drawing.Point(305, 60);
            this.CBtnRobotPut.Name = "CBtnRobotPut";
            this.CBtnRobotPut.Size = new System.Drawing.Size(90, 36);
            this.CBtnRobotPut.TabIndex = 24;
            this.CBtnRobotPut.Text = "放下";
            this.CBtnRobotPut.UseVisualStyleBackColor = false;
            this.CBtnRobotPut.Click += new System.EventHandler(this.CBtnRobotPut_Click);
            // 
            // CBtnRobotGrap
            // 
            this.CBtnRobotGrap.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(74)))), ((int)(((byte)(74)))));
            this.CBtnRobotGrap.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CBtnRobotGrap.Font = new System.Drawing.Font("微软雅黑", 12.5F);
            this.CBtnRobotGrap.ForeColor = System.Drawing.Color.Transparent;
            this.CBtnRobotGrap.Location = new System.Drawing.Point(206, 60);
            this.CBtnRobotGrap.Name = "CBtnRobotGrap";
            this.CBtnRobotGrap.Size = new System.Drawing.Size(90, 36);
            this.CBtnRobotGrap.TabIndex = 23;
            this.CBtnRobotGrap.Text = "抓取";
            this.CBtnRobotGrap.UseVisualStyleBackColor = false;
            this.CBtnRobotGrap.Click += new System.EventHandler(this.CBtnRobotGrap_Click);
            // 
            // CBtnRobotGrapBack
            // 
            this.CBtnRobotGrapBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(74)))), ((int)(((byte)(74)))));
            this.CBtnRobotGrapBack.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CBtnRobotGrapBack.Font = new System.Drawing.Font("微软雅黑", 12.5F);
            this.CBtnRobotGrapBack.ForeColor = System.Drawing.Color.Transparent;
            this.CBtnRobotGrapBack.Location = new System.Drawing.Point(107, 60);
            this.CBtnRobotGrapBack.Name = "CBtnRobotGrapBack";
            this.CBtnRobotGrapBack.Size = new System.Drawing.Size(90, 36);
            this.CBtnRobotGrapBack.TabIndex = 22;
            this.CBtnRobotGrapBack.Text = "后退";
            this.CBtnRobotGrapBack.UseVisualStyleBackColor = false;
            this.CBtnRobotGrapBack.Click += new System.EventHandler(this.CBtnRobotGrapBack_Click);
            // 
            // CBtnRobotGrapGo
            // 
            this.CBtnRobotGrapGo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(74)))), ((int)(((byte)(74)))));
            this.CBtnRobotGrapGo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CBtnRobotGrapGo.Font = new System.Drawing.Font("微软雅黑", 12.5F);
            this.CBtnRobotGrapGo.ForeColor = System.Drawing.Color.Transparent;
            this.CBtnRobotGrapGo.Location = new System.Drawing.Point(8, 60);
            this.CBtnRobotGrapGo.Name = "CBtnRobotGrapGo";
            this.CBtnRobotGrapGo.Size = new System.Drawing.Size(90, 36);
            this.CBtnRobotGrapGo.TabIndex = 21;
            this.CBtnRobotGrapGo.Text = "前进";
            this.CBtnRobotGrapGo.UseVisualStyleBackColor = false;
            this.CBtnRobotGrapGo.Click += new System.EventHandler(this.CBtnRobotGrapGo_Click);
            // 
            // PicBoxRobotGrapVacuumCheck
            // 
            this.PicBoxRobotGrapVacuumCheck.Image = global::RobotWorkstation.Properties.Resources.SmallDarkGreen;
            this.PicBoxRobotGrapVacuumCheck.Location = new System.Drawing.Point(277, 33);
            this.PicBoxRobotGrapVacuumCheck.Name = "PicBoxRobotGrapVacuumCheck";
            this.PicBoxRobotGrapVacuumCheck.Size = new System.Drawing.Size(22, 22);
            this.PicBoxRobotGrapVacuumCheck.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PicBoxRobotGrapVacuumCheck.TabIndex = 20;
            this.PicBoxRobotGrapVacuumCheck.TabStop = false;
            // 
            // customLabel53
            // 
            this.customLabel53.AutoSize = true;
            this.customLabel53.Font = new System.Drawing.Font("微软雅黑", 12.5F);
            this.customLabel53.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(210)))), ((int)(((byte)(210)))));
            this.customLabel53.Location = new System.Drawing.Point(221, 31);
            this.customLabel53.Name = "customLabel53";
            this.customLabel53.Size = new System.Drawing.Size(61, 23);
            this.customLabel53.TabIndex = 19;
            this.customLabel53.Text = "真空：";
            // 
            // PicBoxRobotGrapBackArrive
            // 
            this.PicBoxRobotGrapBackArrive.Image = global::RobotWorkstation.Properties.Resources.SmallDarkGreen;
            this.PicBoxRobotGrapBackArrive.Location = new System.Drawing.Point(178, 33);
            this.PicBoxRobotGrapBackArrive.Name = "PicBoxRobotGrapBackArrive";
            this.PicBoxRobotGrapBackArrive.Size = new System.Drawing.Size(22, 22);
            this.PicBoxRobotGrapBackArrive.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PicBoxRobotGrapBackArrive.TabIndex = 18;
            this.PicBoxRobotGrapBackArrive.TabStop = false;
            // 
            // CLabelRobotGrapBackArrive
            // 
            this.CLabelRobotGrapBackArrive.AutoSize = true;
            this.CLabelRobotGrapBackArrive.Font = new System.Drawing.Font("微软雅黑", 12.5F);
            this.CLabelRobotGrapBackArrive.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(210)))), ((int)(((byte)(210)))));
            this.CLabelRobotGrapBackArrive.Location = new System.Drawing.Point(107, 32);
            this.CLabelRobotGrapBackArrive.Name = "CLabelRobotGrapBackArrive";
            this.CLabelRobotGrapBackArrive.Size = new System.Drawing.Size(78, 23);
            this.CLabelRobotGrapBackArrive.TabIndex = 17;
            this.CLabelRobotGrapBackArrive.Text = "退到位：";
            // 
            // PicBoxRobotGrapGoArrive
            // 
            this.PicBoxRobotGrapGoArrive.Image = global::RobotWorkstation.Properties.Resources.SmallDarkGreen;
            this.PicBoxRobotGrapGoArrive.Location = new System.Drawing.Point(76, 32);
            this.PicBoxRobotGrapGoArrive.Name = "PicBoxRobotGrapGoArrive";
            this.PicBoxRobotGrapGoArrive.Size = new System.Drawing.Size(22, 22);
            this.PicBoxRobotGrapGoArrive.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PicBoxRobotGrapGoArrive.TabIndex = 16;
            this.PicBoxRobotGrapGoArrive.TabStop = false;
            // 
            // CLabelRobotGrapGoArrive
            // 
            this.CLabelRobotGrapGoArrive.AutoSize = true;
            this.CLabelRobotGrapGoArrive.Font = new System.Drawing.Font("微软雅黑", 12.5F);
            this.CLabelRobotGrapGoArrive.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(210)))), ((int)(((byte)(210)))));
            this.CLabelRobotGrapGoArrive.Location = new System.Drawing.Point(8, 31);
            this.CLabelRobotGrapGoArrive.Name = "CLabelRobotGrapGoArrive";
            this.CLabelRobotGrapGoArrive.Size = new System.Drawing.Size(78, 23);
            this.CLabelRobotGrapGoArrive.TabIndex = 0;
            this.CLabelRobotGrapGoArrive.Text = "进到位：";
            // 
            // groupBoxRobot
            // 
            this.groupBoxRobot.Controls.Add(this.CBtnRobotTestTurnOver);
            this.groupBoxRobot.Controls.Add(this.CBtnRobotTestRunAction);
            this.groupBoxRobot.Controls.Add(this.ComBoxRobotActions);
            this.groupBoxRobot.Controls.Add(this.CBtnRobotTestTeachPoint);
            this.groupBoxRobot.Controls.Add(this.CBtnRobotTestMoveToPoint);
            this.groupBoxRobot.Controls.Add(this.customLabel19);
            this.groupBoxRobot.Controls.Add(this.CBtnRobotTestReadPoint);
            this.groupBoxRobot.Controls.Add(this.CTabControlBorderRobotTestPoints);
            this.groupBoxRobot.Controls.Add(this.CButtonRobotDistanceRZSub);
            this.groupBoxRobot.Controls.Add(this.CButtonRobotDistanceRZAdd);
            this.groupBoxRobot.Controls.Add(this.CTextBoxRobotDistanceRZ);
            this.groupBoxRobot.Controls.Add(this.customLabel15);
            this.groupBoxRobot.Controls.Add(this.CButtonRobotDistanceZSub);
            this.groupBoxRobot.Controls.Add(this.CButtonRobotDistanceZAdd);
            this.groupBoxRobot.Controls.Add(this.CTextBoxRobotDistanceZ);
            this.groupBoxRobot.Controls.Add(this.customLabel16);
            this.groupBoxRobot.Controls.Add(this.CButtonRobotDistanceYSub);
            this.groupBoxRobot.Controls.Add(this.CButtonRobotDistanceYAdd);
            this.groupBoxRobot.Controls.Add(this.CTextBoxRobotDistanceY);
            this.groupBoxRobot.Controls.Add(this.customLabel17);
            this.groupBoxRobot.Controls.Add(this.CButtonRobotDistanceXSub);
            this.groupBoxRobot.Controls.Add(this.CButtonRobotDistanceXAdd);
            this.groupBoxRobot.Controls.Add(this.CTextBoxRobotDistanceX);
            this.groupBoxRobot.Controls.Add(this.customLabel18);
            this.groupBoxRobot.Controls.Add(this.CButtonRobotDistanceJ4Sub);
            this.groupBoxRobot.Controls.Add(this.CButtonRobotDistanceJ4Add);
            this.groupBoxRobot.Controls.Add(this.CTextBoxRobotDistanceJ4);
            this.groupBoxRobot.Controls.Add(this.customLabel14);
            this.groupBoxRobot.Controls.Add(this.CButtonRobotDistanceJ3Sub);
            this.groupBoxRobot.Controls.Add(this.CButtonRobotDistanceJ3Add);
            this.groupBoxRobot.Controls.Add(this.CTextBoxRobotDistanceJ3);
            this.groupBoxRobot.Controls.Add(this.customLabel13);
            this.groupBoxRobot.Controls.Add(this.CButtonRobotDistanceJ2Sub);
            this.groupBoxRobot.Controls.Add(this.CButtonRobotDistanceJ2Add);
            this.groupBoxRobot.Controls.Add(this.CTextBoxRobotDistanceJ2);
            this.groupBoxRobot.Controls.Add(this.customLabel12);
            this.groupBoxRobot.Controls.Add(this.CButtonRobotDistanceJ1Sub);
            this.groupBoxRobot.Controls.Add(this.CButtonRobotDistanceJ1Add);
            this.groupBoxRobot.Controls.Add(this.CTextBoxRobotDistanceJ1);
            this.groupBoxRobot.Controls.Add(this.customLabel11);
            this.groupBoxRobot.Controls.Add(this.radioButtonRobotDeviceContinuous);
            this.groupBoxRobot.Controls.Add(this.radioButtonRobotDeviceJog);
            this.groupBoxRobot.Controls.Add(this.customLabel9);
            this.groupBoxRobot.Controls.Add(this.CTextBoxRobotMoveSpeed);
            this.groupBoxRobot.Controls.Add(this.customLabel8);
            this.groupBoxRobot.Controls.Add(this.customLabel7);
            this.groupBoxRobot.Controls.Add(this.CTextBoxJogDistanceUm);
            this.groupBoxRobot.Controls.Add(this.customLabel6);
            this.groupBoxRobot.Controls.Add(this.CTextBoxJogDistance);
            this.groupBoxRobot.Controls.Add(this.customLabel5);
            this.groupBoxRobot.Controls.Add(this.pictureBoxRobotMove);
            this.groupBoxRobot.Controls.Add(this.customLabel4);
            this.groupBoxRobot.Controls.Add(this.pictureBoxTemperature);
            this.groupBoxRobot.Controls.Add(this.customLabel3);
            this.groupBoxRobot.Controls.Add(this.CButtonRobotExecStop);
            this.groupBoxRobot.Controls.Add(this.CButtonRobotExecPause);
            this.groupBoxRobot.Controls.Add(this.CButtonRobotExecRun);
            this.groupBoxRobot.Controls.Add(this.pictureBoxRobotExecut);
            this.groupBoxRobot.Controls.Add(this.customLabel2);
            this.groupBoxRobot.Controls.Add(this.CButtonReset);
            this.groupBoxRobot.Controls.Add(this.pictureBoxRobotAlarm);
            this.groupBoxRobot.Controls.Add(this.customLabel1);
            this.groupBoxRobot.Controls.Add(this.CButtonServoOff);
            this.groupBoxRobot.Controls.Add(this.CBttonServoOn);
            this.groupBoxRobot.Controls.Add(this.pictureBoxServo);
            this.groupBoxRobot.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBoxRobot.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBoxRobot.ForeColor = System.Drawing.Color.White;
            this.groupBoxRobot.Location = new System.Drawing.Point(3, 3);
            this.groupBoxRobot.Name = "groupBoxRobot";
            this.groupBoxRobot.Size = new System.Drawing.Size(1242, 660);
            this.groupBoxRobot.TabIndex = 0;
            this.groupBoxRobot.TabStop = false;
            this.groupBoxRobot.Text = "机器人";
            // 
            // CBtnRobotTestTurnOver
            // 
            this.CBtnRobotTestTurnOver.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(74)))), ((int)(((byte)(74)))));
            this.CBtnRobotTestTurnOver.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CBtnRobotTestTurnOver.Font = new System.Drawing.Font("微软雅黑", 12.5F);
            this.CBtnRobotTestTurnOver.ForeColor = System.Drawing.Color.Transparent;
            this.CBtnRobotTestTurnOver.Location = new System.Drawing.Point(1004, 611);
            this.CBtnRobotTestTurnOver.Name = "CBtnRobotTestTurnOver";
            this.CBtnRobotTestTurnOver.Size = new System.Drawing.Size(90, 36);
            this.CBtnRobotTestTurnOver.TabIndex = 67;
            this.CBtnRobotTestTurnOver.Text = "翻转";
            this.CBtnRobotTestTurnOver.UseVisualStyleBackColor = false;
            this.CBtnRobotTestTurnOver.Click += new System.EventHandler(this.CBtnRobotTestTurnOver_Click);
            // 
            // CBtnRobotTestRunAction
            // 
            this.CBtnRobotTestRunAction.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(74)))), ((int)(((byte)(74)))));
            this.CBtnRobotTestRunAction.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CBtnRobotTestRunAction.Font = new System.Drawing.Font("微软雅黑", 12.5F);
            this.CBtnRobotTestRunAction.ForeColor = System.Drawing.Color.Transparent;
            this.CBtnRobotTestRunAction.Location = new System.Drawing.Point(908, 611);
            this.CBtnRobotTestRunAction.Name = "CBtnRobotTestRunAction";
            this.CBtnRobotTestRunAction.Size = new System.Drawing.Size(90, 36);
            this.CBtnRobotTestRunAction.TabIndex = 66;
            this.CBtnRobotTestRunAction.Text = "执行动作";
            this.CBtnRobotTestRunAction.UseVisualStyleBackColor = false;
            this.CBtnRobotTestRunAction.Click += new System.EventHandler(this.CBtnRobotTestRunAction_Click);
            // 
            // ComBoxRobotActions
            // 
            this.ComBoxRobotActions.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.ComBoxRobotActions.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ComBoxRobotActions.ForeColor = System.Drawing.Color.White;
            this.ComBoxRobotActions.FormattingEnabled = true;
            this.ComBoxRobotActions.Items.AddRange(new object[] {
            "抓取器件 1 扫码放置",
            "抓取器件 2 扫码放置",
            "抓取器件 3 扫码放置",
            "抓取器件 4 扫码放置",
            "抓取器件 5 扫码放置",
            "抓取器件 6 扫码放置",
            "抓取器件 7 扫码放置",
            "抓取器件 8 扫码放置",
            "抓取器件 9 扫码放置",
            "抓取器件 10 扫码放置",
            "抓取器件 11 扫码放置",
            "抓取器件 12 扫码放置",
            "抓取器件 13 扫码放置",
            "抓取器件 14 扫码放置",
            "抓取器件 15 扫码放置",
            "抓取器件 16 扫码放置"});
            this.ComBoxRobotActions.Location = new System.Drawing.Point(699, 615);
            this.ComBoxRobotActions.Name = "ComBoxRobotActions";
            this.ComBoxRobotActions.Size = new System.Drawing.Size(203, 29);
            this.ComBoxRobotActions.TabIndex = 65;
            // 
            // CBtnRobotTestTeachPoint
            // 
            this.CBtnRobotTestTeachPoint.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(74)))), ((int)(((byte)(74)))));
            this.CBtnRobotTestTeachPoint.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CBtnRobotTestTeachPoint.Font = new System.Drawing.Font("微软雅黑", 12.5F);
            this.CBtnRobotTestTeachPoint.ForeColor = System.Drawing.Color.Transparent;
            this.CBtnRobotTestTeachPoint.Location = new System.Drawing.Point(565, 612);
            this.CBtnRobotTestTeachPoint.Name = "CBtnRobotTestTeachPoint";
            this.CBtnRobotTestTeachPoint.Size = new System.Drawing.Size(90, 36);
            this.CBtnRobotTestTeachPoint.TabIndex = 63;
            this.CBtnRobotTestTeachPoint.Text = "学习点位";
            this.CBtnRobotTestTeachPoint.UseVisualStyleBackColor = false;
            this.CBtnRobotTestTeachPoint.Click += new System.EventHandler(this.CBtnRobotTestTeachPoint_Click);
            // 
            // CBtnRobotTestMoveToPoint
            // 
            this.CBtnRobotTestMoveToPoint.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(74)))), ((int)(((byte)(74)))));
            this.CBtnRobotTestMoveToPoint.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CBtnRobotTestMoveToPoint.Font = new System.Drawing.Font("微软雅黑", 12.5F);
            this.CBtnRobotTestMoveToPoint.ForeColor = System.Drawing.Color.Transparent;
            this.CBtnRobotTestMoveToPoint.Location = new System.Drawing.Point(468, 612);
            this.CBtnRobotTestMoveToPoint.Name = "CBtnRobotTestMoveToPoint";
            this.CBtnRobotTestMoveToPoint.Size = new System.Drawing.Size(90, 36);
            this.CBtnRobotTestMoveToPoint.TabIndex = 62;
            this.CBtnRobotTestMoveToPoint.Text = "移到点位";
            this.CBtnRobotTestMoveToPoint.UseVisualStyleBackColor = false;
            this.CBtnRobotTestMoveToPoint.MouseDown += new System.Windows.Forms.MouseEventHandler(this.CBtnRobotTestMoveToPoint_MouseDown);
            this.CBtnRobotTestMoveToPoint.MouseUp += new System.Windows.Forms.MouseEventHandler(this.CBtnRobotTestMoveToPoint_MouseUp);
            // 
            // customLabel19
            // 
            this.customLabel19.AutoSize = true;
            this.customLabel19.Font = new System.Drawing.Font("微软雅黑", 12.5F);
            this.customLabel19.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(210)))), ((int)(((byte)(210)))));
            this.customLabel19.Location = new System.Drawing.Point(20, 35);
            this.customLabel19.Name = "customLabel19";
            this.customLabel19.Size = new System.Drawing.Size(61, 23);
            this.customLabel19.TabIndex = 61;
            this.customLabel19.Text = "伺服：";
            // 
            // CBtnRobotTestReadPoint
            // 
            this.CBtnRobotTestReadPoint.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(74)))), ((int)(((byte)(74)))));
            this.CBtnRobotTestReadPoint.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CBtnRobotTestReadPoint.Font = new System.Drawing.Font("微软雅黑", 12.5F);
            this.CBtnRobotTestReadPoint.ForeColor = System.Drawing.Color.Transparent;
            this.CBtnRobotTestReadPoint.Location = new System.Drawing.Point(371, 612);
            this.CBtnRobotTestReadPoint.Name = "CBtnRobotTestReadPoint";
            this.CBtnRobotTestReadPoint.Size = new System.Drawing.Size(90, 36);
            this.CBtnRobotTestReadPoint.TabIndex = 60;
            this.CBtnRobotTestReadPoint.Text = "读取点位";
            this.CBtnRobotTestReadPoint.UseVisualStyleBackColor = false;
            this.CBtnRobotTestReadPoint.Click += new System.EventHandler(this.CBtnRobotTestReadPoint_Click);
            // 
            // CTabControlBorderRobotTestPoints
            // 
            this.CTabControlBorderRobotTestPoints.Controls.Add(this.PageRobotTestGlobalPoint);
            this.CTabControlBorderRobotTestPoints.Controls.Add(this.PageRobotTestUserFrame);
            this.CTabControlBorderRobotTestPoints.Controls.Add(this.PageRobotTestToolFrame);
            this.CTabControlBorderRobotTestPoints.Controls.Add(this.PageRobotTestWorkSpace);
            this.CTabControlBorderRobotTestPoints.Location = new System.Drawing.Point(372, 28);
            this.CTabControlBorderRobotTestPoints.Margin = new System.Windows.Forms.Padding(1);
            this.CTabControlBorderRobotTestPoints.Name = "CTabControlBorderRobotTestPoints";
            this.CTabControlBorderRobotTestPoints.SelectedIndex = 0;
            this.CTabControlBorderRobotTestPoints.Size = new System.Drawing.Size(720, 577);
            this.CTabControlBorderRobotTestPoints.TabIndex = 59;
            // 
            // PageRobotTestGlobalPoint
            // 
            this.PageRobotTestGlobalPoint.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.PageRobotTestGlobalPoint.Controls.Add(this.DGV_RobotGlobalPoint);
            this.PageRobotTestGlobalPoint.Location = new System.Drawing.Point(1, 29);
            this.PageRobotTestGlobalPoint.Margin = new System.Windows.Forms.Padding(1);
            this.PageRobotTestGlobalPoint.Name = "PageRobotTestGlobalPoint";
            this.PageRobotTestGlobalPoint.Padding = new System.Windows.Forms.Padding(1);
            this.PageRobotTestGlobalPoint.Size = new System.Drawing.Size(718, 547);
            this.PageRobotTestGlobalPoint.TabIndex = 0;
            this.PageRobotTestGlobalPoint.Text = "全局点位";
            // 
            // DGV_RobotGlobalPoint
            // 
            this.DGV_RobotGlobalPoint.AllowDrop = true;
            this.DGV_RobotGlobalPoint.AllowUserToAddRows = false;
            this.DGV_RobotGlobalPoint.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DGV_RobotGlobalPoint.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.DGV_RobotGlobalPoint.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.DGV_RobotGlobalPoint.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.DGV_RobotGlobalPoint.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(210)))), ((int)(((byte)(210)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGV_RobotGlobalPoint.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DGV_RobotGlobalPoint.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.DGV_RobotGlobalPoint.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.RobotTestName,
            this.RobotTestX,
            this.RobotTestY,
            this.RobotTestZ,
            this.RobotTestRZ,
            this.RobotTestHand,
            this.RobotTestUserID,
            this.RobotTestToolID});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGV_RobotGlobalPoint.DefaultCellStyle = dataGridViewCellStyle3;
            this.DGV_RobotGlobalPoint.EnableHeadersVisualStyles = false;
            this.DGV_RobotGlobalPoint.GridColor = System.Drawing.Color.DarkGray;
            this.DGV_RobotGlobalPoint.Location = new System.Drawing.Point(0, 0);
            this.DGV_RobotGlobalPoint.Margin = new System.Windows.Forms.Padding(1);
            this.DGV_RobotGlobalPoint.Name = "DGV_RobotGlobalPoint";
            this.DGV_RobotGlobalPoint.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(74)))), ((int)(((byte)(74)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(210)))), ((int)(((byte)(210)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGV_RobotGlobalPoint.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.DGV_RobotGlobalPoint.RowHeadersWidth = 80;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(74)))), ((int)(((byte)(74)))));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(210)))), ((int)(((byte)(210)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.DGV_RobotGlobalPoint.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.DGV_RobotGlobalPoint.RowTemplate.Height = 23;
            this.DGV_RobotGlobalPoint.Size = new System.Drawing.Size(719, 546);
            this.DGV_RobotGlobalPoint.TabIndex = 0;
            this.DGV_RobotGlobalPoint.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_RobotGlobalPoint_CellClick);
            // 
            // RobotTestName
            // 
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(210)))), ((int)(((byte)(210)))));
            this.RobotTestName.DefaultCellStyle = dataGridViewCellStyle2;
            this.RobotTestName.HeaderText = "名称";
            this.RobotTestName.Name = "RobotTestName";
            this.RobotTestName.Width = 67;
            // 
            // RobotTestX
            // 
            this.RobotTestX.HeaderText = "X";
            this.RobotTestX.Name = "RobotTestX";
            this.RobotTestX.Width = 45;
            // 
            // RobotTestY
            // 
            this.RobotTestY.HeaderText = "Y";
            this.RobotTestY.Name = "RobotTestY";
            this.RobotTestY.Width = 45;
            // 
            // RobotTestZ
            // 
            this.RobotTestZ.HeaderText = "Z";
            this.RobotTestZ.Name = "RobotTestZ";
            this.RobotTestZ.Width = 45;
            // 
            // RobotTestRZ
            // 
            this.RobotTestRZ.HeaderText = "RZ";
            this.RobotTestRZ.Name = "RobotTestRZ";
            this.RobotTestRZ.Width = 55;
            // 
            // RobotTestHand
            // 
            this.RobotTestHand.HeaderText = "手系";
            this.RobotTestHand.Name = "RobotTestHand";
            this.RobotTestHand.Width = 67;
            // 
            // RobotTestUserID
            // 
            this.RobotTestUserID.HeaderText = "UserID";
            this.RobotTestUserID.Name = "RobotTestUserID";
            this.RobotTestUserID.Width = 86;
            // 
            // RobotTestToolID
            // 
            this.RobotTestToolID.HeaderText = "ToolID";
            this.RobotTestToolID.Name = "RobotTestToolID";
            this.RobotTestToolID.Width = 85;
            // 
            // PageRobotTestUserFrame
            // 
            this.PageRobotTestUserFrame.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.PageRobotTestUserFrame.Location = new System.Drawing.Point(1, 29);
            this.PageRobotTestUserFrame.Margin = new System.Windows.Forms.Padding(1);
            this.PageRobotTestUserFrame.Name = "PageRobotTestUserFrame";
            this.PageRobotTestUserFrame.Padding = new System.Windows.Forms.Padding(1);
            this.PageRobotTestUserFrame.Size = new System.Drawing.Size(718, 547);
            this.PageRobotTestUserFrame.TabIndex = 1;
            this.PageRobotTestUserFrame.Text = "使用者坐标";
            // 
            // PageRobotTestToolFrame
            // 
            this.PageRobotTestToolFrame.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.PageRobotTestToolFrame.Location = new System.Drawing.Point(1, 29);
            this.PageRobotTestToolFrame.Margin = new System.Windows.Forms.Padding(1);
            this.PageRobotTestToolFrame.Name = "PageRobotTestToolFrame";
            this.PageRobotTestToolFrame.Padding = new System.Windows.Forms.Padding(1);
            this.PageRobotTestToolFrame.Size = new System.Drawing.Size(718, 547);
            this.PageRobotTestToolFrame.TabIndex = 2;
            this.PageRobotTestToolFrame.Text = "工具坐标";
            // 
            // PageRobotTestWorkSpace
            // 
            this.PageRobotTestWorkSpace.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.PageRobotTestWorkSpace.Location = new System.Drawing.Point(1, 29);
            this.PageRobotTestWorkSpace.Margin = new System.Windows.Forms.Padding(1);
            this.PageRobotTestWorkSpace.Name = "PageRobotTestWorkSpace";
            this.PageRobotTestWorkSpace.Padding = new System.Windows.Forms.Padding(1);
            this.PageRobotTestWorkSpace.Size = new System.Drawing.Size(718, 547);
            this.PageRobotTestWorkSpace.TabIndex = 3;
            this.PageRobotTestWorkSpace.Text = "工作空间";
            // 
            // CButtonRobotDistanceRZSub
            // 
            this.CButtonRobotDistanceRZSub.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(74)))), ((int)(((byte)(74)))));
            this.CButtonRobotDistanceRZSub.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CButtonRobotDistanceRZSub.Font = new System.Drawing.Font("微软雅黑", 12.5F);
            this.CButtonRobotDistanceRZSub.ForeColor = System.Drawing.Color.Transparent;
            this.CButtonRobotDistanceRZSub.Location = new System.Drawing.Point(271, 612);
            this.CButtonRobotDistanceRZSub.Name = "CButtonRobotDistanceRZSub";
            this.CButtonRobotDistanceRZSub.Size = new System.Drawing.Size(90, 36);
            this.CButtonRobotDistanceRZSub.TabIndex = 58;
            this.CButtonRobotDistanceRZSub.Text = "RZ -";
            this.CButtonRobotDistanceRZSub.UseVisualStyleBackColor = false;
            this.CButtonRobotDistanceRZSub.MouseDown += new System.Windows.Forms.MouseEventHandler(this.CButtonRobotDistanceRZSub_MouseDown);
            this.CButtonRobotDistanceRZSub.MouseUp += new System.Windows.Forms.MouseEventHandler(this.CButtonRobotDistanceRZSub_MouseUp);
            // 
            // CButtonRobotDistanceRZAdd
            // 
            this.CButtonRobotDistanceRZAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(74)))), ((int)(((byte)(74)))));
            this.CButtonRobotDistanceRZAdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CButtonRobotDistanceRZAdd.Font = new System.Drawing.Font("微软雅黑", 12.5F);
            this.CButtonRobotDistanceRZAdd.ForeColor = System.Drawing.Color.Transparent;
            this.CButtonRobotDistanceRZAdd.Location = new System.Drawing.Point(175, 612);
            this.CButtonRobotDistanceRZAdd.Name = "CButtonRobotDistanceRZAdd";
            this.CButtonRobotDistanceRZAdd.Size = new System.Drawing.Size(90, 36);
            this.CButtonRobotDistanceRZAdd.TabIndex = 57;
            this.CButtonRobotDistanceRZAdd.Text = "RZ +";
            this.CButtonRobotDistanceRZAdd.UseVisualStyleBackColor = false;
            this.CButtonRobotDistanceRZAdd.MouseDown += new System.Windows.Forms.MouseEventHandler(this.CButtonRobotDistanceRZAdd_MouseDown);
            this.CButtonRobotDistanceRZAdd.MouseUp += new System.Windows.Forms.MouseEventHandler(this.CButtonRobotDistanceRZAdd_MouseUp);
            // 
            // CTextBoxRobotDistanceRZ
            // 
            this.CTextBoxRobotDistanceRZ.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.CTextBoxRobotDistanceRZ.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CTextBoxRobotDistanceRZ.Font = new System.Drawing.Font("微软雅黑", 12.5F);
            this.CTextBoxRobotDistanceRZ.ForeColor = System.Drawing.Color.White;
            this.CTextBoxRobotDistanceRZ.Location = new System.Drawing.Point(59, 615);
            this.CTextBoxRobotDistanceRZ.Multiline = true;
            this.CTextBoxRobotDistanceRZ.Name = "CTextBoxRobotDistanceRZ";
            this.CTextBoxRobotDistanceRZ.Size = new System.Drawing.Size(105, 32);
            this.CTextBoxRobotDistanceRZ.TabIndex = 56;
            this.CTextBoxRobotDistanceRZ.Text = "0.000";
            // 
            // customLabel15
            // 
            this.customLabel15.AutoSize = true;
            this.customLabel15.Font = new System.Drawing.Font("微软雅黑", 12.5F);
            this.customLabel15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(210)))), ((int)(((byte)(210)))));
            this.customLabel15.Location = new System.Drawing.Point(6, 619);
            this.customLabel15.Name = "customLabel15";
            this.customLabel15.Size = new System.Drawing.Size(49, 23);
            this.customLabel15.TabIndex = 55;
            this.customLabel15.Text = "RZ：";
            // 
            // CButtonRobotDistanceZSub
            // 
            this.CButtonRobotDistanceZSub.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(74)))), ((int)(((byte)(74)))));
            this.CButtonRobotDistanceZSub.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CButtonRobotDistanceZSub.Font = new System.Drawing.Font("微软雅黑", 12.5F);
            this.CButtonRobotDistanceZSub.ForeColor = System.Drawing.Color.Transparent;
            this.CButtonRobotDistanceZSub.Location = new System.Drawing.Point(271, 575);
            this.CButtonRobotDistanceZSub.Name = "CButtonRobotDistanceZSub";
            this.CButtonRobotDistanceZSub.Size = new System.Drawing.Size(90, 36);
            this.CButtonRobotDistanceZSub.TabIndex = 54;
            this.CButtonRobotDistanceZSub.Text = "Z -";
            this.CButtonRobotDistanceZSub.UseVisualStyleBackColor = false;
            this.CButtonRobotDistanceZSub.MouseDown += new System.Windows.Forms.MouseEventHandler(this.CButtonRobotDistanceZSub_MouseDown);
            this.CButtonRobotDistanceZSub.MouseUp += new System.Windows.Forms.MouseEventHandler(this.CButtonRobotDistanceZSub_MouseUp);
            // 
            // CButtonRobotDistanceZAdd
            // 
            this.CButtonRobotDistanceZAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(74)))), ((int)(((byte)(74)))));
            this.CButtonRobotDistanceZAdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CButtonRobotDistanceZAdd.Font = new System.Drawing.Font("微软雅黑", 12.5F);
            this.CButtonRobotDistanceZAdd.ForeColor = System.Drawing.Color.Transparent;
            this.CButtonRobotDistanceZAdd.Location = new System.Drawing.Point(175, 575);
            this.CButtonRobotDistanceZAdd.Name = "CButtonRobotDistanceZAdd";
            this.CButtonRobotDistanceZAdd.Size = new System.Drawing.Size(90, 36);
            this.CButtonRobotDistanceZAdd.TabIndex = 53;
            this.CButtonRobotDistanceZAdd.Text = "Z +";
            this.CButtonRobotDistanceZAdd.UseVisualStyleBackColor = false;
            this.CButtonRobotDistanceZAdd.MouseDown += new System.Windows.Forms.MouseEventHandler(this.CButtonRobotDistanceZAdd_MouseDown);
            this.CButtonRobotDistanceZAdd.MouseUp += new System.Windows.Forms.MouseEventHandler(this.CButtonRobotDistanceZAdd_MouseUp);
            // 
            // CTextBoxRobotDistanceZ
            // 
            this.CTextBoxRobotDistanceZ.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.CTextBoxRobotDistanceZ.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CTextBoxRobotDistanceZ.Font = new System.Drawing.Font("微软雅黑", 12.5F);
            this.CTextBoxRobotDistanceZ.ForeColor = System.Drawing.Color.White;
            this.CTextBoxRobotDistanceZ.Location = new System.Drawing.Point(59, 578);
            this.CTextBoxRobotDistanceZ.Multiline = true;
            this.CTextBoxRobotDistanceZ.Name = "CTextBoxRobotDistanceZ";
            this.CTextBoxRobotDistanceZ.Size = new System.Drawing.Size(105, 32);
            this.CTextBoxRobotDistanceZ.TabIndex = 52;
            this.CTextBoxRobotDistanceZ.Text = "0.000";
            // 
            // customLabel16
            // 
            this.customLabel16.AutoSize = true;
            this.customLabel16.Font = new System.Drawing.Font("微软雅黑", 12.5F);
            this.customLabel16.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(210)))), ((int)(((byte)(210)))));
            this.customLabel16.Location = new System.Drawing.Point(17, 582);
            this.customLabel16.Name = "customLabel16";
            this.customLabel16.Size = new System.Drawing.Size(38, 23);
            this.customLabel16.TabIndex = 51;
            this.customLabel16.Text = "Z：";
            // 
            // CButtonRobotDistanceYSub
            // 
            this.CButtonRobotDistanceYSub.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(74)))), ((int)(((byte)(74)))));
            this.CButtonRobotDistanceYSub.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CButtonRobotDistanceYSub.Font = new System.Drawing.Font("微软雅黑", 12.5F);
            this.CButtonRobotDistanceYSub.ForeColor = System.Drawing.Color.Transparent;
            this.CButtonRobotDistanceYSub.Location = new System.Drawing.Point(271, 538);
            this.CButtonRobotDistanceYSub.Name = "CButtonRobotDistanceYSub";
            this.CButtonRobotDistanceYSub.Size = new System.Drawing.Size(90, 36);
            this.CButtonRobotDistanceYSub.TabIndex = 50;
            this.CButtonRobotDistanceYSub.Text = "Y -";
            this.CButtonRobotDistanceYSub.UseVisualStyleBackColor = false;
            this.CButtonRobotDistanceYSub.MouseDown += new System.Windows.Forms.MouseEventHandler(this.CButtonRobotDistanceYSub_MouseDown);
            this.CButtonRobotDistanceYSub.MouseUp += new System.Windows.Forms.MouseEventHandler(this.CButtonRobotDistanceYSub_MouseUp);
            // 
            // CButtonRobotDistanceYAdd
            // 
            this.CButtonRobotDistanceYAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(74)))), ((int)(((byte)(74)))));
            this.CButtonRobotDistanceYAdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CButtonRobotDistanceYAdd.Font = new System.Drawing.Font("微软雅黑", 12.5F);
            this.CButtonRobotDistanceYAdd.ForeColor = System.Drawing.Color.Transparent;
            this.CButtonRobotDistanceYAdd.Location = new System.Drawing.Point(175, 538);
            this.CButtonRobotDistanceYAdd.Name = "CButtonRobotDistanceYAdd";
            this.CButtonRobotDistanceYAdd.Size = new System.Drawing.Size(90, 36);
            this.CButtonRobotDistanceYAdd.TabIndex = 49;
            this.CButtonRobotDistanceYAdd.Text = "Y +";
            this.CButtonRobotDistanceYAdd.UseVisualStyleBackColor = false;
            this.CButtonRobotDistanceYAdd.MouseDown += new System.Windows.Forms.MouseEventHandler(this.CButtonRobotDistanceYAdd_MouseDown);
            this.CButtonRobotDistanceYAdd.MouseUp += new System.Windows.Forms.MouseEventHandler(this.CButtonRobotDistanceYAdd_MouseUp);
            // 
            // CTextBoxRobotDistanceY
            // 
            this.CTextBoxRobotDistanceY.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.CTextBoxRobotDistanceY.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CTextBoxRobotDistanceY.Font = new System.Drawing.Font("微软雅黑", 12.5F);
            this.CTextBoxRobotDistanceY.ForeColor = System.Drawing.Color.White;
            this.CTextBoxRobotDistanceY.Location = new System.Drawing.Point(59, 541);
            this.CTextBoxRobotDistanceY.Multiline = true;
            this.CTextBoxRobotDistanceY.Name = "CTextBoxRobotDistanceY";
            this.CTextBoxRobotDistanceY.Size = new System.Drawing.Size(105, 32);
            this.CTextBoxRobotDistanceY.TabIndex = 48;
            this.CTextBoxRobotDistanceY.Text = "0.000";
            // 
            // customLabel17
            // 
            this.customLabel17.AutoSize = true;
            this.customLabel17.Font = new System.Drawing.Font("微软雅黑", 12.5F);
            this.customLabel17.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(210)))), ((int)(((byte)(210)))));
            this.customLabel17.Location = new System.Drawing.Point(18, 545);
            this.customLabel17.Name = "customLabel17";
            this.customLabel17.Size = new System.Drawing.Size(37, 23);
            this.customLabel17.TabIndex = 47;
            this.customLabel17.Text = "Y：";
            // 
            // CButtonRobotDistanceXSub
            // 
            this.CButtonRobotDistanceXSub.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(74)))), ((int)(((byte)(74)))));
            this.CButtonRobotDistanceXSub.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CButtonRobotDistanceXSub.Font = new System.Drawing.Font("微软雅黑", 12.5F);
            this.CButtonRobotDistanceXSub.ForeColor = System.Drawing.Color.Transparent;
            this.CButtonRobotDistanceXSub.Location = new System.Drawing.Point(271, 501);
            this.CButtonRobotDistanceXSub.Name = "CButtonRobotDistanceXSub";
            this.CButtonRobotDistanceXSub.Size = new System.Drawing.Size(90, 36);
            this.CButtonRobotDistanceXSub.TabIndex = 46;
            this.CButtonRobotDistanceXSub.Text = "X -";
            this.CButtonRobotDistanceXSub.UseVisualStyleBackColor = false;
            this.CButtonRobotDistanceXSub.MouseDown += new System.Windows.Forms.MouseEventHandler(this.CButtonRobotDistanceXSub_MouseDown);
            this.CButtonRobotDistanceXSub.MouseUp += new System.Windows.Forms.MouseEventHandler(this.CButtonRobotDistanceXSub_MouseUp);
            // 
            // CButtonRobotDistanceXAdd
            // 
            this.CButtonRobotDistanceXAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(74)))), ((int)(((byte)(74)))));
            this.CButtonRobotDistanceXAdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CButtonRobotDistanceXAdd.Font = new System.Drawing.Font("微软雅黑", 12.5F);
            this.CButtonRobotDistanceXAdd.ForeColor = System.Drawing.Color.Transparent;
            this.CButtonRobotDistanceXAdd.Location = new System.Drawing.Point(175, 501);
            this.CButtonRobotDistanceXAdd.Name = "CButtonRobotDistanceXAdd";
            this.CButtonRobotDistanceXAdd.Size = new System.Drawing.Size(90, 36);
            this.CButtonRobotDistanceXAdd.TabIndex = 45;
            this.CButtonRobotDistanceXAdd.Text = "X +";
            this.CButtonRobotDistanceXAdd.UseVisualStyleBackColor = false;
            this.CButtonRobotDistanceXAdd.MouseDown += new System.Windows.Forms.MouseEventHandler(this.CButtonRobotDistanceXAdd_MouseDown);
            this.CButtonRobotDistanceXAdd.MouseUp += new System.Windows.Forms.MouseEventHandler(this.CButtonRobotDistanceXAdd_MouseUp);
            // 
            // CTextBoxRobotDistanceX
            // 
            this.CTextBoxRobotDistanceX.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.CTextBoxRobotDistanceX.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CTextBoxRobotDistanceX.Font = new System.Drawing.Font("微软雅黑", 12.5F);
            this.CTextBoxRobotDistanceX.ForeColor = System.Drawing.Color.White;
            this.CTextBoxRobotDistanceX.Location = new System.Drawing.Point(59, 504);
            this.CTextBoxRobotDistanceX.Multiline = true;
            this.CTextBoxRobotDistanceX.Name = "CTextBoxRobotDistanceX";
            this.CTextBoxRobotDistanceX.Size = new System.Drawing.Size(105, 32);
            this.CTextBoxRobotDistanceX.TabIndex = 44;
            this.CTextBoxRobotDistanceX.Text = "0.000";
            // 
            // customLabel18
            // 
            this.customLabel18.AutoSize = true;
            this.customLabel18.Font = new System.Drawing.Font("微软雅黑", 12.5F);
            this.customLabel18.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(210)))), ((int)(((byte)(210)))));
            this.customLabel18.Location = new System.Drawing.Point(17, 508);
            this.customLabel18.Name = "customLabel18";
            this.customLabel18.Size = new System.Drawing.Size(38, 23);
            this.customLabel18.TabIndex = 43;
            this.customLabel18.Text = "X：";
            // 
            // CButtonRobotDistanceJ4Sub
            // 
            this.CButtonRobotDistanceJ4Sub.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(74)))), ((int)(((byte)(74)))));
            this.CButtonRobotDistanceJ4Sub.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CButtonRobotDistanceJ4Sub.Font = new System.Drawing.Font("微软雅黑", 12.5F);
            this.CButtonRobotDistanceJ4Sub.ForeColor = System.Drawing.Color.Transparent;
            this.CButtonRobotDistanceJ4Sub.Location = new System.Drawing.Point(271, 464);
            this.CButtonRobotDistanceJ4Sub.Name = "CButtonRobotDistanceJ4Sub";
            this.CButtonRobotDistanceJ4Sub.Size = new System.Drawing.Size(90, 36);
            this.CButtonRobotDistanceJ4Sub.TabIndex = 42;
            this.CButtonRobotDistanceJ4Sub.Text = "J4 -";
            this.CButtonRobotDistanceJ4Sub.UseVisualStyleBackColor = false;
            this.CButtonRobotDistanceJ4Sub.MouseDown += new System.Windows.Forms.MouseEventHandler(this.CButtonRobotDistanceJ4Sub_MouseDown);
            this.CButtonRobotDistanceJ4Sub.MouseUp += new System.Windows.Forms.MouseEventHandler(this.CButtonRobotDistanceJ4Sub_MouseUp);
            // 
            // CButtonRobotDistanceJ4Add
            // 
            this.CButtonRobotDistanceJ4Add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(74)))), ((int)(((byte)(74)))));
            this.CButtonRobotDistanceJ4Add.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CButtonRobotDistanceJ4Add.Font = new System.Drawing.Font("微软雅黑", 12.5F);
            this.CButtonRobotDistanceJ4Add.ForeColor = System.Drawing.Color.Transparent;
            this.CButtonRobotDistanceJ4Add.Location = new System.Drawing.Point(175, 464);
            this.CButtonRobotDistanceJ4Add.Name = "CButtonRobotDistanceJ4Add";
            this.CButtonRobotDistanceJ4Add.Size = new System.Drawing.Size(90, 36);
            this.CButtonRobotDistanceJ4Add.TabIndex = 41;
            this.CButtonRobotDistanceJ4Add.Text = "J4 +";
            this.CButtonRobotDistanceJ4Add.UseVisualStyleBackColor = false;
            this.CButtonRobotDistanceJ4Add.MouseDown += new System.Windows.Forms.MouseEventHandler(this.CButtonRobotDistanceJ4Add_MouseDown);
            this.CButtonRobotDistanceJ4Add.MouseUp += new System.Windows.Forms.MouseEventHandler(this.CButtonRobotDistanceJ4Add_MouseUp);
            // 
            // CTextBoxRobotDistanceJ4
            // 
            this.CTextBoxRobotDistanceJ4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.CTextBoxRobotDistanceJ4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CTextBoxRobotDistanceJ4.Font = new System.Drawing.Font("微软雅黑", 12.5F);
            this.CTextBoxRobotDistanceJ4.ForeColor = System.Drawing.Color.White;
            this.CTextBoxRobotDistanceJ4.Location = new System.Drawing.Point(59, 467);
            this.CTextBoxRobotDistanceJ4.Multiline = true;
            this.CTextBoxRobotDistanceJ4.Name = "CTextBoxRobotDistanceJ4";
            this.CTextBoxRobotDistanceJ4.Size = new System.Drawing.Size(105, 32);
            this.CTextBoxRobotDistanceJ4.TabIndex = 40;
            this.CTextBoxRobotDistanceJ4.Text = "0";
            // 
            // customLabel14
            // 
            this.customLabel14.AutoSize = true;
            this.customLabel14.Font = new System.Drawing.Font("微软雅黑", 12.5F);
            this.customLabel14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(210)))), ((int)(((byte)(210)))));
            this.customLabel14.Location = new System.Drawing.Point(11, 471);
            this.customLabel14.Name = "customLabel14";
            this.customLabel14.Size = new System.Drawing.Size(44, 23);
            this.customLabel14.TabIndex = 39;
            this.customLabel14.Text = "J4：";
            // 
            // CButtonRobotDistanceJ3Sub
            // 
            this.CButtonRobotDistanceJ3Sub.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(74)))), ((int)(((byte)(74)))));
            this.CButtonRobotDistanceJ3Sub.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CButtonRobotDistanceJ3Sub.Font = new System.Drawing.Font("微软雅黑", 12.5F);
            this.CButtonRobotDistanceJ3Sub.ForeColor = System.Drawing.Color.Transparent;
            this.CButtonRobotDistanceJ3Sub.Location = new System.Drawing.Point(271, 427);
            this.CButtonRobotDistanceJ3Sub.Name = "CButtonRobotDistanceJ3Sub";
            this.CButtonRobotDistanceJ3Sub.Size = new System.Drawing.Size(90, 36);
            this.CButtonRobotDistanceJ3Sub.TabIndex = 38;
            this.CButtonRobotDistanceJ3Sub.Text = "J3 -";
            this.CButtonRobotDistanceJ3Sub.UseVisualStyleBackColor = false;
            this.CButtonRobotDistanceJ3Sub.MouseDown += new System.Windows.Forms.MouseEventHandler(this.CButtonRobotDistanceJ3Sub_MouseDown);
            this.CButtonRobotDistanceJ3Sub.MouseUp += new System.Windows.Forms.MouseEventHandler(this.CButtonRobotDistanceJ3Sub_MouseUp);
            // 
            // CButtonRobotDistanceJ3Add
            // 
            this.CButtonRobotDistanceJ3Add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(74)))), ((int)(((byte)(74)))));
            this.CButtonRobotDistanceJ3Add.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CButtonRobotDistanceJ3Add.Font = new System.Drawing.Font("微软雅黑", 12.5F);
            this.CButtonRobotDistanceJ3Add.ForeColor = System.Drawing.Color.Transparent;
            this.CButtonRobotDistanceJ3Add.Location = new System.Drawing.Point(175, 427);
            this.CButtonRobotDistanceJ3Add.Name = "CButtonRobotDistanceJ3Add";
            this.CButtonRobotDistanceJ3Add.Size = new System.Drawing.Size(90, 36);
            this.CButtonRobotDistanceJ3Add.TabIndex = 37;
            this.CButtonRobotDistanceJ3Add.Text = "J3 +";
            this.CButtonRobotDistanceJ3Add.UseVisualStyleBackColor = false;
            this.CButtonRobotDistanceJ3Add.MouseDown += new System.Windows.Forms.MouseEventHandler(this.CButtonRobotDistanceJ3Add_MouseDown);
            this.CButtonRobotDistanceJ3Add.MouseUp += new System.Windows.Forms.MouseEventHandler(this.CButtonRobotDistanceJ3Add_MouseUp);
            // 
            // CTextBoxRobotDistanceJ3
            // 
            this.CTextBoxRobotDistanceJ3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.CTextBoxRobotDistanceJ3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CTextBoxRobotDistanceJ3.Font = new System.Drawing.Font("微软雅黑", 12.5F);
            this.CTextBoxRobotDistanceJ3.ForeColor = System.Drawing.Color.White;
            this.CTextBoxRobotDistanceJ3.Location = new System.Drawing.Point(59, 430);
            this.CTextBoxRobotDistanceJ3.Multiline = true;
            this.CTextBoxRobotDistanceJ3.Name = "CTextBoxRobotDistanceJ3";
            this.CTextBoxRobotDistanceJ3.Size = new System.Drawing.Size(105, 32);
            this.CTextBoxRobotDistanceJ3.TabIndex = 36;
            this.CTextBoxRobotDistanceJ3.Text = "0";
            // 
            // customLabel13
            // 
            this.customLabel13.AutoSize = true;
            this.customLabel13.Font = new System.Drawing.Font("微软雅黑", 12.5F);
            this.customLabel13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(210)))), ((int)(((byte)(210)))));
            this.customLabel13.Location = new System.Drawing.Point(11, 434);
            this.customLabel13.Name = "customLabel13";
            this.customLabel13.Size = new System.Drawing.Size(44, 23);
            this.customLabel13.TabIndex = 35;
            this.customLabel13.Text = "J3：";
            // 
            // CButtonRobotDistanceJ2Sub
            // 
            this.CButtonRobotDistanceJ2Sub.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(74)))), ((int)(((byte)(74)))));
            this.CButtonRobotDistanceJ2Sub.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CButtonRobotDistanceJ2Sub.Font = new System.Drawing.Font("微软雅黑", 12.5F);
            this.CButtonRobotDistanceJ2Sub.ForeColor = System.Drawing.Color.Transparent;
            this.CButtonRobotDistanceJ2Sub.Location = new System.Drawing.Point(271, 390);
            this.CButtonRobotDistanceJ2Sub.Name = "CButtonRobotDistanceJ2Sub";
            this.CButtonRobotDistanceJ2Sub.Size = new System.Drawing.Size(90, 36);
            this.CButtonRobotDistanceJ2Sub.TabIndex = 34;
            this.CButtonRobotDistanceJ2Sub.Text = "J2 -";
            this.CButtonRobotDistanceJ2Sub.UseVisualStyleBackColor = false;
            this.CButtonRobotDistanceJ2Sub.MouseDown += new System.Windows.Forms.MouseEventHandler(this.CButtonRobotDistanceJ2Sub_MouseDown);
            this.CButtonRobotDistanceJ2Sub.MouseUp += new System.Windows.Forms.MouseEventHandler(this.CButtonRobotDistanceJ2Sub_MouseUp);
            // 
            // CButtonRobotDistanceJ2Add
            // 
            this.CButtonRobotDistanceJ2Add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(74)))), ((int)(((byte)(74)))));
            this.CButtonRobotDistanceJ2Add.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CButtonRobotDistanceJ2Add.Font = new System.Drawing.Font("微软雅黑", 12.5F);
            this.CButtonRobotDistanceJ2Add.ForeColor = System.Drawing.Color.Transparent;
            this.CButtonRobotDistanceJ2Add.Location = new System.Drawing.Point(175, 390);
            this.CButtonRobotDistanceJ2Add.Name = "CButtonRobotDistanceJ2Add";
            this.CButtonRobotDistanceJ2Add.Size = new System.Drawing.Size(90, 36);
            this.CButtonRobotDistanceJ2Add.TabIndex = 33;
            this.CButtonRobotDistanceJ2Add.Text = "J2 +";
            this.CButtonRobotDistanceJ2Add.UseVisualStyleBackColor = false;
            this.CButtonRobotDistanceJ2Add.MouseDown += new System.Windows.Forms.MouseEventHandler(this.CButtonRobotDistanceJ2Add_MouseDown);
            this.CButtonRobotDistanceJ2Add.MouseUp += new System.Windows.Forms.MouseEventHandler(this.CButtonRobotDistanceJ2Add_MouseUp);
            // 
            // CTextBoxRobotDistanceJ2
            // 
            this.CTextBoxRobotDistanceJ2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.CTextBoxRobotDistanceJ2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CTextBoxRobotDistanceJ2.Font = new System.Drawing.Font("微软雅黑", 12.5F);
            this.CTextBoxRobotDistanceJ2.ForeColor = System.Drawing.Color.White;
            this.CTextBoxRobotDistanceJ2.Location = new System.Drawing.Point(59, 393);
            this.CTextBoxRobotDistanceJ2.Multiline = true;
            this.CTextBoxRobotDistanceJ2.Name = "CTextBoxRobotDistanceJ2";
            this.CTextBoxRobotDistanceJ2.Size = new System.Drawing.Size(105, 32);
            this.CTextBoxRobotDistanceJ2.TabIndex = 32;
            this.CTextBoxRobotDistanceJ2.Text = "0";
            // 
            // customLabel12
            // 
            this.customLabel12.AutoSize = true;
            this.customLabel12.Font = new System.Drawing.Font("微软雅黑", 12.5F);
            this.customLabel12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(210)))), ((int)(((byte)(210)))));
            this.customLabel12.Location = new System.Drawing.Point(11, 397);
            this.customLabel12.Name = "customLabel12";
            this.customLabel12.Size = new System.Drawing.Size(44, 23);
            this.customLabel12.TabIndex = 31;
            this.customLabel12.Text = "J2：";
            // 
            // CButtonRobotDistanceJ1Sub
            // 
            this.CButtonRobotDistanceJ1Sub.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(74)))), ((int)(((byte)(74)))));
            this.CButtonRobotDistanceJ1Sub.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CButtonRobotDistanceJ1Sub.Font = new System.Drawing.Font("微软雅黑", 12.5F);
            this.CButtonRobotDistanceJ1Sub.ForeColor = System.Drawing.Color.Transparent;
            this.CButtonRobotDistanceJ1Sub.Location = new System.Drawing.Point(271, 353);
            this.CButtonRobotDistanceJ1Sub.Name = "CButtonRobotDistanceJ1Sub";
            this.CButtonRobotDistanceJ1Sub.Size = new System.Drawing.Size(90, 36);
            this.CButtonRobotDistanceJ1Sub.TabIndex = 30;
            this.CButtonRobotDistanceJ1Sub.Text = "J1 -";
            this.CButtonRobotDistanceJ1Sub.UseVisualStyleBackColor = false;
            this.CButtonRobotDistanceJ1Sub.MouseDown += new System.Windows.Forms.MouseEventHandler(this.CButtonRobotDistanceJ1Sub_MouseDown);
            this.CButtonRobotDistanceJ1Sub.MouseUp += new System.Windows.Forms.MouseEventHandler(this.CButtonRobotDistanceJ1Sub_MouseUp);
            // 
            // CButtonRobotDistanceJ1Add
            // 
            this.CButtonRobotDistanceJ1Add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(74)))), ((int)(((byte)(74)))));
            this.CButtonRobotDistanceJ1Add.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CButtonRobotDistanceJ1Add.Font = new System.Drawing.Font("微软雅黑", 12.5F);
            this.CButtonRobotDistanceJ1Add.ForeColor = System.Drawing.Color.Transparent;
            this.CButtonRobotDistanceJ1Add.Location = new System.Drawing.Point(175, 353);
            this.CButtonRobotDistanceJ1Add.Name = "CButtonRobotDistanceJ1Add";
            this.CButtonRobotDistanceJ1Add.Size = new System.Drawing.Size(90, 36);
            this.CButtonRobotDistanceJ1Add.TabIndex = 29;
            this.CButtonRobotDistanceJ1Add.Text = "J1 +";
            this.CButtonRobotDistanceJ1Add.UseVisualStyleBackColor = false;
            this.CButtonRobotDistanceJ1Add.MouseDown += new System.Windows.Forms.MouseEventHandler(this.CButtonRobotDistanceJ1Add_MouseDown);
            this.CButtonRobotDistanceJ1Add.MouseUp += new System.Windows.Forms.MouseEventHandler(this.CButtonRobotDistanceJ1Add_MouseUp);
            // 
            // CTextBoxRobotDistanceJ1
            // 
            this.CTextBoxRobotDistanceJ1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.CTextBoxRobotDistanceJ1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CTextBoxRobotDistanceJ1.Font = new System.Drawing.Font("微软雅黑", 12.5F);
            this.CTextBoxRobotDistanceJ1.ForeColor = System.Drawing.Color.White;
            this.CTextBoxRobotDistanceJ1.Location = new System.Drawing.Point(59, 356);
            this.CTextBoxRobotDistanceJ1.Multiline = true;
            this.CTextBoxRobotDistanceJ1.Name = "CTextBoxRobotDistanceJ1";
            this.CTextBoxRobotDistanceJ1.Size = new System.Drawing.Size(105, 32);
            this.CTextBoxRobotDistanceJ1.TabIndex = 28;
            this.CTextBoxRobotDistanceJ1.Text = "0";
            // 
            // customLabel11
            // 
            this.customLabel11.AutoSize = true;
            this.customLabel11.Font = new System.Drawing.Font("微软雅黑", 12.5F);
            this.customLabel11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(210)))), ((int)(((byte)(210)))));
            this.customLabel11.Location = new System.Drawing.Point(11, 360);
            this.customLabel11.Name = "customLabel11";
            this.customLabel11.Size = new System.Drawing.Size(44, 23);
            this.customLabel11.TabIndex = 27;
            this.customLabel11.Text = "J1：";
            // 
            // radioButtonRobotDeviceContinuous
            // 
            this.radioButtonRobotDeviceContinuous.AutoSize = true;
            this.radioButtonRobotDeviceContinuous.Location = new System.Drawing.Point(279, 281);
            this.radioButtonRobotDeviceContinuous.Name = "radioButtonRobotDeviceContinuous";
            this.radioButtonRobotDeviceContinuous.Size = new System.Drawing.Size(60, 25);
            this.radioButtonRobotDeviceContinuous.TabIndex = 26;
            this.radioButtonRobotDeviceContinuous.TabStop = true;
            this.radioButtonRobotDeviceContinuous.Text = "连续";
            this.radioButtonRobotDeviceContinuous.UseVisualStyleBackColor = true;
            this.radioButtonRobotDeviceContinuous.CheckedChanged += new System.EventHandler(this.radioButtonRobotDeviceContinuous_CheckedChanged);
            // 
            // radioButtonRobotDeviceJog
            // 
            this.radioButtonRobotDeviceJog.AutoSize = true;
            this.radioButtonRobotDeviceJog.Location = new System.Drawing.Point(280, 225);
            this.radioButtonRobotDeviceJog.Name = "radioButtonRobotDeviceJog";
            this.radioButtonRobotDeviceJog.Size = new System.Drawing.Size(59, 25);
            this.radioButtonRobotDeviceJog.TabIndex = 25;
            this.radioButtonRobotDeviceJog.TabStop = true;
            this.radioButtonRobotDeviceJog.Text = "JOG";
            this.radioButtonRobotDeviceJog.UseVisualStyleBackColor = true;
            this.radioButtonRobotDeviceJog.CheckedChanged += new System.EventHandler(this.radioButtonRobotDeviceJog_CheckedChanged);
            // 
            // customLabel9
            // 
            this.customLabel9.AutoSize = true;
            this.customLabel9.Font = new System.Drawing.Font("微软雅黑", 12.5F);
            this.customLabel9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(210)))), ((int)(((byte)(210)))));
            this.customLabel9.Location = new System.Drawing.Point(205, 225);
            this.customLabel9.Name = "customLabel9";
            this.customLabel9.Size = new System.Drawing.Size(25, 23);
            this.customLabel9.TabIndex = 23;
            this.customLabel9.Text = "%";
            this.customLabel9.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // CTextBoxRobotMoveSpeed
            // 
            this.CTextBoxRobotMoveSpeed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.CTextBoxRobotMoveSpeed.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CTextBoxRobotMoveSpeed.Font = new System.Drawing.Font("微软雅黑", 12.5F);
            this.CTextBoxRobotMoveSpeed.ForeColor = System.Drawing.Color.White;
            this.CTextBoxRobotMoveSpeed.Location = new System.Drawing.Point(113, 223);
            this.CTextBoxRobotMoveSpeed.Multiline = true;
            this.CTextBoxRobotMoveSpeed.Name = "CTextBoxRobotMoveSpeed";
            this.CTextBoxRobotMoveSpeed.Size = new System.Drawing.Size(90, 32);
            this.CTextBoxRobotMoveSpeed.TabIndex = 22;
            this.CTextBoxRobotMoveSpeed.Text = "30";
            this.CTextBoxRobotMoveSpeed.TextChanged += new System.EventHandler(this.CTextBoxRobotMoveSpeed_TextChanged);
            // 
            // customLabel8
            // 
            this.customLabel8.AutoSize = true;
            this.customLabel8.Font = new System.Drawing.Font("微软雅黑", 12.5F);
            this.customLabel8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(210)))), ((int)(((byte)(210)))));
            this.customLabel8.Location = new System.Drawing.Point(20, 225);
            this.customLabel8.Name = "customLabel8";
            this.customLabel8.Size = new System.Drawing.Size(95, 23);
            this.customLabel8.TabIndex = 21;
            this.customLabel8.Text = "移动速度：";
            // 
            // customLabel7
            // 
            this.customLabel7.AutoSize = true;
            this.customLabel7.Font = new System.Drawing.Font("微软雅黑", 12.5F);
            this.customLabel7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(210)))), ((int)(((byte)(210)))));
            this.customLabel7.Location = new System.Drawing.Point(209, 303);
            this.customLabel7.Name = "customLabel7";
            this.customLabel7.Size = new System.Drawing.Size(36, 23);
            this.customLabel7.TabIndex = 20;
            this.customLabel7.Text = "um";
            this.customLabel7.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // CTextBoxJogDistanceUm
            // 
            this.CTextBoxJogDistanceUm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.CTextBoxJogDistanceUm.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CTextBoxJogDistanceUm.Font = new System.Drawing.Font("微软雅黑", 12.5F);
            this.CTextBoxJogDistanceUm.ForeColor = System.Drawing.Color.White;
            this.CTextBoxJogDistanceUm.Location = new System.Drawing.Point(113, 301);
            this.CTextBoxJogDistanceUm.Multiline = true;
            this.CTextBoxJogDistanceUm.Name = "CTextBoxJogDistanceUm";
            this.CTextBoxJogDistanceUm.Size = new System.Drawing.Size(90, 32);
            this.CTextBoxJogDistanceUm.TabIndex = 19;
            this.CTextBoxJogDistanceUm.Text = "1000";
            this.CTextBoxJogDistanceUm.TextChanged += new System.EventHandler(this.CTextBoxJogDistanceUm_TextChanged);
            // 
            // customLabel6
            // 
            this.customLabel6.AutoSize = true;
            this.customLabel6.Font = new System.Drawing.Font("微软雅黑", 12.5F);
            this.customLabel6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(210)))), ((int)(((byte)(210)))));
            this.customLabel6.Location = new System.Drawing.Point(209, 264);
            this.customLabel6.Name = "customLabel6";
            this.customLabel6.Size = new System.Drawing.Size(43, 23);
            this.customLabel6.TabIndex = 18;
            this.customLabel6.Text = "PPU";
            this.customLabel6.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // CTextBoxJogDistance
            // 
            this.CTextBoxJogDistance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.CTextBoxJogDistance.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CTextBoxJogDistance.Font = new System.Drawing.Font("微软雅黑", 12.5F);
            this.CTextBoxJogDistance.ForeColor = System.Drawing.Color.White;
            this.CTextBoxJogDistance.Location = new System.Drawing.Point(113, 262);
            this.CTextBoxJogDistance.Multiline = true;
            this.CTextBoxJogDistance.Name = "CTextBoxJogDistance";
            this.CTextBoxJogDistance.Size = new System.Drawing.Size(90, 32);
            this.CTextBoxJogDistance.TabIndex = 17;
            this.CTextBoxJogDistance.Text = "1000";
            this.CTextBoxJogDistance.TextChanged += new System.EventHandler(this.CTextBoxJogDistance_TextChanged);
            // 
            // customLabel5
            // 
            this.customLabel5.AutoSize = true;
            this.customLabel5.Font = new System.Drawing.Font("微软雅黑", 12.5F);
            this.customLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(210)))), ((int)(((byte)(210)))));
            this.customLabel5.Location = new System.Drawing.Point(20, 260);
            this.customLabel5.Name = "customLabel5";
            this.customLabel5.Size = new System.Drawing.Size(95, 23);
            this.customLabel5.TabIndex = 16;
            this.customLabel5.Text = "Jog 距离：";
            // 
            // pictureBoxRobotMove
            // 
            this.pictureBoxRobotMove.Image = global::RobotWorkstation.Properties.Resources.SmallDarkGreen;
            this.pictureBoxRobotMove.Location = new System.Drawing.Point(86, 185);
            this.pictureBoxRobotMove.Name = "pictureBoxRobotMove";
            this.pictureBoxRobotMove.Size = new System.Drawing.Size(22, 22);
            this.pictureBoxRobotMove.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxRobotMove.TabIndex = 15;
            this.pictureBoxRobotMove.TabStop = false;
            // 
            // customLabel4
            // 
            this.customLabel4.AutoSize = true;
            this.customLabel4.Font = new System.Drawing.Font("微软雅黑", 12.5F);
            this.customLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(210)))), ((int)(((byte)(210)))));
            this.customLabel4.Location = new System.Drawing.Point(20, 183);
            this.customLabel4.Name = "customLabel4";
            this.customLabel4.Size = new System.Drawing.Size(61, 23);
            this.customLabel4.TabIndex = 14;
            this.customLabel4.Text = "移动：";
            // 
            // pictureBoxTemperature
            // 
            this.pictureBoxTemperature.Image = global::RobotWorkstation.Properties.Resources.SmallDarkGreen;
            this.pictureBoxTemperature.Location = new System.Drawing.Point(86, 148);
            this.pictureBoxTemperature.Name = "pictureBoxTemperature";
            this.pictureBoxTemperature.Size = new System.Drawing.Size(22, 22);
            this.pictureBoxTemperature.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxTemperature.TabIndex = 13;
            this.pictureBoxTemperature.TabStop = false;
            // 
            // customLabel3
            // 
            this.customLabel3.AutoSize = true;
            this.customLabel3.Font = new System.Drawing.Font("微软雅黑", 12.5F);
            this.customLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(210)))), ((int)(((byte)(210)))));
            this.customLabel3.Location = new System.Drawing.Point(20, 146);
            this.customLabel3.Name = "customLabel3";
            this.customLabel3.Size = new System.Drawing.Size(61, 23);
            this.customLabel3.TabIndex = 12;
            this.customLabel3.Text = "温度：";
            // 
            // CButtonRobotExecStop
            // 
            this.CButtonRobotExecStop.BackColor = System.Drawing.Color.Red;
            this.CButtonRobotExecStop.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CButtonRobotExecStop.Font = new System.Drawing.Font("微软雅黑", 12.5F);
            this.CButtonRobotExecStop.ForeColor = System.Drawing.Color.Transparent;
            this.CButtonRobotExecStop.Location = new System.Drawing.Point(258, 104);
            this.CButtonRobotExecStop.Name = "CButtonRobotExecStop";
            this.CButtonRobotExecStop.Size = new System.Drawing.Size(60, 36);
            this.CButtonRobotExecStop.TabIndex = 11;
            this.CButtonRobotExecStop.Text = "停止";
            this.CButtonRobotExecStop.UseVisualStyleBackColor = false;
            this.CButtonRobotExecStop.Click += new System.EventHandler(this.CButtonRobotExecStop_Click);
            // 
            // CButtonRobotExecPause
            // 
            this.CButtonRobotExecPause.BackColor = System.Drawing.Color.Orange;
            this.CButtonRobotExecPause.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CButtonRobotExecPause.Font = new System.Drawing.Font("微软雅黑", 12.5F);
            this.CButtonRobotExecPause.ForeColor = System.Drawing.Color.Transparent;
            this.CButtonRobotExecPause.Location = new System.Drawing.Point(192, 104);
            this.CButtonRobotExecPause.Name = "CButtonRobotExecPause";
            this.CButtonRobotExecPause.Size = new System.Drawing.Size(60, 36);
            this.CButtonRobotExecPause.TabIndex = 10;
            this.CButtonRobotExecPause.Text = "暂停";
            this.CButtonRobotExecPause.UseVisualStyleBackColor = false;
            this.CButtonRobotExecPause.Click += new System.EventHandler(this.CButtonRobotExecPause_Click);
            // 
            // CButtonRobotExecRun
            // 
            this.CButtonRobotExecRun.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(148)))), ((int)(((byte)(8)))));
            this.CButtonRobotExecRun.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CButtonRobotExecRun.Font = new System.Drawing.Font("微软雅黑", 12.5F);
            this.CButtonRobotExecRun.ForeColor = System.Drawing.Color.Transparent;
            this.CButtonRobotExecRun.Location = new System.Drawing.Point(128, 104);
            this.CButtonRobotExecRun.Name = "CButtonRobotExecRun";
            this.CButtonRobotExecRun.Size = new System.Drawing.Size(60, 36);
            this.CButtonRobotExecRun.TabIndex = 9;
            this.CButtonRobotExecRun.Text = "运行";
            this.CButtonRobotExecRun.UseVisualStyleBackColor = false;
            this.CButtonRobotExecRun.Click += new System.EventHandler(this.CButtonRobotExecRun_Click);
            // 
            // pictureBoxRobotExecut
            // 
            this.pictureBoxRobotExecut.Image = global::RobotWorkstation.Properties.Resources.SmallDarkGreen;
            this.pictureBoxRobotExecut.Location = new System.Drawing.Point(86, 111);
            this.pictureBoxRobotExecut.Name = "pictureBoxRobotExecut";
            this.pictureBoxRobotExecut.Size = new System.Drawing.Size(22, 22);
            this.pictureBoxRobotExecut.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxRobotExecut.TabIndex = 8;
            this.pictureBoxRobotExecut.TabStop = false;
            // 
            // customLabel2
            // 
            this.customLabel2.AutoSize = true;
            this.customLabel2.Font = new System.Drawing.Font("微软雅黑", 12.5F);
            this.customLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(210)))), ((int)(((byte)(210)))));
            this.customLabel2.Location = new System.Drawing.Point(20, 109);
            this.customLabel2.Name = "customLabel2";
            this.customLabel2.Size = new System.Drawing.Size(61, 23);
            this.customLabel2.TabIndex = 7;
            this.customLabel2.Text = "脚本：";
            // 
            // CButtonReset
            // 
            this.CButtonReset.BackColor = System.Drawing.Color.SteelBlue;
            this.CButtonReset.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CButtonReset.Font = new System.Drawing.Font("微软雅黑", 12.5F);
            this.CButtonReset.ForeColor = System.Drawing.Color.Transparent;
            this.CButtonReset.Location = new System.Drawing.Point(128, 66);
            this.CButtonReset.Name = "CButtonReset";
            this.CButtonReset.Size = new System.Drawing.Size(90, 36);
            this.CButtonReset.TabIndex = 6;
            this.CButtonReset.Text = "复位";
            this.CButtonReset.UseVisualStyleBackColor = false;
            this.CButtonReset.Click += new System.EventHandler(this.CButtonReset_Click);
            // 
            // pictureBoxRobotAlarm
            // 
            this.pictureBoxRobotAlarm.Image = global::RobotWorkstation.Properties.Resources.SmallDarkRed;
            this.pictureBoxRobotAlarm.Location = new System.Drawing.Point(86, 74);
            this.pictureBoxRobotAlarm.Name = "pictureBoxRobotAlarm";
            this.pictureBoxRobotAlarm.Size = new System.Drawing.Size(22, 22);
            this.pictureBoxRobotAlarm.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxRobotAlarm.TabIndex = 5;
            this.pictureBoxRobotAlarm.TabStop = false;
            // 
            // customLabel1
            // 
            this.customLabel1.AutoSize = true;
            this.customLabel1.Font = new System.Drawing.Font("微软雅黑", 12.5F);
            this.customLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(210)))), ((int)(((byte)(210)))));
            this.customLabel1.Location = new System.Drawing.Point(20, 72);
            this.customLabel1.Name = "customLabel1";
            this.customLabel1.Size = new System.Drawing.Size(61, 23);
            this.customLabel1.TabIndex = 4;
            this.customLabel1.Text = "警告：";
            // 
            // CButtonServoOff
            // 
            this.CButtonServoOff.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(74)))), ((int)(((byte)(74)))));
            this.CButtonServoOff.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CButtonServoOff.Font = new System.Drawing.Font("微软雅黑", 12.5F);
            this.CButtonServoOff.ForeColor = System.Drawing.Color.Transparent;
            this.CButtonServoOff.Location = new System.Drawing.Point(228, 28);
            this.CButtonServoOff.Name = "CButtonServoOff";
            this.CButtonServoOff.Size = new System.Drawing.Size(90, 36);
            this.CButtonServoOff.TabIndex = 3;
            this.CButtonServoOff.Text = "伺服关";
            this.CButtonServoOff.UseVisualStyleBackColor = false;
            this.CButtonServoOff.Click += new System.EventHandler(this.CButtonServoOff_Click);
            // 
            // CBttonServoOn
            // 
            this.CBttonServoOn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(74)))), ((int)(((byte)(74)))));
            this.CBttonServoOn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CBttonServoOn.Font = new System.Drawing.Font("微软雅黑", 12.5F);
            this.CBttonServoOn.ForeColor = System.Drawing.Color.White;
            this.CBttonServoOn.Location = new System.Drawing.Point(128, 28);
            this.CBttonServoOn.Name = "CBttonServoOn";
            this.CBttonServoOn.Size = new System.Drawing.Size(90, 36);
            this.CBttonServoOn.TabIndex = 2;
            this.CBttonServoOn.Text = "伺服开";
            this.CBttonServoOn.UseVisualStyleBackColor = false;
            this.CBttonServoOn.Click += new System.EventHandler(this.CBttonServoOn_Click);
            // 
            // pictureBoxServo
            // 
            this.pictureBoxServo.Image = global::RobotWorkstation.Properties.Resources.SmallDarkGreen;
            this.pictureBoxServo.Location = new System.Drawing.Point(86, 37);
            this.pictureBoxServo.Name = "pictureBoxServo";
            this.pictureBoxServo.Size = new System.Drawing.Size(22, 22);
            this.pictureBoxServo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxServo.TabIndex = 1;
            this.pictureBoxServo.TabStop = false;
            // 
            // tabPageOthers
            // 
            this.tabPageOthers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.tabPageOthers.Controls.Add(this.customGroupBox13);
            this.tabPageOthers.Controls.Add(this.customGroupBox12);
            this.tabPageOthers.Controls.Add(this.customGroupBox11);
            this.tabPageOthers.Controls.Add(this.customGroupBox10);
            this.tabPageOthers.Controls.Add(this.customGroupBox7);
            this.tabPageOthers.ForeColor = System.Drawing.Color.White;
            this.tabPageOthers.Location = new System.Drawing.Point(0, 29);
            this.tabPageOthers.Name = "tabPageOthers";
            this.tabPageOthers.Size = new System.Drawing.Size(1248, 789);
            this.tabPageOthers.TabIndex = 3;
            this.tabPageOthers.Text = "其他";
            // 
            // customGroupBox13
            // 
            this.customGroupBox13.Controls.Add(this.PicKeyReset);
            this.customGroupBox13.Controls.Add(this.PicKeyStop);
            this.customGroupBox13.Controls.Add(this.PicKeyPause);
            this.customGroupBox13.Controls.Add(this.PicKeyRun);
            this.customGroupBox13.Controls.Add(this.customLabel52);
            this.customGroupBox13.Controls.Add(this.customLabel51);
            this.customGroupBox13.Controls.Add(this.customLabel50);
            this.customGroupBox13.Controls.Add(this.customLabel49);
            this.customGroupBox13.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.customGroupBox13.Location = new System.Drawing.Point(1005, 154);
            this.customGroupBox13.Name = "customGroupBox13";
            this.customGroupBox13.Size = new System.Drawing.Size(132, 187);
            this.customGroupBox13.TabIndex = 19;
            this.customGroupBox13.TabStop = false;
            this.customGroupBox13.Text = "按键";
            // 
            // PicKeyReset
            // 
            this.PicKeyReset.Image = global::RobotWorkstation.Properties.Resources.SmallDarkGreen;
            this.PicKeyReset.Location = new System.Drawing.Point(87, 147);
            this.PicKeyReset.Name = "PicKeyReset";
            this.PicKeyReset.Size = new System.Drawing.Size(22, 22);
            this.PicKeyReset.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PicKeyReset.TabIndex = 17;
            this.PicKeyReset.TabStop = false;
            // 
            // PicKeyStop
            // 
            this.PicKeyStop.Image = global::RobotWorkstation.Properties.Resources.SmallDarkGreen;
            this.PicKeyStop.Location = new System.Drawing.Point(87, 109);
            this.PicKeyStop.Name = "PicKeyStop";
            this.PicKeyStop.Size = new System.Drawing.Size(22, 22);
            this.PicKeyStop.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PicKeyStop.TabIndex = 16;
            this.PicKeyStop.TabStop = false;
            // 
            // PicKeyPause
            // 
            this.PicKeyPause.Image = global::RobotWorkstation.Properties.Resources.SmallDarkGreen;
            this.PicKeyPause.Location = new System.Drawing.Point(87, 72);
            this.PicKeyPause.Name = "PicKeyPause";
            this.PicKeyPause.Size = new System.Drawing.Size(22, 22);
            this.PicKeyPause.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PicKeyPause.TabIndex = 15;
            this.PicKeyPause.TabStop = false;
            // 
            // PicKeyRun
            // 
            this.PicKeyRun.Image = global::RobotWorkstation.Properties.Resources.SmallDarkGreen;
            this.PicKeyRun.Location = new System.Drawing.Point(87, 33);
            this.PicKeyRun.Name = "PicKeyRun";
            this.PicKeyRun.Size = new System.Drawing.Size(22, 22);
            this.PicKeyRun.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PicKeyRun.TabIndex = 14;
            this.PicKeyRun.TabStop = false;
            // 
            // customLabel52
            // 
            this.customLabel52.AutoSize = true;
            this.customLabel52.Font = new System.Drawing.Font("微软雅黑", 12.5F);
            this.customLabel52.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(210)))), ((int)(((byte)(210)))));
            this.customLabel52.Location = new System.Drawing.Point(9, 147);
            this.customLabel52.Name = "customLabel52";
            this.customLabel52.Size = new System.Drawing.Size(61, 23);
            this.customLabel52.TabIndex = 3;
            this.customLabel52.Text = "复位：";
            // 
            // customLabel51
            // 
            this.customLabel51.AutoSize = true;
            this.customLabel51.Font = new System.Drawing.Font("微软雅黑", 12.5F);
            this.customLabel51.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(210)))), ((int)(((byte)(210)))));
            this.customLabel51.Location = new System.Drawing.Point(9, 109);
            this.customLabel51.Name = "customLabel51";
            this.customLabel51.Size = new System.Drawing.Size(61, 23);
            this.customLabel51.TabIndex = 2;
            this.customLabel51.Text = "停止：";
            // 
            // customLabel50
            // 
            this.customLabel50.AutoSize = true;
            this.customLabel50.Font = new System.Drawing.Font("微软雅黑", 12.5F);
            this.customLabel50.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(210)))), ((int)(((byte)(210)))));
            this.customLabel50.Location = new System.Drawing.Point(9, 71);
            this.customLabel50.Name = "customLabel50";
            this.customLabel50.Size = new System.Drawing.Size(61, 23);
            this.customLabel50.TabIndex = 1;
            this.customLabel50.Text = "暂停：";
            // 
            // customLabel49
            // 
            this.customLabel49.AutoSize = true;
            this.customLabel49.Font = new System.Drawing.Font("微软雅黑", 12.5F);
            this.customLabel49.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(210)))), ((int)(((byte)(210)))));
            this.customLabel49.Location = new System.Drawing.Point(9, 33);
            this.customLabel49.Name = "customLabel49";
            this.customLabel49.Size = new System.Drawing.Size(61, 23);
            this.customLabel49.TabIndex = 0;
            this.customLabel49.Text = "运行：";
            // 
            // customGroupBox12
            // 
            this.customGroupBox12.Controls.Add(this.PicBoxEmptySalverDownArrive);
            this.customGroupBox12.Controls.Add(this.PicBoxEmptySalverUpArrive);
            this.customGroupBox12.Controls.Add(this.CButtonIoEmptyPlateUp);
            this.customGroupBox12.Controls.Add(this.CButtonIoEmptyPlateDown);
            this.customGroupBox12.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.customGroupBox12.Location = new System.Drawing.Point(631, 154);
            this.customGroupBox12.Name = "customGroupBox12";
            this.customGroupBox12.Size = new System.Drawing.Size(358, 187);
            this.customGroupBox12.TabIndex = 18;
            this.customGroupBox12.TabStop = false;
            this.customGroupBox12.Text = "气缸";
            // 
            // PicBoxEmptyPlateDownArrive
            // 
            this.PicBoxEmptySalverDownArrive.Image = global::RobotWorkstation.Properties.Resources.SmallDarkGreen;
            this.PicBoxEmptySalverDownArrive.Location = new System.Drawing.Point(313, 45);
            this.PicBoxEmptySalverDownArrive.Name = "PicBoxEmptyPlateDownArrive";
            this.PicBoxEmptySalverDownArrive.Size = new System.Drawing.Size(22, 22);
            this.PicBoxEmptySalverDownArrive.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PicBoxEmptySalverDownArrive.TabIndex = 14;
            this.PicBoxEmptySalverDownArrive.TabStop = false;
            // 
            // PicBoxEmptyPlateUpArrive
            // 
            this.PicBoxEmptySalverUpArrive.Image = global::RobotWorkstation.Properties.Resources.SmallDarkGreen;
            this.PicBoxEmptySalverUpArrive.Location = new System.Drawing.Point(125, 45);
            this.PicBoxEmptySalverUpArrive.Name = "PicBoxEmptyPlateUpArrive";
            this.PicBoxEmptySalverUpArrive.Size = new System.Drawing.Size(22, 22);
            this.PicBoxEmptySalverUpArrive.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PicBoxEmptySalverUpArrive.TabIndex = 13;
            this.PicBoxEmptySalverUpArrive.TabStop = false;
            // 
            // CButtonIoEmptyPlateUp
            // 
            this.CButtonIoEmptyPlateUp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(74)))), ((int)(((byte)(74)))));
            this.CButtonIoEmptyPlateUp.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CButtonIoEmptyPlateUp.Font = new System.Drawing.Font("微软雅黑", 12.5F);
            this.CButtonIoEmptyPlateUp.ForeColor = System.Drawing.Color.Transparent;
            this.CButtonIoEmptyPlateUp.Location = new System.Drawing.Point(14, 38);
            this.CButtonIoEmptyPlateUp.Name = "CButtonIoEmptyPlateUp";
            this.CButtonIoEmptyPlateUp.Size = new System.Drawing.Size(105, 36);
            this.CButtonIoEmptyPlateUp.TabIndex = 11;
            this.CButtonIoEmptyPlateUp.Text = "空盘气缸升";
            this.CButtonIoEmptyPlateUp.UseVisualStyleBackColor = false;
            this.CButtonIoEmptyPlateUp.Click += new System.EventHandler(this.CButtonIoEmptyPlateUp_Click_1);
            // 
            // CButtonIoEmptyPlateDown
            // 
            this.CButtonIoEmptyPlateDown.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(74)))), ((int)(((byte)(74)))));
            this.CButtonIoEmptyPlateDown.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CButtonIoEmptyPlateDown.Font = new System.Drawing.Font("微软雅黑", 12.5F);
            this.CButtonIoEmptyPlateDown.ForeColor = System.Drawing.Color.Transparent;
            this.CButtonIoEmptyPlateDown.Location = new System.Drawing.Point(202, 38);
            this.CButtonIoEmptyPlateDown.Name = "CButtonIoEmptyPlateDown";
            this.CButtonIoEmptyPlateDown.Size = new System.Drawing.Size(105, 36);
            this.CButtonIoEmptyPlateDown.TabIndex = 12;
            this.CButtonIoEmptyPlateDown.Text = "空盘气缸降";
            this.CButtonIoEmptyPlateDown.UseVisualStyleBackColor = false;
            this.CButtonIoEmptyPlateDown.Click += new System.EventHandler(this.CButtonIoEmptyPlateDown_Click_1);
            // 
            // customGroupBox11
            // 
            this.customGroupBox11.Controls.Add(this.BtnBeepOff);
            this.customGroupBox11.Controls.Add(this.BtnBeepOn);
            this.customGroupBox11.Controls.Add(this.BtnLampBlueOff);
            this.customGroupBox11.Controls.Add(this.BtnLampBlueOn);
            this.customGroupBox11.Controls.Add(this.BtnLampGreenOff);
            this.customGroupBox11.Controls.Add(this.BtnLampGreenOn);
            this.customGroupBox11.Controls.Add(this.BtnLampOrangeOff);
            this.customGroupBox11.Controls.Add(this.BtnLampOrangeOn);
            this.customGroupBox11.Controls.Add(this.BtnLampRedOff);
            this.customGroupBox11.Controls.Add(this.BtnLampRedOn);
            this.customGroupBox11.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.customGroupBox11.Location = new System.Drawing.Point(629, 3);
            this.customGroupBox11.Name = "customGroupBox11";
            this.customGroupBox11.Size = new System.Drawing.Size(508, 145);
            this.customGroupBox11.TabIndex = 17;
            this.customGroupBox11.TabStop = false;
            this.customGroupBox11.Text = "塔灯";
            // 
            // BtnBeepOff
            // 
            this.BtnBeepOff.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(74)))), ((int)(((byte)(74)))));
            this.BtnBeepOff.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnBeepOff.Font = new System.Drawing.Font("微软雅黑", 12.5F);
            this.BtnBeepOff.ForeColor = System.Drawing.Color.Transparent;
            this.BtnBeepOff.Location = new System.Drawing.Point(400, 80);
            this.BtnBeepOff.Name = "BtnBeepOff";
            this.BtnBeepOff.Size = new System.Drawing.Size(90, 36);
            this.BtnBeepOff.TabIndex = 9;
            this.BtnBeepOff.Text = "蜂鸣关";
            this.BtnBeepOff.UseVisualStyleBackColor = false;
            this.BtnBeepOff.Click += new System.EventHandler(this.BtnBeepOff_Click);
            // 
            // BtnBeepOn
            // 
            this.BtnBeepOn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(74)))), ((int)(((byte)(74)))));
            this.BtnBeepOn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnBeepOn.Font = new System.Drawing.Font("微软雅黑", 12.5F);
            this.BtnBeepOn.ForeColor = System.Drawing.Color.Transparent;
            this.BtnBeepOn.Location = new System.Drawing.Point(400, 36);
            this.BtnBeepOn.Name = "BtnBeepOn";
            this.BtnBeepOn.Size = new System.Drawing.Size(90, 36);
            this.BtnBeepOn.TabIndex = 8;
            this.BtnBeepOn.Text = "蜂鸣开";
            this.BtnBeepOn.UseVisualStyleBackColor = false;
            this.BtnBeepOn.Click += new System.EventHandler(this.BtnBeepOn_Click);
            // 
            // BtnLampBlueOff
            // 
            this.BtnLampBlueOff.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(96)))));
            this.BtnLampBlueOff.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnLampBlueOff.Font = new System.Drawing.Font("微软雅黑", 12.5F);
            this.BtnLampBlueOff.ForeColor = System.Drawing.Color.Transparent;
            this.BtnLampBlueOff.Location = new System.Drawing.Point(304, 80);
            this.BtnLampBlueOff.Name = "BtnLampBlueOff";
            this.BtnLampBlueOff.Size = new System.Drawing.Size(90, 36);
            this.BtnLampBlueOff.TabIndex = 7;
            this.BtnLampBlueOff.Text = "关";
            this.BtnLampBlueOff.UseVisualStyleBackColor = false;
            this.BtnLampBlueOff.Click += new System.EventHandler(this.BtnLampBlueOff_Click);
            // 
            // BtnLampBlueOn
            // 
            this.BtnLampBlueOn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.BtnLampBlueOn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnLampBlueOn.Font = new System.Drawing.Font("微软雅黑", 12.5F);
            this.BtnLampBlueOn.ForeColor = System.Drawing.Color.Transparent;
            this.BtnLampBlueOn.Location = new System.Drawing.Point(304, 36);
            this.BtnLampBlueOn.Name = "BtnLampBlueOn";
            this.BtnLampBlueOn.Size = new System.Drawing.Size(90, 36);
            this.BtnLampBlueOn.TabIndex = 6;
            this.BtnLampBlueOn.Text = "开";
            this.BtnLampBlueOn.UseVisualStyleBackColor = false;
            this.BtnLampBlueOn.Click += new System.EventHandler(this.BtnLampBlueOn_Click);
            // 
            // BtnLampGreenOff
            // 
            this.BtnLampGreenOff.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.BtnLampGreenOff.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnLampGreenOff.Font = new System.Drawing.Font("微软雅黑", 12.5F);
            this.BtnLampGreenOff.ForeColor = System.Drawing.Color.Transparent;
            this.BtnLampGreenOff.Location = new System.Drawing.Point(208, 80);
            this.BtnLampGreenOff.Name = "BtnLampGreenOff";
            this.BtnLampGreenOff.Size = new System.Drawing.Size(90, 36);
            this.BtnLampGreenOff.TabIndex = 5;
            this.BtnLampGreenOff.Text = "关";
            this.BtnLampGreenOff.UseVisualStyleBackColor = false;
            this.BtnLampGreenOff.Click += new System.EventHandler(this.BtnLampGreenOff_Click);
            // 
            // BtnLampGreenOn
            // 
            this.BtnLampGreenOn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.BtnLampGreenOn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnLampGreenOn.Font = new System.Drawing.Font("微软雅黑", 12.5F);
            this.BtnLampGreenOn.ForeColor = System.Drawing.Color.Transparent;
            this.BtnLampGreenOn.Location = new System.Drawing.Point(208, 36);
            this.BtnLampGreenOn.Name = "BtnLampGreenOn";
            this.BtnLampGreenOn.Size = new System.Drawing.Size(90, 36);
            this.BtnLampGreenOn.TabIndex = 4;
            this.BtnLampGreenOn.Text = "开";
            this.BtnLampGreenOn.UseVisualStyleBackColor = false;
            this.BtnLampGreenOn.Click += new System.EventHandler(this.BtnLampGreenOn_Click);
            // 
            // BtnLampOrangeOff
            // 
            this.BtnLampOrangeOff.BackColor = System.Drawing.Color.SaddleBrown;
            this.BtnLampOrangeOff.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnLampOrangeOff.Font = new System.Drawing.Font("微软雅黑", 12.5F);
            this.BtnLampOrangeOff.ForeColor = System.Drawing.Color.Transparent;
            this.BtnLampOrangeOff.Location = new System.Drawing.Point(112, 80);
            this.BtnLampOrangeOff.Name = "BtnLampOrangeOff";
            this.BtnLampOrangeOff.Size = new System.Drawing.Size(90, 36);
            this.BtnLampOrangeOff.TabIndex = 3;
            this.BtnLampOrangeOff.Text = "关";
            this.BtnLampOrangeOff.UseVisualStyleBackColor = false;
            this.BtnLampOrangeOff.Click += new System.EventHandler(this.BtnLampOrangeOff_Click);
            // 
            // BtnLampOrangeOn
            // 
            this.BtnLampOrangeOn.BackColor = System.Drawing.Color.DarkOrange;
            this.BtnLampOrangeOn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnLampOrangeOn.Font = new System.Drawing.Font("微软雅黑", 12.5F);
            this.BtnLampOrangeOn.ForeColor = System.Drawing.Color.Transparent;
            this.BtnLampOrangeOn.Location = new System.Drawing.Point(112, 36);
            this.BtnLampOrangeOn.Name = "BtnLampOrangeOn";
            this.BtnLampOrangeOn.Size = new System.Drawing.Size(90, 36);
            this.BtnLampOrangeOn.TabIndex = 2;
            this.BtnLampOrangeOn.Text = "开";
            this.BtnLampOrangeOn.UseVisualStyleBackColor = false;
            this.BtnLampOrangeOn.Click += new System.EventHandler(this.BtnLampOrangeOn_Click);
            // 
            // BtnLampRedOff
            // 
            this.BtnLampRedOff.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.BtnLampRedOff.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnLampRedOff.Font = new System.Drawing.Font("微软雅黑", 12.5F);
            this.BtnLampRedOff.ForeColor = System.Drawing.Color.Transparent;
            this.BtnLampRedOff.Location = new System.Drawing.Point(16, 80);
            this.BtnLampRedOff.Name = "BtnLampRedOff";
            this.BtnLampRedOff.Size = new System.Drawing.Size(90, 36);
            this.BtnLampRedOff.TabIndex = 1;
            this.BtnLampRedOff.Text = "关";
            this.BtnLampRedOff.UseVisualStyleBackColor = false;
            this.BtnLampRedOff.Click += new System.EventHandler(this.BtnLampRedOff_Click);
            // 
            // BtnLampRedOn
            // 
            this.BtnLampRedOn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.BtnLampRedOn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnLampRedOn.Font = new System.Drawing.Font("微软雅黑", 12.5F);
            this.BtnLampRedOn.ForeColor = System.Drawing.Color.Transparent;
            this.BtnLampRedOn.Location = new System.Drawing.Point(16, 36);
            this.BtnLampRedOn.Name = "BtnLampRedOn";
            this.BtnLampRedOn.Size = new System.Drawing.Size(90, 36);
            this.BtnLampRedOn.TabIndex = 0;
            this.BtnLampRedOn.Text = "开";
            this.BtnLampRedOn.UseVisualStyleBackColor = false;
            this.BtnLampRedOn.Click += new System.EventHandler(this.BtnLampRedOn_Click);
            // 
            // customGroupBox10
            // 
            this.customGroupBox10.Controls.Add(this.CTextBoxTrayDeviceRfidSn);
            this.customGroupBox10.Controls.Add(this.customLabel48);
            this.customGroupBox10.Controls.Add(this.PicTrayDeviceInRFID);
            this.customGroupBox10.Controls.Add(this.customLabel42);
            this.customGroupBox10.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.customGroupBox10.Location = new System.Drawing.Point(3, 347);
            this.customGroupBox10.Name = "customGroupBox10";
            this.customGroupBox10.Size = new System.Drawing.Size(620, 94);
            this.customGroupBox10.TabIndex = 15;
            this.customGroupBox10.TabStop = false;
            this.customGroupBox10.Text = "RFID 读码器";
            // 
            // CTextBoxTrayDeviceRfidSn
            // 
            this.CTextBoxTrayDeviceRfidSn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.CTextBoxTrayDeviceRfidSn.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CTextBoxTrayDeviceRfidSn.Font = new System.Drawing.Font("微软雅黑", 12.5F);
            this.CTextBoxTrayDeviceRfidSn.ForeColor = System.Drawing.Color.White;
            this.CTextBoxTrayDeviceRfidSn.Location = new System.Drawing.Point(357, 37);
            this.CTextBoxTrayDeviceRfidSn.Multiline = true;
            this.CTextBoxTrayDeviceRfidSn.Name = "CTextBoxTrayDeviceRfidSn";
            this.CTextBoxTrayDeviceRfidSn.ReadOnly = true;
            this.CTextBoxTrayDeviceRfidSn.Size = new System.Drawing.Size(244, 32);
            this.CTextBoxTrayDeviceRfidSn.TabIndex = 12;
            // 
            // customLabel48
            // 
            this.customLabel48.AutoSize = true;
            this.customLabel48.Font = new System.Drawing.Font("微软雅黑", 12.5F);
            this.customLabel48.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(210)))), ((int)(((byte)(210)))));
            this.customLabel48.Location = new System.Drawing.Point(205, 42);
            this.customLabel48.Name = "customLabel48";
            this.customLabel48.Size = new System.Drawing.Size(146, 23);
            this.customLabel48.TabIndex = 11;
            this.customLabel48.Text = "物料托盘序列号：";
            // 
            // PicTrayDeviceInRFID
            // 
            this.PicTrayDeviceInRFID.Image = global::RobotWorkstation.Properties.Resources.SmallDarkGreen;
            this.PicTrayDeviceInRFID.Location = new System.Drawing.Point(147, 43);
            this.PicTrayDeviceInRFID.Name = "PicTrayDeviceInRFID";
            this.PicTrayDeviceInRFID.Size = new System.Drawing.Size(22, 22);
            this.PicTrayDeviceInRFID.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PicTrayDeviceInRFID.TabIndex = 10;
            this.PicTrayDeviceInRFID.TabStop = false;
            // 
            // customLabel42
            // 
            this.customLabel42.AutoSize = true;
            this.customLabel42.Font = new System.Drawing.Font("微软雅黑", 12.5F);
            this.customLabel42.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(210)))), ((int)(((byte)(210)))));
            this.customLabel42.Location = new System.Drawing.Point(25, 43);
            this.customLabel42.Name = "customLabel42";
            this.customLabel42.Size = new System.Drawing.Size(116, 23);
            this.customLabel42.TabIndex = 0;
            this.customLabel42.Text = "物料托盘到位:";
            // 
            // customGroupBox7
            // 
            this.customGroupBox7.Controls.Add(this.ComBoxQRCodeClear);
            this.customGroupBox7.Controls.Add(this.customLabel47);
            this.customGroupBox7.Controls.Add(this.ComBoxQRCodeReadShow);
            this.customGroupBox7.Controls.Add(this.ComBoxQRCodeDisconnect);
            this.customGroupBox7.Controls.Add(this.ComBoxQRCodeConnect);
            this.customGroupBox7.Controls.Add(this.ComBoxQRCodeCom);
            this.customGroupBox7.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.customGroupBox7.Location = new System.Drawing.Point(3, 3);
            this.customGroupBox7.Name = "customGroupBox7";
            this.customGroupBox7.Size = new System.Drawing.Size(620, 338);
            this.customGroupBox7.TabIndex = 14;
            this.customGroupBox7.TabStop = false;
            this.customGroupBox7.Text = "二维码读码器";
            // 
            // ComBoxQRCodeClear
            // 
            this.ComBoxQRCodeClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(74)))), ((int)(((byte)(74)))));
            this.ComBoxQRCodeClear.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ComBoxQRCodeClear.Font = new System.Drawing.Font("微软雅黑", 12.5F);
            this.ComBoxQRCodeClear.ForeColor = System.Drawing.Color.Transparent;
            this.ComBoxQRCodeClear.Location = new System.Drawing.Point(510, 29);
            this.ComBoxQRCodeClear.Name = "ComBoxQRCodeClear";
            this.ComBoxQRCodeClear.Size = new System.Drawing.Size(90, 36);
            this.ComBoxQRCodeClear.TabIndex = 13;
            this.ComBoxQRCodeClear.Text = "清除";
            this.ComBoxQRCodeClear.UseVisualStyleBackColor = false;
            this.ComBoxQRCodeClear.Click += new System.EventHandler(this.ComBoxQRCodeClear_Click);
            // 
            // customLabel47
            // 
            this.customLabel47.AutoSize = true;
            this.customLabel47.Font = new System.Drawing.Font("微软雅黑", 12.5F);
            this.customLabel47.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(210)))), ((int)(((byte)(210)))));
            this.customLabel47.Location = new System.Drawing.Point(25, 36);
            this.customLabel47.Name = "customLabel47";
            this.customLabel47.Size = new System.Drawing.Size(78, 23);
            this.customLabel47.TabIndex = 0;
            this.customLabel47.Text = "端口号：";
            // 
            // ComBoxQRCodeReadShow
            // 
            this.ComBoxQRCodeReadShow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.ComBoxQRCodeReadShow.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ComBoxQRCodeReadShow.Font = new System.Drawing.Font("微软雅黑", 12.5F);
            this.ComBoxQRCodeReadShow.ForeColor = System.Drawing.Color.White;
            this.ComBoxQRCodeReadShow.Location = new System.Drawing.Point(29, 78);
            this.ComBoxQRCodeReadShow.Multiline = true;
            this.ComBoxQRCodeReadShow.Name = "ComBoxQRCodeReadShow";
            this.ComBoxQRCodeReadShow.ReadOnly = true;
            this.ComBoxQRCodeReadShow.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.ComBoxQRCodeReadShow.Size = new System.Drawing.Size(572, 243);
            this.ComBoxQRCodeReadShow.TabIndex = 12;
            // 
            // ComBoxQRCodeDisconnect
            // 
            this.ComBoxQRCodeDisconnect.BackColor = System.Drawing.Color.Red;
            this.ComBoxQRCodeDisconnect.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ComBoxQRCodeDisconnect.Font = new System.Drawing.Font("微软雅黑", 12.5F);
            this.ComBoxQRCodeDisconnect.ForeColor = System.Drawing.Color.Transparent;
            this.ComBoxQRCodeDisconnect.Location = new System.Drawing.Point(385, 29);
            this.ComBoxQRCodeDisconnect.Name = "ComBoxQRCodeDisconnect";
            this.ComBoxQRCodeDisconnect.Size = new System.Drawing.Size(90, 36);
            this.ComBoxQRCodeDisconnect.TabIndex = 11;
            this.ComBoxQRCodeDisconnect.Text = "断开";
            this.ComBoxQRCodeDisconnect.UseVisualStyleBackColor = false;
            this.ComBoxQRCodeDisconnect.EnabledChanged += new System.EventHandler(this.ComBoxQRCodeDisconnect_EnabledChanged);
            this.ComBoxQRCodeDisconnect.Click += new System.EventHandler(this.ComBoxQRCodeDisconnect_Click);
            // 
            // ComBoxQRCodeConnect
            // 
            this.ComBoxQRCodeConnect.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(148)))), ((int)(((byte)(8)))));
            this.ComBoxQRCodeConnect.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ComBoxQRCodeConnect.Font = new System.Drawing.Font("微软雅黑", 12.5F);
            this.ComBoxQRCodeConnect.ForeColor = System.Drawing.Color.Transparent;
            this.ComBoxQRCodeConnect.Location = new System.Drawing.Point(260, 29);
            this.ComBoxQRCodeConnect.Name = "ComBoxQRCodeConnect";
            this.ComBoxQRCodeConnect.Size = new System.Drawing.Size(90, 36);
            this.ComBoxQRCodeConnect.TabIndex = 10;
            this.ComBoxQRCodeConnect.Text = "连接";
            this.ComBoxQRCodeConnect.UseVisualStyleBackColor = false;
            this.ComBoxQRCodeConnect.EnabledChanged += new System.EventHandler(this.ComBoxQRCodeConnect_EnabledChanged);
            this.ComBoxQRCodeConnect.Click += new System.EventHandler(this.ComBoxQRCodeConnect_Click);
            // 
            // ComBoxQRCodeCom
            // 
            this.ComBoxQRCodeCom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.ComBoxQRCodeCom.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ComBoxQRCodeCom.ForeColor = System.Drawing.Color.White;
            this.ComBoxQRCodeCom.FormattingEnabled = true;
            this.ComBoxQRCodeCom.Items.AddRange(new object[] {
            "COM1",
            "COM2",
            "COM3",
            "COM4",
            "COM5",
            "COM6",
            "COM7",
            "COM8",
            "COM9",
            "COM10"});
            this.ComBoxQRCodeCom.Location = new System.Drawing.Point(103, 34);
            this.ComBoxQRCodeCom.Name = "ComBoxQRCodeCom";
            this.ComBoxQRCodeCom.Size = new System.Drawing.Size(121, 29);
            this.ComBoxQRCodeCom.TabIndex = 1;
            this.ComBoxQRCodeCom.SelectedIndexChanged += new System.EventHandler(this.ComBoxQRCodeCom_SelectedIndexChanged);
            // 
            // TimerRobotTestRunAction
            // 
            this.TimerRobotTestRunAction.Tick += new System.EventHandler(this.TimerRobotTestRunAction_Tick);
            // 
            // ManualDebugForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.ClientSize = new System.Drawing.Size(1260, 830);
            this.ControlBox = false;
            this.Controls.Add(this.tabControlManualDebug);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ManualDebugForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ManualDebugForm_FormClosing);
            this.Load += new System.EventHandler(this.ManualDebug_Load);
            this.Shown += new System.EventHandler(this.ManualDebugForm_Shown);
            this.tabControlManualDebug.ResumeLayout(false);
            this.tabPageRobot.ResumeLayout(false);
            this.customGroupBoxRobotGrap.ResumeLayout(false);
            this.customGroupBoxRobotGrap.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicBoxRobotGrapVacuumCheck)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicBoxRobotGrapBackArrive)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicBoxRobotGrapGoArrive)).EndInit();
            this.groupBoxRobot.ResumeLayout(false);
            this.groupBoxRobot.PerformLayout();
            this.CTabControlBorderRobotTestPoints.ResumeLayout(false);
            this.PageRobotTestGlobalPoint.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_RobotGlobalPoint)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRobotMove)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTemperature)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRobotExecut)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRobotAlarm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxServo)).EndInit();
            this.tabPageOthers.ResumeLayout(false);
            this.customGroupBox13.ResumeLayout(false);
            this.customGroupBox13.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicKeyReset)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicKeyStop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicKeyPause)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicKeyRun)).EndInit();
            this.customGroupBox12.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PicBoxEmptySalverDownArrive)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicBoxEmptySalverUpArrive)).EndInit();
            this.customGroupBox11.ResumeLayout(false);
            this.customGroupBox10.ResumeLayout(false);
            this.customGroupBox10.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicTrayDeviceInRFID)).EndInit();
            this.customGroupBox7.ResumeLayout(false);
            this.customGroupBox7.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private CustomTabControl tabControlManualDebug;
        private System.Windows.Forms.TabPage tabPageRobot;
        private CustomGroupBox groupBoxRobot;
        private System.Windows.Forms.PictureBox pictureBoxServo;
        private CustomButton CBttonServoOn;
        private CustomButton CButtonServoOff;
        private CustomLabel customLabel1;
        private System.Windows.Forms.PictureBox pictureBoxRobotAlarm;
        private CustomButton CButtonReset;
        private CustomLabel customLabel2;
        private System.Windows.Forms.PictureBox pictureBoxRobotExecut;
        private CustomButton CButtonRobotExecPause;
        private CustomButton CButtonRobotExecRun;
        private CustomButton CButtonRobotExecStop;
        private System.Windows.Forms.PictureBox pictureBoxRobotMove;
        private CustomLabel customLabel4;
        private System.Windows.Forms.PictureBox pictureBoxTemperature;
        private CustomLabel customLabel3;
        private CustomLabel customLabel5;
        private CustomTextBox CTextBoxJogDistance;
        private CustomLabel customLabel6;
        private CustomLabel customLabel7;
        private CustomTextBox CTextBoxJogDistanceUm;
        private System.Windows.Forms.RadioButton radioButtonRobotDeviceJog;
        private CustomLabel customLabel9;
        private CustomTextBox CTextBoxRobotMoveSpeed;
        private CustomLabel customLabel8;
        private System.Windows.Forms.RadioButton radioButtonRobotDeviceContinuous;
        private CustomButton CButtonRobotDistanceJ1Sub;
        private CustomButton CButtonRobotDistanceJ1Add;
        private CustomTextBox CTextBoxRobotDistanceJ1;
        private CustomLabel customLabel11;
        private CustomButton CButtonRobotDistanceJ3Sub;
        private CustomButton CButtonRobotDistanceJ3Add;
        private CustomTextBox CTextBoxRobotDistanceJ3;
        private CustomLabel customLabel13;
        private CustomButton CButtonRobotDistanceJ2Sub;
        private CustomButton CButtonRobotDistanceJ2Add;
        private CustomTextBox CTextBoxRobotDistanceJ2;
        private CustomLabel customLabel12;
        private CustomButton CButtonRobotDistanceRZSub;
        private CustomButton CButtonRobotDistanceRZAdd;
        private CustomTextBox CTextBoxRobotDistanceRZ;
        private CustomLabel customLabel15;
        private CustomButton CButtonRobotDistanceZSub;
        private CustomButton CButtonRobotDistanceZAdd;
        private CustomTextBox CTextBoxRobotDistanceZ;
        private CustomLabel customLabel16;
        private CustomButton CButtonRobotDistanceYSub;
        private CustomButton CButtonRobotDistanceYAdd;
        private CustomTextBox CTextBoxRobotDistanceY;
        private CustomLabel customLabel17;
        private CustomButton CButtonRobotDistanceXSub;
        private CustomButton CButtonRobotDistanceXAdd;
        private CustomTextBox CTextBoxRobotDistanceX;
        private CustomLabel customLabel18;
        private CustomButton CButtonRobotDistanceJ4Sub;
        private CustomButton CButtonRobotDistanceJ4Add;
        private CustomTextBox CTextBoxRobotDistanceJ4;
        private CustomLabel customLabel14;
        private CustomTabControlBorder CTabControlBorderRobotTestPoints;
        private System.Windows.Forms.TabPage PageRobotTestGlobalPoint;
        private System.Windows.Forms.TabPage PageRobotTestUserFrame;
        private System.Windows.Forms.TabPage PageRobotTestToolFrame;
        private System.Windows.Forms.TabPage PageRobotTestWorkSpace;
        public System.Windows.Forms.DataGridView DGV_RobotGlobalPoint;
        private System.Windows.Forms.DataGridViewTextBoxColumn RobotTestName;
        private System.Windows.Forms.DataGridViewTextBoxColumn RobotTestX;
        private System.Windows.Forms.DataGridViewTextBoxColumn RobotTestY;
        private System.Windows.Forms.DataGridViewTextBoxColumn RobotTestZ;
        private System.Windows.Forms.DataGridViewTextBoxColumn RobotTestRZ;
        private System.Windows.Forms.DataGridViewTextBoxColumn RobotTestHand;
        private System.Windows.Forms.DataGridViewTextBoxColumn RobotTestUserID;
        private System.Windows.Forms.DataGridViewTextBoxColumn RobotTestToolID;
        private System.Windows.Forms.Timer TimerInitRobotGlobalPointDGV;
        private CustomButton CBtnRobotTestReadPoint;
        private CustomLabel customLabel19;
        private CustomButton CBtnRobotTestMoveToPoint;
        private CustomButton CBtnRobotTestTeachPoint;
        private System.Windows.Forms.Timer RefreshTimer;
        private System.Windows.Forms.OpenFileDialog OpenFileDialogMotionControlLoadCfg;
        private System.Windows.Forms.TabPage tabPageOthers;
        private System.Windows.Forms.ComboBox ComBoxRobotActions;
        private CustomButton CBtnRobotTestRunAction;
        private System.Windows.Forms.ComboBox ComBoxQRCodeCom;
        private CustomLabel customLabel47;
        private CustomTextBox ComBoxQRCodeReadShow;
        private CustomButton ComBoxQRCodeDisconnect;
        private CustomButton ComBoxQRCodeConnect;
        private CustomButton ComBoxQRCodeClear;
        private CustomGroupBox customGroupBox7;
        private CustomButton CBtnRobotTestTurnOver;
        private CustomGroupBox customGroupBoxRobotGrap;
        private CustomButton CBtnRobotGrap;
        private CustomButton CBtnRobotGrapBack;
        private CustomButton CBtnRobotGrapGo;
        private System.Windows.Forms.PictureBox PicBoxRobotGrapVacuumCheck;
        private CustomLabel customLabel53;
        private System.Windows.Forms.PictureBox PicBoxRobotGrapBackArrive;
        private CustomLabel CLabelRobotGrapBackArrive;
        private System.Windows.Forms.PictureBox PicBoxRobotGrapGoArrive;
        private CustomLabel CLabelRobotGrapGoArrive;
        private CustomButton CBtnRobotPut;
        private CustomGroupBox customGroupBox10;
        private CustomLabel customLabel42;
        private CustomTextBox CTextBoxTrayDeviceRfidSn;
        private CustomLabel customLabel48;
        private System.Windows.Forms.PictureBox PicTrayDeviceInRFID;
        private CustomGroupBox customGroupBox11;
        private CustomGroupBox customGroupBox13;
        private System.Windows.Forms.PictureBox PicKeyReset;
        private System.Windows.Forms.PictureBox PicKeyStop;
        private System.Windows.Forms.PictureBox PicKeyPause;
        private System.Windows.Forms.PictureBox PicKeyRun;
        private CustomLabel customLabel52;
        private CustomLabel customLabel51;
        private CustomLabel customLabel50;
        private CustomLabel customLabel49;
        private CustomGroupBox customGroupBox12;
        private System.Windows.Forms.PictureBox PicBoxEmptySalverDownArrive;
        private System.Windows.Forms.PictureBox PicBoxEmptySalverUpArrive;
        private CustomButton CButtonIoEmptyPlateUp;
        private CustomButton CButtonIoEmptyPlateDown;
        private CustomButton BtnBeepOff;
        private CustomButton BtnBeepOn;
        private CustomButton BtnLampBlueOff;
        private CustomButton BtnLampBlueOn;
        private CustomButton BtnLampGreenOff;
        private CustomButton BtnLampGreenOn;
        private CustomButton BtnLampOrangeOff;
        private CustomButton BtnLampOrangeOn;
        private CustomButton BtnLampRedOff;
        private CustomButton BtnLampRedOn;
        private System.Windows.Forms.Timer TimerRobotTestRunAction;
    }
}