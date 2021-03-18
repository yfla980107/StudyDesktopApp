using MetroFramework.Forms;
using MetroFramework;
using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Collections.Generic;

namespace BookRentalShopApp
{
    public partial class FrmBooksPopup : MetroForm
    {

        #region 전역변수 영역
        public int SelIdx { get; set; }

        public string SelName { get; set; }

        #endregion

        #region 이벤트 영역
        public FrmBooksPopup()
        {
            InitializeComponent();
        }

        private void FrmDivCode_Load(object sender, EventArgs e)
        {
            RefreshData(); // 테이블 조회
        }
        

        private void FrmDivCode_Resize(object sender, EventArgs e)
        {
            
        }
        private void DgvData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
        #endregion

        #region 커스텀 메서드 영역

        private void RefreshData() // 화면 조회
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(Helper.Common.Connstring))
                {
                    if (conn.State == ConnectionState.Closed) conn.Open();

                    var query = @"SELECT b.Idx
                                      ,b.Author
                                      ,d.Division
	                                  ,d.Names as DivName
                                      ,b.Names
                                      ,b.ReleaseDate
                                      ,b.ISBN
                                      ,b.Price
                                      ,b.Descriptions
                                  FROM dbo.bookstbl as b
                                  INNER JOIN dbo.divtbl as d
                                  ON b.Division =  d.Division "; // 210318 Descriptions 컬럼 추가
                    SqlDataAdapter adapter = new SqlDataAdapter(query, conn); // SQL 데이터 소스와 DataSet 간의 연결
                    DataSet ds = new DataSet(); // 메모리상 올라가는 가상의 db
                    adapter.Fill(ds, "bookstbl"); // Fill 메서드를 이용하여 데이터 소스의 데이터를 얻어와 DataSet을 채워줌

                    DgvData.DataSource = ds;
                    DgvData.DataMember = "bookstbl";
                }
            }
            catch (Exception ex)
            {

                MetroMessageBox.Show(this, $"예외발생 : {ex.Message}", "오류", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }

            // 데이터그리드뷰 컬럼 화면에서 안보이게 설정
            var column = DgvData.Columns[2]; //Division 컬럼
            column.Visible = false; // 안보이게 설정

            column = DgvData.Columns[4];
            column.Width = 250;
            column.HeaderText = "도서명";

            column = DgvData.Columns[0]; //Idk

            column.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            DgvData.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

        }

        #endregion

        private void BtnCanel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void BtnSelect_Click(object sender, EventArgs e)
        {
            if (DgvData.SelectedRows.Count == 0)
            {
                MetroMessageBox.Show(this, "데이터를 선택하세요.", "경고",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            SelIdx = (int)DgvData.SelectedRows[0].Cells[0].Value;
            SelName = DgvData.SelectedRows[0].Cells[4].Value.ToString();

            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
