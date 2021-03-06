﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotWorkstation
{
    public static class Message
    {
        public const int MessageLength = 32;        //通信协议的消息长度是32字节
        public const int MessageStateIndex = 4;     //状态码的索引是4
        public const int MessageCommandIndex = 5;   //命令吗的索引是5
        public const int MessageSumCheck = MessageLength - 2;

        public const byte MessStartCode  = 0x7e;     //起始同步码
        public const byte MessEndCode    = 0x0d;     //终止同步码
        public const byte MessVID1       = 0x44;     //厂商标识符1 字母‘D’
        public const byte MessVID2       = 0x52;     //厂商标识符2 字母‘R’
        public const byte MessStationCode = 0x53;    //工作站类型，字母'S'
        public const byte MessVer        = 0x01;     //通信协议版本号
        public const byte MessRightState = 0x01;     //状态码，发送时初始为0x01，正确返回为0x01，错误返回为0x81
        public const byte MessErrorState = 0x81;

        //Robot相关
        public const byte MessRobotVID1  = 0x54;     //台达：‘T’
        public const byte MessRobotVID2  = 0x44;     //台达：‘D’
        public const byte MessRobotAxle4 = 0x04;     //4轴机械臂
        public const byte MessRobotAxle6 = 0x06;     //6轴机械臂
        public const byte MessRobotAddr  = 0x01;     //机械臂地址

        public enum MessageCodePLC
        {
            GetCurStationState = 0x10,
        }

        public enum MessageCodeCamera  //与相机之间的指令
        {
            GetCameraCoords = 0x90,
        }

        public static bool CheckRobotMessage(short[] message, int MessageLength)
        {
            bool Re = false;

            if ((message[0] == Message.MessStartCode) && (message[MessageLength - 1] == Message.MessEndCode)
                && (message[1] == Message.MessRobotVID1) && (message[2] == Message.MessRobotVID2) && (message[3] == Message.MessRobotAxle6) && (message[4] == Message.MessRobotAddr))

            {
                Re = true;
            }

            return Re;
        }

        public static void MakeSendArrayByCode(byte Code, ref byte[] SendMeas)
        {
            Array.Clear(SendMeas, 0, SendMeas.Length);

            if (SendMeas.Length >= Message.MessageLength)
            {
                SendMeas[0] = Message.MessStartCode;
                SendMeas[1] = Message.MessVID1;
                SendMeas[2] = Message.MessVID2;
                SendMeas[3] = Message.MessVer;
                SendMeas[Message.MessageStateIndex] = Message.MessRightState;
                SendMeas[Message.MessageCommandIndex] = Code;

                //其余位填充0x00
                for (int i = Message.MessageCommandIndex + 1; i < Message.MessageLength - 1; i++)
                    SendMeas[i] = 0x00;

                SendMeas[Message.MessageLength - 1] = Message.MessEndCode;

                byte Sum = 0;
                foreach (byte Temp in SendMeas)
                    Sum += Temp;

                SendMeas[Message.MessageSumCheck] = (byte)(0 - Sum);  //校验和
            }
        }
    }
}
