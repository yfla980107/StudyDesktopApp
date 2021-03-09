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
            double sum;
            double.TryParse(TxtKorean.Text+ TxtMath.Text+ TxtEnglish.Text, out sum);

            double avg = sum / 3;

            TxtSum.Text = ();
            TxtAvg.Text = avg;

        }
    }
}
