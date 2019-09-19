using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
namespace qlsv
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }
        public bool dadangnhap = false;
        public bool quanly = false;
       
        private void btndangnhap_Click(object sender, EventArgs e)
        {
            FileStream fs = new FileStream("File.txt", FileMode.Open, FileAccess.Read);
            StreamReader st = new StreamReader(fs);
            string dong = st.ReadLine();
            string[] arr;
            
            while (dong != null)
            {
                arr = dong.Split('|');
                if (arr[0] == txtuser.Text && arr[1] == txtpass.Text)
                {
                    MessageBox.Show("Dang nhap thanh cong");
                    dadangnhap = true;
                    //FrmDangky f = new FrmDangky();
                    //f.Show
                    if (arr[2] == "quanly" && dadangnhap == true)
                    {
                      quanly  = true;
                    }
                    this.Close();
                }
                dong = st.ReadLine();
            }
            if (dadangnhap == false)
            {
                MessageBox.Show("Đăng nhập lại!", "Lưu ý");
            }
        }


        private void btCancel_Click(object sender, EventArgs e)
        {
            DialogResult thongbao;
            thongbao = (MessageBox.Show("ban co muon thoat??", "chu y", MessageBoxButtons.YesNo, MessageBoxIcon.Warning));
            if (thongbao == DialogResult.Yes)
                this.Close();
        }

        private void txtuser_Validating(object sender, CancelEventArgs e)
        {
            if (txtuser.Text.Trim() == "")
            {
                errorProvider1.SetError(txtuser, "phai nhap User");
                txtuser.Focus();
            }
            else
            {
                errorProvider1.SetError(txtuser, "");
            }
        }

        private void txtpass_Validating(object sender, CancelEventArgs e)
        {
            if (txtpass.Text.Trim() == "")
            {
                errorProvider1.SetError(txtpass, "phai nhap Pass");
                txtpass.Focus();
            }
            else
            {
                errorProvider1.SetError(txtpass, "");
            }


        }


    }
}
