﻿namespace RobotWorkstation
{
    partial class SystemSetingForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SystemSetingForm));
            this.tabControlSystemSeting = new RobotWorkstation.CustomTabControl();
            this.SystemSetPageRobot = new System.Windows.Forms.TabPage();
            this.CTextBoxSysSetRobotIP = new RobotWorkstation.CustomTextBox();
            this.customLabel1 = new RobotWorkstation.CustomLabel();
            this.SystemSetPageCamera = new System.Windows.Forms.TabPage();
            this.SystemSetPageOthers = new System.Windows.Forms.TabPage();
            this.ComBoxSysLanguage = new System.Windows.Forms.ComboBox();
            this.CLabelSysLanguage = new RobotWorkstation.CustomLabel();
            this.tabControlSystemSeting.SuspendLayout();
            this.SystemSetPageRobot.SuspendLayout();
            this.SystemSetPageOthers.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlSystemSeting
            // 
            this.tabControlSystemSeting.Controls.Add(this.SystemSetPageRobot);
            this.tabControlSystemSeting.Controls.Add(this.SystemSetPageCamera);
            this.tabControlSystemSeting.Controls.Add(this.SystemSetPageOthers);
            resources.ApplyResources(this.tabControlSystemSeting, "tabControlSystemSeting");
            this.tabControlSystemSeting.Name = "tabControlSystemSeting";
            this.tabControlSystemSeting.SelectedIndex = 0;
            // 
            // SystemSetPageRobot
            // 
            this.SystemSetPageRobot.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.SystemSetPageRobot.Controls.Add(this.CTextBoxSysSetRobotIP);
            this.SystemSetPageRobot.Controls.Add(this.customLabel1);
            resources.ApplyResources(this.SystemSetPageRobot, "SystemSetPageRobot");
            this.SystemSetPageRobot.ForeColor = System.Drawing.Color.White;
            this.SystemSetPageRobot.Name = "SystemSetPageRobot";
            // 
            // CTextBoxSysSetRobotIP
            // 
            this.CTextBoxSysSetRobotIP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.CTextBoxSysSetRobotIP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            resources.ApplyResources(this.CTextBoxSysSetRobotIP, "CTextBoxSysSetRobotIP");
            this.CTextBoxSysSetRobotIP.ForeColor = System.Drawing.Color.White;
            this.CTextBoxSysSetRobotIP.Name = "CTextBoxSysSetRobotIP";
            this.CTextBoxSysSetRobotIP.TextChanged += new System.EventHandler(this.CTextBoxSysSetRobotIP_TextChanged);
            // 
            // customLabel1
            // 
            resources.ApplyResources(this.customLabel1, "customLabel1");
            this.customLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(210)))), ((int)(((byte)(210)))));
            this.customLabel1.Name = "customLabel1";
            // 
            // SystemSetPageCamera
            // 
            this.SystemSetPageCamera.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            resources.ApplyResources(this.SystemSetPageCamera, "SystemSetPageCamera");
            this.SystemSetPageCamera.ForeColor = System.Drawing.Color.White;
            this.SystemSetPageCamera.Name = "SystemSetPageCamera";
            // 
            // SystemSetPageOthers
            // 
            this.SystemSetPageOthers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.SystemSetPageOthers.Controls.Add(this.ComBoxSysLanguage);
            this.SystemSetPageOthers.Controls.Add(this.CLabelSysLanguage);
            resources.ApplyResources(this.SystemSetPageOthers, "SystemSetPageOthers");
            this.SystemSetPageOthers.ForeColor = System.Drawing.Color.White;
            this.SystemSetPageOthers.Name = "SystemSetPageOthers";
            // 
            // ComBoxSysLanguage
            // 
            this.ComBoxSysLanguage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            resources.ApplyResources(this.ComBoxSysLanguage, "ComBoxSysLanguage");
            this.ComBoxSysLanguage.ForeColor = System.Drawing.Color.White;
            this.ComBoxSysLanguage.FormattingEnabled = true;
            this.ComBoxSysLanguage.Items.AddRange(new object[] {
            resources.GetString("ComBoxSysLanguage.Items"),
            resources.GetString("ComBoxSysLanguage.Items1")});
            this.ComBoxSysLanguage.Name = "ComBoxSysLanguage";
            this.ComBoxSysLanguage.SelectedIndexChanged += new System.EventHandler(this.ComBoxSysLanguage_SelectedIndexChanged);
            // 
            // CLabelSysLanguage
            // 
            resources.ApplyResources(this.CLabelSysLanguage, "CLabelSysLanguage");
            this.CLabelSysLanguage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(210)))), ((int)(((byte)(210)))));
            this.CLabelSysLanguage.Name = "CLabelSysLanguage";
            // 
            // SystemSetingForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.ControlBox = false;
            this.Controls.Add(this.tabControlSystemSeting);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SystemSetingForm";
            this.Load += new System.EventHandler(this.SystemSeting_Load);
            this.tabControlSystemSeting.ResumeLayout(false);
            this.SystemSetPageRobot.ResumeLayout(false);
            this.SystemSetPageRobot.PerformLayout();
            this.SystemSetPageOthers.ResumeLayout(false);
            this.SystemSetPageOthers.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private CustomTabControl tabControlSystemSeting;
        private System.Windows.Forms.TabPage SystemSetPageRobot;
        private System.Windows.Forms.TabPage SystemSetPageCamera;
        private CustomTextBox CTextBoxSysSetRobotIP;
        private CustomLabel customLabel1;
        private System.Windows.Forms.TabPage SystemSetPageOthers;
        private System.Windows.Forms.ComboBox ComBoxSysLanguage;
        private CustomLabel CLabelSysLanguage;
    }
}