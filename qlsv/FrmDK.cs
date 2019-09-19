using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace qlsv
{
    public partial class FrmDK : Form
    {
        public FrmDK()
        {
            InitializeComponent();
        }

        private void btdangky_Click(object sender, EventArgs e)
        {
            FileStream fs = new FileStream("File.txt", FileMode.Append, FileAccess.Write);
            StreamWriter sw = new StreamWriter(fs);
            if (txtmatkhau1.Text == txtmatkhau2.Text)
            {
                sw.WriteLine(txttendn.Text + '|' + txtmatkhau1.Text+'|'+"nguoidung");
                MessageBox.Show("Đăng ký thành công");
                FrmLogin fl = new FrmLogin();
                this.Close();
                fl.Show();
            }
            else
            {
                MessageBox.Show("Vui lòng nhập lại mật khẩu","thong bao");
            }

            sw.Flush();
            sw.Close();
            fs.Close();
        }
    }
}
