﻿using System;
using System.Drawing;
using System.Net;
using System.Windows.Forms;
using System.IO;

namespace RobotWorkstation
{   
    public partial class MainForm : Form
    {
        //UI
        private LoginForm m_LoginForm = null;
        private RunForm m_RunForm = null;
        private ManualDebugForm m_ManualDebugForm = null;  //手动调试对话框
        private SystemSetingForm m_SystemSetingForm = null;
        private UserLimitsForm m_UserLimitsForm = null;

        //所需模块
        private RobotDevice m_Robot = null;  //机械臂             
        private RFID m_RFID = null;   //RFID      
        private QRCode m_QRCode = null; //二维码
        public static ArmControler m_ArmControler = ArmControler.GetInstance();
        private static MyTcpClient m_MyTcpClientArm = null;
        private static MyTcpClient m_MyTcpClientCamera = null;
        private MyTcpServer m_MyTcpServer = null;
        private SysAlarm m_SysAlarm = SysAlarm.GetInstance();

        //网络共享文件夹
        //private static NetShare m_NetShare = NetShare.GetInstance();
        //private static string m_CreateShare = "CreateShare.bat";

        //防止闪屏
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x02000000;  // Turn on WS_EX_COMPOSITED，将一个窗体的所有子窗口使用双缓冲按照从低到高方式绘制出来。
                return cp;
            }
        }

        public MainForm()
        {
            InitializeComponent();
            InitOtherForm();

            //初始化
            InitWorkStation();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
            CustomColor.InitColor();
            InitWindowSize();
            InitCtrlColor();

            MultiLanguage.LoadLanguage(this, typeof(MainForm));
        }

        public static MyTcpClient GetMyTcpClientArm()
        {
            return m_MyTcpClientArm;
        }

        public static MyTcpClient GetMyTcpClientCamera()
        {
            return m_MyTcpClientCamera;
        }

        public void InitWindowSize()
        {
            //得到屏幕工作区域的参数，比如去除属性任务栏的高度
            int nScreenWidth = Screen.PrimaryScreen.WorkingArea.Width; 
            int nScreenHeight = Screen.PrimaryScreen.WorkingArea.Height;

            //调整主窗体控件
            this.MaximumSize = new Size(nScreenWidth, nScreenHeight);
            this.Width = nScreenWidth;
            this.Height = nScreenHeight;
        }

        public void InitCtrlColor()
        {
            CmdTreeView.BackColor = CustomColor.TreeViewColor;
        }

        //创建其他窗体的实例对象
        public void InitOtherForm()
        {
            m_LoginForm = new LoginForm();
            m_LoginForm.MdiParent = this;

            m_RunForm = new RunForm();
            m_RunForm.MdiParent = this;

            m_ManualDebugForm = new ManualDebugForm();
            m_ManualDebugForm.MdiParent = this;

            m_SystemSetingForm = new SystemSetingForm();
            m_SystemSetingForm.MdiParent = this;

            m_UserLimitsForm = new UserLimitsForm();
            m_UserLimitsForm.MdiParent = this;
        }

        private void CmdTreeView_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            switch (e.Node.Name)
            {
                case "Login":
                    {
                        if (m_RunForm != null)
                            m_RunForm.Hide();

                        if (m_ManualDebugForm != null)
                            m_ManualDebugForm.HideFormAndSaveConfigFile();

                        if (m_SystemSetingForm != null)
                            m_SystemSetingForm.HideFormAndSaveConfigFile();

                        if (m_UserLimitsForm != null)
                            m_UserLimitsForm.Hide();

                        if (m_LoginForm != null)
                        {
                            SplitContainerFromMain.Panel1.Controls.Add(m_LoginForm);
                            m_LoginForm.Dock = DockStyle.Fill;
                            m_LoginForm.Show();
                        }
                    }
                    break;
                case "Run":
                    {
                        if (m_LoginForm != null)
                            m_LoginForm.Hide();

                        if (m_ManualDebugForm != null)
                            m_ManualDebugForm.HideFormAndSaveConfigFile();

                        if (m_SystemSetingForm != null)
                            m_SystemSetingForm.HideFormAndSaveConfigFile();

                        if (m_UserLimitsForm != null)
                            m_UserLimitsForm.Hide();

                        if (m_RunForm != null)
                        {
                            SplitContainerFromMain.Panel1.Controls.Add(m_RunForm);
                            m_RunForm.Dock = DockStyle.Fill;
                            m_RunForm.Show();
                        }
                    }
                    break;
                case "Manual":
                    {
                        if (m_LoginForm != null)
                            m_LoginForm.Hide();

                        if (m_RunForm != null)
                            m_RunForm.Hide();

                        if (m_SystemSetingForm != null)
                            m_SystemSetingForm.HideFormAndSaveConfigFile();

                        if (m_UserLimitsForm != null)
                            m_UserLimitsForm.Hide();

                        if (m_ManualDebugForm != null)
                        {
                            SplitContainerFromMain.Panel1.Controls.Add(m_ManualDebugForm);
                            m_ManualDebugForm.Dock = DockStyle.Fill;
                            m_ManualDebugForm.Show();
                        }
                    }
                    break;
                case "SystemSeting":
                    {
                        if (m_LoginForm != null)
                            m_LoginForm.Hide();

                        if (m_RunForm != null)
                            m_RunForm.Hide();

                        if (m_ManualDebugForm != null)
                            m_ManualDebugForm.HideFormAndSaveConfigFile();

                        if (m_UserLimitsForm != null)
                            m_UserLimitsForm.Hide();

                        if (m_SystemSetingForm != null)
                        {
                            SplitContainerFromMain.Panel1.Controls.Add(m_SystemSetingForm);
                            m_SystemSetingForm.Dock = DockStyle.Fill;
                            m_SystemSetingForm.Show();
                        }
                    }
                    break;
                case "UserLimits":
                    {
                        if (m_LoginForm != null)
                            m_LoginForm.Hide();

                        if (m_RunForm != null)
                            m_RunForm.Hide();

                        if (m_ManualDebugForm != null)
                            m_ManualDebugForm.HideFormAndSaveConfigFile();

                        if (m_SystemSetingForm != null)
                            m_SystemSetingForm.HideFormAndSaveConfigFile();

                        if (m_UserLimitsForm != null)
                        {
                            SplitContainerFromMain.Panel1.Controls.Add(m_UserLimitsForm);
                            m_UserLimitsForm.Dock = DockStyle.Fill;
                            m_UserLimitsForm.Show();
                        }
                    }
                    break;
                case "Exit":
                    {
                        VisualSortingStation.ShouldExit = true;
                        if (m_MyTcpServer != null)
                            m_MyTcpServer.CloseServer();

                        CloseForm();
                    }
                    break;
                default:
                    break;
            }
        }

        private void FormMain_MaximumSizeChanged(object sender, EventArgs e)
        {
            InitWindowSize();
        }

        public void CloseForm()
        {
            if (m_Robot != null)
                m_Robot.Close();

            Profile.SaveConfigFile();
            this.Close();
        }

        public void InitWorkStation()
<<<<<<< HEAD
        {
            DataStruct.InitDataStruct();
            Profile.LoadConfigFile();

            //InitTcp();
            //InitWorkstatiionAndStart();
            InitAndCreateAllThread();  //创建所有线程
        }

        public void InitTcp()
        {
=======
        {
            DataStruct.InitSysStat();
            DataStruct.InitSysStateAlarm();
            Profile.LoadConfigFile();

            InitTcp();
            InitWorkstatiionAndStart();
            int Re = VisualSortingStation.CheckSysAlarm();
            if (Re == 0)
                InitAndCreateAllThread();  //创建所有线程
        }

        public void InitTcp()
        {
>>>>>>> 2e99c703d89de6b5ce7fc31142d09201938502a8
            //和Camera通信
            m_MyTcpClientCamera = new MyTcpClient();
            if (m_MyTcpClientCamera != null)
            {
                IPAddress CameraIp = IPAddress.Parse(Profile.m_Config.CameraIp);
                int CameraPort = Profile.m_Config.CameraPort;
                m_MyTcpClientCamera.CreateConnect(CameraIp, CameraPort);
                if (!m_MyTcpClientCamera.IsConnected)
                {
                    DataStruct.SysStat.Camera = 1;
                    m_SysAlarm.SetAlarm(SysAlarm.Type.Camera, true);
                }
                else
                {
                    DataStruct.SysStat.Camera = 0;
                    m_SysAlarm.SetAlarm(SysAlarm.Type.Camera, false);
                }
            }

            //和单片机通信
<<<<<<< HEAD
            m_ArmControler.Open();
            m_MyTcpClientArm = m_ArmControler.m_MyTcpClient[(int)Board.Conveyor];
            if (!m_MyTcpClientArm.IsConnected)
            {
                DataStruct.SysStat.ARM = 1;
                m_SysAlarm.SetAlarm(SysAlarm.Type.ARM, true);
            }
            else
            {
                DataStruct.SysStat.ARM = 0;
                m_SysAlarm.SetAlarm(SysAlarm.Type.ARM, false);
            }

            //创建Tcp Server
=======
            m_MyTcpClientArm = new MyTcpClient();
            if (m_MyTcpClientArm != null)
            {
                IPAddress ControlIp = IPAddress.Parse(Profile.m_Config.ControlerArmIp);
                int ControlPort = Profile.m_Config.ControlerArmPort;
                m_MyTcpClientArm.CreateConnect(ControlIp, ControlPort);

                if (!m_MyTcpClientArm.IsConnected)
                {
                    DataStruct.SysStat.ARM = 1;
                    m_SysAlarm.SetAlarm(SysAlarm.Type.ARM, true);
                }
                else
                {
                    DataStruct.SysStat.ARM = 0;
                    m_SysAlarm.SetAlarm(SysAlarm.Type.ARM, false);
                }
            }

>>>>>>> 2e99c703d89de6b5ce7fc31142d09201938502a8
            m_MyTcpServer = MyTcpServer.GetInstance();
            if (m_MyTcpServer != null)
            {
                IPAddress ServerIp = IPAddress.Parse(Profile.m_Config.VisualStationServerIp);
                int ServerPort = Profile.m_Config.VisualStationServerPort;
                bool Re = m_MyTcpServer.CreatServer(ServerIp, ServerPort);
                if (!Re)
                {
                    DataStruct.SysStat.Server = 1;
                    m_SysAlarm.SetAlarm(SysAlarm.Type.Server, true);
                }
                else
                {
                    DataStruct.SysStat.Server = 0;
                    m_SysAlarm.SetAlarm(SysAlarm.Type.Server, false);
                }
            }
        }

        public void InitWorkstatiionAndStart()
        {
            //检查共享文件夹是否存在，存在则直接存储文件，不存在则创建共享文件夹
            if (!Directory.Exists(NsfTrayModule.m_FileFolder))
            {
                //Directory.CreateDirectory(NsfTrayModule.m_FileFolder);
                //m_NetShare.CallShareBatFile(m_CreateShare);
                MessageBox.Show("请在D盘创建名为ShareFolder的网络共享文件夹！");
            }

            //Robot
            m_Robot = RobotDevice.GetInstance();  
            bool Re = m_Robot.InitRobot();
            if (!Re)
            {
                DataStruct.SysStat.Robot = 1;
                m_SysAlarm.SetAlarm(SysAlarm.Type.Robot, true);
                MessageBox.Show("机械臂初始化错误！");
            }
            else
            {
                m_Robot.ServoOn();
                //m_Robot.RunSelectedProgram(1);
                m_Robot.m_PointList = m_Robot.GetGlobalPointData();
            }

            //RFID
            m_RFID = RFID.GetInstance();
            Re = m_RFID.Connect(Profile.m_Config.RfidIp);
            if (!Re)
            {
                DataStruct.SysStat.RFID = 1;
                m_SysAlarm.SetAlarm(SysAlarm.Type.RFID, true);
            }
            else
            {
                DataStruct.SysStat.RFID = 0;
                m_SysAlarm.SetAlarm(SysAlarm.Type.RFID, false);
            }

            //二维码
            m_QRCode = QRCode.GetInstance(); 
            string Port = Profile.m_Config.QRCodePort;
            string BandRate = Profile.m_Config.QRCodeBandRate;

            m_QRCode.QRCodeCommunParamInit(Port, BandRate);
            Re = m_QRCode.QRCodeInit();
            if (!Re)
            {
                DataStruct.SysStat.QRCode = 1;
                m_SysAlarm.SetAlarm(SysAlarm.Type.QRCode, true);
            }
            else
            {
                DataStruct.SysStat.QRCode = 0;
                m_SysAlarm.SetAlarm(SysAlarm.Type.QRCode, false);
            }
        }

        public void InitAndCreateAllThread()
        {
            VisualSortingStation.CreateAllThread();
        }
    }
}
