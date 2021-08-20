using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void lblTongLe_Click(object sender, EventArgs e)
        {

        }

        int tongchan = 0, tongle = 0, tongdayso = 0;

        private void btnThoat_Click(object sender, EventArgs e)
        {
            // viết 1 cái hàm thoát
            Application.Exit();
        }

        private void btnTiepTuc_Click(object sender, EventArgs e)
        {
            // khi ấn tiếp tục thì các textbox kia phải bị xóa đi trở về như lúc đầu
            txtDayVuaNhap.Text = "";
            txtTongCacPT.Text = "";
            txtTongChan.Text = "";
            txtTongLe.Text = "";
            // nhưng vấn đề phát sinh là xóa đi rồi nhưng n vẫn lưu lại tổng chẵn tổng lẻ và tổng PT
            // Thế nên đặt lại các tổng =0 là đc
            tongchan = 0;
            tongle = 0;
            tongdayso = 0;
        }

        private void btnNhap_Click(object sender, EventArgs e)
        {
          
            //vì trong textbox dữ liệu là kiểu string nên dòng này để ép kiểu về int
            int x = Convert.ToInt32(txtNhapSo.Text);
            // dòng này để in các số ở ô nhập số vào ô dãy số vừa nhập
            txtDayVuaNhap.Text += x.ToString() + " ";
            // cả cái cụm này sẽ hiểu theo kiểu nếu  x chia hết cho 2 ( là số chẵn)
            // thì sẽ được tính vào tongchan sau đó ép kiểu tongchan sang kiểu chuỗi ( .ToString())
            // để hiển thị lên textbox tổng chẵn
            // còn nếu không phải số chẵn thì sẽ tính vào tongle
            // 
            if (x % 2 == 0)
            {
                tongchan += x;
                txtTongChan.Text = tongchan.ToString();
            }
            else
            {
                tongle += x;
                txtTongLe.Text = tongle.ToString();
            }
            //2 dòng này để tính tổng dãy số rồi ép kiểu sang string để hiện lên textbox tổng PT
            tongdayso += x;
            txtTongCacPT.Text = tongdayso.ToString();
            // dòng này xóa đi số vừa nhập ở textbox nhập số
            txtNhapSo.Clear();
        }
    }
}
