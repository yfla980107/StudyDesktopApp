﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib;

namespace DigitalAlarmClockApp
{
    public partial class FrmAlarm : Form
    {
        private DateTime SetDay;
        private DateTime SetTime;
        private bool IsSetAlarm;
        WindowsMediaPlayer mediaPlayer;

        public FrmAlarm()
        {
            InitializeComponent();

            // 초기화 작업

        }

        private void FrmAlarm_Load(object sender, EventArgs e)
        {
            mediaPlayer = new WindowsMediaPlayer();

            LblAlarm.ForeColor = Color.Gray;

            LblDate.Text = LblTime.Text = ""; // 시작 시 글자를 지워줌

            DtpAlarmTime.Format = DateTimePickerFormat.Custom;
            DtpAlarmTime.CustomFormat = "hh:mm:ss"; // 디자인cs창의 속성 customformat에서도 설정가능
            DtpAlarmTime.ShowUpDown = true;
            

            MyTimer.Interval = 1000; // 1sec 1초 공백 후 시계시작
            MyTimer.Tick += MyTimer_Tick;
            MyTimer.Enabled = true;
            MyTimer.Start();

            TapClock.SelectedTab = TapDigitalClock;
        }

        private void MyTimer_Tick(object sender, EventArgs e)
        {
            DateTime curDate = DateTime.Now;
            LblDate.Text = curDate.ToShortDateString();
            LblTime.Text = curDate.ToString("hh:mm:ss");

            if (IsSetAlarm == true) // 알람 설정이 되었다면
            {
                // 알람시간하고 현재시간 일치하면 알람울림
                if (SetDay == DateTime.Today && 
                    SetTime.Hour == curDate.Hour &&
                    SetTime.Minute == curDate.Minute &&
                    SetTime.Second == curDate.Second)
                {
                    //IsSetAlarm = false; // 알람 설정 종료 , 코드 실행시 알람기록이 그대로 남아있음
                    BtnRelease_Click(sender, e); // 코드 실행시 알람이 울리면 기록이 사라짐
                    mediaPlayer.URL = @".\medias\alarm.mp3";
                    mediaPlayer.controls.play();
                    MessageBox.Show("알람!!", "알람", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void BtnSet_Click(object sender, EventArgs e)
        {
            SetDay = DateTime.Parse(DtpAlarmDate.Text);
            SetTime = DateTime.Parse(DtpAlarmTime.Text);

            LblAlarm.Text = $"Alarm : {SetDay.ToShortDateString()} {SetTime.ToString("hh:mm:ss")}";
            LblAlarm.ForeColor = Color.Red;

            TapClock.SelectedTab = TapDigitalClock;
            IsSetAlarm = true;
        }

        private void BtnRelease_Click(object sender, EventArgs e)
        {
            IsSetAlarm = false;
            LblAlarm.Text = "Alarm : ";
            LblAlarm.ForeColor = Color.Gray;
            TapClock.SelectedTab = TapDigitalClock;
        }
    }
}
