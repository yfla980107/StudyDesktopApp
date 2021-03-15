using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace WinChartApp
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void BtnRegen_Click(object sender, EventArgs e)
        {
            GenNewChart();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            this.Text = "중간고사 성적";
            ChtScore.Titles.Add("중간고사 성적"); // 차트 제목 중간고사 성적으로 변경
            GenNewChart();
        }

        private void GenNewChart()
        {
            Random rand = new Random();
            ChtScore.Series[0].Points.Clear(); // 차트의 ["Score"] == [0]
            for (int i = 0; i < 10; i++)
            {
                // 차트의 score에 데이터를 10~100까지 랜덤함수를 이용하여 점수 추가
                ChtScore.Series[0].Points.Add(rand.Next(10, 100)); 
            }
            ChtScore.Series[0].LegendText = "수학"; // score 범례 수학으로 변경
            ChtScore.Series[0].ChartType = SeriesChartType.Column; // 차트 종류 설정
        }
    }
}
