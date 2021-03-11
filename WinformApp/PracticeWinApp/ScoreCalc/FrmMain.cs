using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScoreCalc
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void BtnCalc_Click(object sender, EventArgs e)
        {
            double.TryParse(TxtKorean.Text, out double sum1);
            double.TryParse(TxtMath.Text, out double sum2);
            double.TryParse(TxtEnglish.Text, out double sum3);

            TxtSum.Text = (sum1 + sum2 + sum3).ToString();
            TxtAvg.Text = ((sum1 + sum2 + sum3 / 3).ToString("0.0"));
        }
    }
}
