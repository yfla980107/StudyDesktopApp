﻿
namespace BookRentalShopApp
{
    partial class FrmMemberPopup
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
            this.DgvData = new System.Windows.Forms.DataGridView();
            this.BtnSelect = new MetroFramework.Controls.MetroButton();
            this.BtnCanel = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.DgvData)).BeginInit();
            this.SuspendLayout();
            // 
            // DgvData
            // 
            this.DgvData.AllowUserToAddRows = false;
            this.DgvData.AllowUserToDeleteRows = false;
            this.DgvData.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DgvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvData.Location = new System.Drawing.Point(23, 63);
            this.DgvData.Name = "DgvData";
            this.DgvData.ReadOnly = true;
            this.DgvData.RowTemplate.Height = 23;
            this.DgvData.Size = new System.Drawing.Size(494, 266);
            this.DgvData.TabIndex = 1;
            // 
            // BtnSelect
            // 
            this.BtnSelect.Location = new System.Drawing.Point(393, 343);
            this.BtnSelect.Name = "BtnSelect";
            this.BtnSelect.Size = new System.Drawing.Size(59, 27);
            this.BtnSelect.TabIndex = 2;
            this.BtnSelect.Text = "선택";
            this.BtnSelect.UseSelectable = true;
            this.BtnSelect.Click += new System.EventHandler(this.BtnSelect_Click);
            // 
            // BtnCanel
            // 
            this.BtnCanel.Location = new System.Drawing.Point(458, 343);
            this.BtnCanel.Name = "BtnCanel";
            this.BtnCanel.Size = new System.Drawing.Size(59, 27);
            this.BtnCanel.TabIndex = 2;
            this.BtnCanel.Text = "취소";
            this.BtnCanel.UseSelectable = true;
            this.BtnCanel.Click += new System.EventHandler(this.BtnCanel_Click);
            // 
            // FrmMemberPopup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(540, 390);
            this.ControlBox = false;
            this.Controls.Add(this.BtnCanel);
            this.Controls.Add(this.BtnSelect);
            this.Controls.Add(this.DgvData);
            this.Name = "FrmMemberPopup";
            this.Resizable = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Style = MetroFramework.MetroColorStyle.Pink;
            this.Text = "회원리스트";
            this.Load += new System.EventHandler(this.FrmDivCode_Load);
            this.Resize += new System.EventHandler(this.FrmDivCode_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.DgvData)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView DgvData;
        private MetroFramework.Controls.MetroButton BtnSelect;
        private MetroFramework.Controls.MetroButton BtnCanel;
    }
}