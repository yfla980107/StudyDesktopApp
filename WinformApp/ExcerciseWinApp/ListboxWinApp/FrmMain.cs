using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListboxWinApp
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            // 살기좋은 도시 초기화, 가장 기본적인 리스트박스 아이템 추가
            LsbGoodCity.Items.Add("오스트리아, 빈");
            LsbGoodCity.Items.Add("호주, 멜버른");
            LsbGoodCity.Items.Add("일본, 오사카");
            LsbGoodCity.Items.Add("캐나다, 캘거리");
            LsbGoodCity.Items.Add("호주, 시드니");
            LsbGoodCity.Items.Add("캐나다, 벤쿠버");
            LsbGoodCity.Items.Add("일본, 도쿄");
            LsbGoodCity.Items.Add("캐나다, 토론도");
            LsbGoodCity.Items.Add("덴마크, 코펜하겐");
            LsbGoodCity.Items.Add("호주, 애들레이드");

            //데이터 바인딩 방식중 하나
            List<string> lstCountry = new List<string>() { 
                "미국", "러시아", "중국", "영국", "독일", "프랑스",
                "일본", "이스라엘", "사우디아라비아", "UAE", "스위스"
            };
            LsbHappyCountry.DataSource = lstCountry;
            LsbHappyCountry.SelectedIndex = -1; //리스트로 넣는 값에 대한 리스트박스값 초기화
        }

        private void LsbGdpCountry_SelectedIndexChanged(object sender, EventArgs e)
        {
            // 선택적 값 확인
            //MessageBox.Show(sender.ToString());
            var selItem = sender as ListBox; // as 참조식
            //MessageBox.Show($"{selItem.SelectedIndex.ToString()} / {selItem.SelectedItem}");
            TxtIndexGdp.Text = selItem.SelectedIndex.ToString();
            TxtItemGdp.Text = selItem.SelectedItem == null ? string.Empty : selItem.SelectedItem.ToString();
        }

        private void LsbGoodCity_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selItem = sender as ListBox;
            TxtIndexGood.Text = selItem.SelectedIndex.ToString();
            TxtItemGood.Text = selItem.SelectedItem == null ? string.Empty : selItem.SelectedItem.ToString();
        }

        private void LsbHappyCountry_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selItem = sender as ListBox;
            TxtIndexHappy.Text = selItem.SelectedIndex.ToString();
            TxtItemHappy.Text = selItem.SelectedItem == null ? string.Empty : selItem.SelectedItem.ToString();
        }

        private void BtnInit_Click(object sender, EventArgs e)
        {
            LsbGdpCountry.SelectedIndex = LsbGoodCity.SelectedIndex = LsbHappyCountry.SelectedIndex = -1;
        }
    }
}
