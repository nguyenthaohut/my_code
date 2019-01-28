﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RobotWorkstation
{
    public partial class RunForm : Form
    {
        private SysAlarm m_SysAlarm = SysAlarm.GetInstance();
        private bool[] m_SysAlarmState = new bool[(int)SysAlarm.Type.Max];  //报警状态备份
        private ArmControler m_ArmControler = null;
        private byte[] m_SendMeas = new byte[Message.MessageLength];

        public RunForm()
        {
            InitializeComponent();

            m_ArmControler = ArmControler.GetInstance();

            for (int i = 0; i < (int)SysAlarm.Type.Max; i++)
            {
                m_SysAlarmState[i] = false;
            }

            TimerCheckAllStatus.Start();
        }

        private void RunForm_Load(object sender, EventArgs e)
        {
            MultiLanguage.LoadLanguage(this, typeof(RunForm));
        }

        private void CButtonStart_Click(object sender, EventArgs e)
        {
            WorkStation.ProcessKey(Key.Key_Run);
        }

        private void CButtonPause_Click(object sender, EventArgs e)
        {
            WorkStation.ProcessKey(Key.Key_Pause);
        }

        private void CButtonStop_Click(object sender, EventArgs e)
        {
            WorkStation.ProcessKey(Key.Key_Stop);
        }

        private void CButtonReset_Click(object sender, EventArgs e)
        {
            WorkStation.ProcessKey(Key.Key_Reset);
        }

        private void CButtonClearSysAlarm_Click(object sender, EventArgs e)
        {
            DgvSysAlarm.Rows.Clear();
            m_SysAlarm.ClearAll();
        }

        //监控所有状态
        private void TimerCheckAllStatus_Tick(object sender, EventArgs e)
        {
            //运行指示灯
            PicLedReady.Image = DataStruct.SysStat.Ready ? Properties.Resources.LightBlue : Properties.Resources.DarkBlue;
            PicLedRun.Image = DataStruct.SysStat.Run ? Properties.Resources.LightGreen : Properties.Resources.DarkGreen;
            PicLedAlarm.Image = DataStruct.SysStat.Pause ? Properties.Resources.LightYellow : Properties.Resources.DarkYellow;
            PicLedStop.Image = DataStruct.SysStat.Stop ? Properties.Resources.LightRed : Properties.Resources.DarkRed;

            //设置报警灯的状态
            if (DataStruct.SysStat.Run)
                WorkStation.SetSysAlarmLed(0);
            else if (DataStruct.SysStat.Pause && !DataStruct.SysStat.Stop)
                WorkStation.SetSysAlarmLed(1);
            else if (!DataStruct.SysStat.Pause && DataStruct.SysStat.Stop)
                WorkStation.SetSysAlarmLed(2);
            else if (DataStruct.SysStat.Pause && DataStruct.SysStat.Stop)
                WorkStation.SetSysAlarmLed(3);

            //运行状态更新
            Bitmap bmpGreen = Properties.Resources.SmallGreen;
            Bitmap bmpRed = Properties.Resources.SmallRed;

            PicRobot.Image = DataStruct.SysStat.RobotOk ? bmpGreen : bmpRed;
            PicCamera.Image = DataStruct.SysStat.CameraOk? bmpGreen : bmpRed;
            PicRfid.Image = DataStruct.SysStat.RfidOk ? bmpGreen : bmpRed;
            PicArm.Image = DataStruct.SysStat.ArmControlerOk ? bmpGreen : bmpRed;

            //添加报警信息
            for (int i = 0; i < (int)SysAlarm.Type.Max; i++)
            {
                SysAlarm.StructAlarm data = m_SysAlarm.GetAlarm((SysAlarm.Type)i);
                if (data.IsAlarm)
                {
                    if (!m_SysAlarmState[i])
                    {
                        DgvSysAlarm.Rows.Add(data.ID.ToString(), data.Level.ToString(), data.Informat, data.Solution);
                    }
                }
                m_SysAlarmState[i] = data.IsAlarm;
            }
        }
    }
}
