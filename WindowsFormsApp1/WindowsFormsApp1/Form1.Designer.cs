
namespace WindowsFormsApp1
{
    partial class Form1
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
            this.lblNhapSo = new System.Windows.Forms.Label();
            this.lblDayVuaNhap = new System.Windows.Forms.Label();
            this.lblTongCacPT = new System.Windows.Forms.Label();
            this.lblTongChan = new System.Windows.Forms.Label();
            this.lblTongLe = new System.Windows.Forms.Label();
            this.txtNhapSo = new System.Windows.Forms.TextBox();
            this.txtDayVuaNhap = new System.Windows.Forms.TextBox();
            this.txtTongCacPT = new System.Windows.Forms.TextBox();
            this.txtTongChan = new System.Windows.Forms.TextBox();
            this.txtTongLe = new System.Windows.Forms.TextBox();
            this.btnNhap = new System.Windows.Forms.Button();
            this.btnTiepTuc = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.lblNhapDaySoVaTinhTong = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblNhapSo
            // 
            this.lblNhapSo.AutoSize = true;
            this.lblNhapSo.Location = new System.Drawing.Point(107, 119);
            this.lblNhapSo.Name = "lblNhapSo";
            this.lblNhapSo.Size = new System.Drawing.Size(65, 17);
            this.lblNhapSo.TabIndex = 0;
            this.lblNhapSo.Text = "Nhập số:";
            // 
            // lblDayVuaNhap
            // 
            this.lblDayVuaNhap.AutoSize = true;
            this.lblDayVuaNhap.Location = new System.Drawing.Point(107, 176);
            this.lblDayVuaNhap.Name = "lblDayVuaNhap";
            this.lblDayVuaNhap.Size = new System.Drawing.Size(100, 17);
            this.lblDayVuaNhap.TabIndex = 1;
            this.lblDayVuaNhap.Text = "Dãy vừa nhập:";
            // 
            // lblTongCacPT
            // 
            this.lblTongCacPT.AutoSize = true;
            this.lblTongCacPT.Location = new System.Drawing.Point(107, 226);
            this.lblTongCacPT.Name = "lblTongCacPT";
            this.lblTongCacPT.Size = new System.Drawing.Size(187, 17);
            this.lblTongCacPT.TabIndex = 2;
            this.lblTongCacPT.Text = "Tổng các phần tử trong dãy:";
            // 
            // lblTongChan
            // 
            this.lblTongChan.AutoSize = true;
            this.lblTongChan.Location = new System.Drawing.Point(107, 283);
            this.lblTongChan.Name = "lblTongChan";
            this.lblTongChan.Size = new System.Drawing.Size(80, 17);
            this.lblTongChan.TabIndex = 3;
            this.lblTongChan.Text = "Tổng chẵn:";
            // 
            // lblTongLe
            // 
            this.lblTongLe.AutoSize = true;
            this.lblTongLe.Location = new System.Drawing.Point(365, 283);
            this.lblTongLe.Name = "lblTongLe";
            this.lblTongLe.Size = new System.Drawing.Size(60, 17);
            this.lblTongLe.TabIndex = 4;
            this.lblTongLe.Text = "Tổng lẻ:";
            this.lblTongLe.Click += new System.EventHandler(this.lblTongLe_Click);
            // 
            // txtNhapSo
            // 
            this.txtNhapSo.Location = new System.Drawing.Point(207, 114);
            this.txtNhapSo.Name = "txtNhapSo";
            this.txtNhapSo.Size = new System.Drawing.Size(167, 22);
            this.txtNhapSo.TabIndex = 5;
            this.txtNhapSo.Text = "4";
            // 
            // txtDayVuaNhap
            // 
            this.txtDayVuaNhap.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtDayVuaNhap.Location = new System.Drawing.Point(207, 173);
            this.txtDayVuaNhap.Name = "txtDayVuaNhap";
            this.txtDayVuaNhap.Size = new System.Drawing.Size(368, 22);
            this.txtDayVuaNhap.TabIndex = 6;
            this.txtDayVuaNhap.Text = "2  1  3  5  4";
            // 
            // txtTongCacPT
            // 
            this.txtTongCacPT.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtTongCacPT.Location = new System.Drawing.Point(300, 221);
            this.txtTongCacPT.Name = "txtTongCacPT";
            this.txtTongCacPT.Size = new System.Drawing.Size(275, 22);
            this.txtTongCacPT.TabIndex = 7;
            this.txtTongCacPT.Text = "15";
            // 
            // txtTongChan
            // 
            this.txtTongChan.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtTongChan.Location = new System.Drawing.Point(207, 278);
            this.txtTongChan.Name = "txtTongChan";
            this.txtTongChan.Size = new System.Drawing.Size(114, 22);
            this.txtTongChan.TabIndex = 8;
            this.txtTongChan.Text = "9";
            // 
            // txtTongLe
            // 
            this.txtTongLe.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtTongLe.Location = new System.Drawing.Point(446, 278);
            this.txtTongLe.Name = "txtTongLe";
            this.txtTongLe.Size = new System.Drawing.Size(129, 22);
            this.txtTongLe.TabIndex = 9;
            this.txtTongLe.Text = "6";
            // 
            // btnNhap
            // 
            this.btnNhap.Location = new System.Drawing.Point(446, 106);
            this.btnNhap.Name = "btnNhap";
            this.btnNhap.Size = new System.Drawing.Size(129, 38);
            this.btnNhap.TabIndex = 10;
            this.btnNhap.Text = "Nhập";
            this.btnNhap.UseVisualStyleBackColor = true;
            // 
            // btnTiepTuc
            // 
            this.btnTiepTuc.Location = new System.Drawing.Point(219, 348);
            this.btnTiepTuc.Name = "btnTiepTuc";
            this.btnTiepTuc.Size = new System.Drawing.Size(102, 43);
            this.btnTiepTuc.TabIndex = 11;
            this.btnTiepTuc.Text = "Tiếp tục";
            this.btnTiepTuc.UseVisualStyleBackColor = true;
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(461, 348);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(114, 43);
            this.btnThoat.TabIndex = 12;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            // 
            // lblNhapDaySoVaTinhTong
            // 
            this.lblNhapDaySoVaTinhTong.AutoSize = true;
            this.lblNhapDaySoVaTinhTong.Font = new System.Drawing.Font("Times New Roman", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNhapDaySoVaTinhTong.ForeColor = System.Drawing.Color.Red;
            this.lblNhapDaySoVaTinhTong.Location = new System.Drawing.Point(122, 23);
            this.lblNhapDaySoVaTinhTong.Name = "lblNhapDaySoVaTinhTong";
            this.lblNhapDaySoVaTinhTong.Size = new System.Drawing.Size(453, 51);
            this.lblNhapDaySoVaTinhTong.TabIndex = 13;
            this.lblNhapDaySoVaTinhTong.Text = "Nhập dãy số và tính tổng";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblNhapDaySoVaTinhTong);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnTiepTuc);
            this.Controls.Add(this.btnNhap);
            this.Controls.Add(this.txtTongLe);
            this.Controls.Add(this.txtTongChan);
            this.Controls.Add(this.txtTongCacPT);
            this.Controls.Add(this.txtDayVuaNhap);
            this.Controls.Add(this.txtNhapSo);
            this.Controls.Add(this.lblTongLe);
            this.Controls.Add(this.lblTongChan);
            this.Controls.Add(this.lblTongCacPT);
            this.Controls.Add(this.lblDayVuaNhap);
            this.Controls.Add(this.lblNhapSo);
            this.Name = "Form1";
            this.Text = "Nhập dãy số và tính tổng";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNhapSo;
        private System.Windows.Forms.Label lblDayVuaNhap;
        private System.Windows.Forms.Label lblTongCacPT;
        private System.Windows.Forms.Label lblTongChan;
        private System.Windows.Forms.Label lblTongLe;
        private System.Windows.Forms.TextBox txtNhapSo;
        private System.Windows.Forms.TextBox txtDayVuaNhap;
        private System.Windows.Forms.TextBox txtTongCacPT;
        private System.Windows.Forms.TextBox txtTongChan;
        private System.Windows.Forms.TextBox txtTongLe;
        private System.Windows.Forms.Button btnNhap;
        private System.Windows.Forms.Button btnTiepTuc;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Label lblNhapDaySoVaTinhTong;
    }
}

