﻿
namespace IoTSensorMonApp
{
    partial class FrmMain
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.파일FToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuLoadFile = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuSaveFile = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.MnuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.시뮬레이션SToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuBeginSimulation = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuEndSimulation = new System.Windows.Forms.ToolStripMenuItem();
            this.LblconnectTime = new System.Windows.Forms.Label();
            this.TxtSensorNum = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.PrbPhotoResistor = new System.Windows.Forms.ProgressBar();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.LsbPhotoResistors = new System.Windows.Forms.ListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.CboSerialPort = new System.Windows.Forms.ComboBox();
            this.BtnConnect = new System.Windows.Forms.Button();
            this.BtnDisconnect = new System.Windows.Forms.Button();
            this.BtnDisplay = new System.Windows.Forms.Button();
            this.ChtPhotoResistors = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.BtnViewAll = new System.Windows.Forms.Button();
            this.BtnZoom = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ChtPhotoResistors)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.파일FToolStripMenuItem,
            this.시뮬레이션SToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(484, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 파일FToolStripMenuItem
            // 
            this.파일FToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MnuLoadFile,
            this.MnuSaveFile,
            this.toolStripMenuItem1,
            this.MnuExit});
            this.파일FToolStripMenuItem.Name = "파일FToolStripMenuItem";
            this.파일FToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.파일FToolStripMenuItem.Text = "파일(&F)";
            // 
            // MnuLoadFile
            // 
            this.MnuLoadFile.Name = "MnuLoadFile";
            this.MnuLoadFile.Size = new System.Drawing.Size(180, 22);
            this.MnuLoadFile.Text = "읽어오기(&O)";
            // 
            // MnuSaveFile
            // 
            this.MnuSaveFile.Name = "MnuSaveFile";
            this.MnuSaveFile.Size = new System.Drawing.Size(180, 22);
            this.MnuSaveFile.Text = "저장하기(&S)";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(177, 6);
            // 
            // MnuExit
            // 
            this.MnuExit.Name = "MnuExit";
            this.MnuExit.Size = new System.Drawing.Size(180, 22);
            this.MnuExit.Text = "종료(&X)";
            this.MnuExit.Click += new System.EventHandler(this.MnuExit_Click);
            // 
            // 시뮬레이션SToolStripMenuItem
            // 
            this.시뮬레이션SToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MnuBeginSimulation,
            this.MnuEndSimulation});
            this.시뮬레이션SToolStripMenuItem.Name = "시뮬레이션SToolStripMenuItem";
            this.시뮬레이션SToolStripMenuItem.Size = new System.Drawing.Size(94, 20);
            this.시뮬레이션SToolStripMenuItem.Text = "시뮬레이션(&S)";
            // 
            // MnuBeginSimulation
            // 
            this.MnuBeginSimulation.Name = "MnuBeginSimulation";
            this.MnuBeginSimulation.Size = new System.Drawing.Size(180, 22);
            this.MnuBeginSimulation.Text = "시작(&B)";
            this.MnuBeginSimulation.Click += new System.EventHandler(this.MnuBeginSimulation_Click);
            // 
            // MnuEndSimulation
            // 
            this.MnuEndSimulation.Name = "MnuEndSimulation";
            this.MnuEndSimulation.Size = new System.Drawing.Size(180, 22);
            this.MnuEndSimulation.Text = "끝(&E)";
            this.MnuEndSimulation.Click += new System.EventHandler(this.MnuEndSimulation_Click);
            // 
            // LblconnectTime
            // 
            this.LblconnectTime.AutoSize = true;
            this.LblconnectTime.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.LblconnectTime.Location = new System.Drawing.Point(15, 38);
            this.LblconnectTime.Name = "LblconnectTime";
            this.LblconnectTime.Size = new System.Drawing.Size(228, 15);
            this.LblconnectTime.TabIndex = 1;
            this.LblconnectTime.Text = "Connection Time : 2021-03-16 10:32:34";
            // 
            // TxtSensorNum
            // 
            this.TxtSensorNum.Location = new System.Drawing.Point(271, 36);
            this.TxtSensorNum.Name = "TxtSensorNum";
            this.TxtSensorNum.ReadOnly = true;
            this.TxtSensorNum.Size = new System.Drawing.Size(76, 21);
            this.TxtSensorNum.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.PrbPhotoResistor);
            this.groupBox1.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.groupBox1.Location = new System.Drawing.Point(12, 63);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(344, 92);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "PhotoResistor";
            // 
            // PrbPhotoResistor
            // 
            this.PrbPhotoResistor.Location = new System.Drawing.Point(12, 32);
            this.PrbPhotoResistor.Maximum = 1023;
            this.PrbPhotoResistor.Name = "PrbPhotoResistor";
            this.PrbPhotoResistor.Size = new System.Drawing.Size(326, 23);
            this.PrbPhotoResistor.TabIndex = 0;
            this.PrbPhotoResistor.Value = 100;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(14, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(303, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "1023";
            // 
            // LsbPhotoResistors
            // 
            this.LsbPhotoResistors.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LsbPhotoResistors.Font = new System.Drawing.Font("맑은 고딕", 9F);
            this.LsbPhotoResistors.FormattingEnabled = true;
            this.LsbPhotoResistors.ItemHeight = 15;
            this.LsbPhotoResistors.Location = new System.Drawing.Point(12, 163);
            this.LsbPhotoResistors.Name = "LsbPhotoResistors";
            this.LsbPhotoResistors.ScrollAlwaysVisible = true;
            this.LsbPhotoResistors.Size = new System.Drawing.Size(344, 107);
            this.LsbPhotoResistors.TabIndex = 4;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.BtnDisplay);
            this.groupBox2.Controls.Add(this.BtnDisconnect);
            this.groupBox2.Controls.Add(this.BtnConnect);
            this.groupBox2.Controls.Add(this.CboSerialPort);
            this.groupBox2.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.groupBox2.Location = new System.Drawing.Point(362, 45);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(110, 227);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Port";
            // 
            // CboSerialPort
            // 
            this.CboSerialPort.FormattingEnabled = true;
            this.CboSerialPort.Location = new System.Drawing.Point(12, 32);
            this.CboSerialPort.Name = "CboSerialPort";
            this.CboSerialPort.Size = new System.Drawing.Size(86, 23);
            this.CboSerialPort.TabIndex = 0;
            // 
            // BtnConnect
            // 
            this.BtnConnect.Location = new System.Drawing.Point(12, 65);
            this.BtnConnect.Name = "BtnConnect";
            this.BtnConnect.Size = new System.Drawing.Size(86, 35);
            this.BtnConnect.TabIndex = 1;
            this.BtnConnect.Text = "Connect";
            this.BtnConnect.UseVisualStyleBackColor = true;
            this.BtnConnect.Click += new System.EventHandler(this.BtnConnect_Click);
            // 
            // BtnDisconnect
            // 
            this.BtnDisconnect.Location = new System.Drawing.Point(12, 105);
            this.BtnDisconnect.Name = "BtnDisconnect";
            this.BtnDisconnect.Size = new System.Drawing.Size(86, 35);
            this.BtnDisconnect.TabIndex = 2;
            this.BtnDisconnect.Text = "Disconnect";
            this.BtnDisconnect.UseVisualStyleBackColor = true;
            this.BtnDisconnect.Click += new System.EventHandler(this.BtnDisconnect_Click);
            // 
            // BtnDisplay
            // 
            this.BtnDisplay.Font = new System.Drawing.Font("맑은 고딕", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.BtnDisplay.Location = new System.Drawing.Point(12, 146);
            this.BtnDisplay.Name = "BtnDisplay";
            this.BtnDisplay.Size = new System.Drawing.Size(86, 75);
            this.BtnDisplay.TabIndex = 3;
            this.BtnDisplay.Text = "COM3";
            this.BtnDisplay.UseVisualStyleBackColor = true;
            // 
            // ChtPhotoResistors
            // 
            chartArea1.Name = "ChartArea1";
            this.ChtPhotoResistors.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.ChtPhotoResistors.Legends.Add(legend1);
            this.ChtPhotoResistors.Location = new System.Drawing.Point(12, 278);
            this.ChtPhotoResistors.Name = "ChtPhotoResistors";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.ChtPhotoResistors.Series.Add(series1);
            this.ChtPhotoResistors.Size = new System.Drawing.Size(462, 285);
            this.ChtPhotoResistors.TabIndex = 6;
            this.ChtPhotoResistors.Text = "chart1";
            // 
            // BtnViewAll
            // 
            this.BtnViewAll.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.BtnViewAll.Location = new System.Drawing.Point(159, 570);
            this.BtnViewAll.Name = "BtnViewAll";
            this.BtnViewAll.Size = new System.Drawing.Size(75, 30);
            this.BtnViewAll.TabIndex = 7;
            this.BtnViewAll.Text = "View All";
            this.BtnViewAll.UseVisualStyleBackColor = true;
            // 
            // BtnZoom
            // 
            this.BtnZoom.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.BtnZoom.Location = new System.Drawing.Point(253, 570);
            this.BtnZoom.Name = "BtnZoom";
            this.BtnZoom.Size = new System.Drawing.Size(75, 30);
            this.BtnZoom.TabIndex = 8;
            this.BtnZoom.Text = "Zoom";
            this.BtnZoom.UseVisualStyleBackColor = true;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 611);
            this.Controls.Add(this.BtnZoom);
            this.Controls.Add(this.BtnViewAll);
            this.Controls.Add(this.ChtPhotoResistors);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.LsbPhotoResistors);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.TxtSensorNum);
            this.Controls.Add(this.LblconnectTime);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "IoT Photoresistor Monitoring";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ChtPhotoResistors)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 파일FToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MnuLoadFile;
        private System.Windows.Forms.ToolStripMenuItem MnuSaveFile;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem MnuExit;
        private System.Windows.Forms.ToolStripMenuItem 시뮬레이션SToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MnuBeginSimulation;
        private System.Windows.Forms.ToolStripMenuItem MnuEndSimulation;
        private System.Windows.Forms.Label LblconnectTime;
        private System.Windows.Forms.TextBox TxtSensorNum;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ProgressBar PrbPhotoResistor;
        private System.Windows.Forms.ListBox LsbPhotoResistors;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button BtnDisplay;
        private System.Windows.Forms.Button BtnDisconnect;
        private System.Windows.Forms.Button BtnConnect;
        private System.Windows.Forms.ComboBox CboSerialPort;
        private System.Windows.Forms.DataVisualization.Charting.Chart ChtPhotoResistors;
        private System.Windows.Forms.Button BtnViewAll;
        private System.Windows.Forms.Button BtnZoom;
    }
}

