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
    public partial class FrmDangky : Form
    {
        public FrmDangky()
        {
            InitializeComponent();
        }


        private void btluu_Click(object sender, EventArgs e)
        {
            if (validateData() == true)
            {
                string phtien = "";
                if (cmphongmay.Checked)
                    phtien += "phongmay,";
                if (cmthuvien.Checked)
                    phtien += "thuvien,";
                if (cmaychieu.Checked)
                    phtien += "maychieu,";
                phtien = phtien.Substring(0, phtien.Length - 1);

                string gioitinh = "Nam";
                if (rdNu.Checked)
                    gioitinh = "Nu";

                string chuyennganh;
                if (combokhoahoc.SelectedItem.ToString() == "Niit")
                {
                    chuyennganh = comchuyenganh.SelectedItem.ToString();
                }
                else
                {

                    chuyennganh = combokhoahoc.SelectedItem.ToString();
                }
                if (validateData() == true)
                {

                    FileStream fs = new FileStream("sinhvien.txt", FileMode.Append, FileAccess.Write);
                    StreamWriter st = new StreamWriter(fs);
                    st.WriteLine(txtmasv.Text + ";" + txttensv.Text + ";" + dateTimePicker1.Value.ToString("yyyy-MM-dd") + ";" + txtdiachi.Text + ";" + gioitinh + ";" + txtsophone.Text + ";" + combokhoahoc.SelectedItem.ToString() + ";" + chuyennganh + ";" + phtien);
                    st.Flush();
                    st.Close();
                    fs.Close();
                    MessageBox.Show("luu thanh cong");
                    btluu.Enabled = false;
                    LoadAll();
                }
            }

        }
        private bool validateData()
        {
            if (txttensv.Text.Trim() == "")
            {
                MessageBox.Show("Phai nhap ten:");
                txttensv.Focus();
                return false;
            }
            if (txtdiachi.Text.Trim() == "")
            {
                MessageBox.Show("phai nhap dia chi");
                txtdiachi.Focus();
                return false;
            }
            if (txtsophone.Text.Trim() == "")
            {
                MessageBox.Show("Nhap so dien thoai");
                txtsophone.Focus();
                return false;
            }
            if (combokhoahoc.SelectedIndex < 0)
            {
                MessageBox.Show("Phai chon khoa hoc");
                return false;
            }

            return true;
        }



        private void btthoat_Click(object sender, EventArgs e)
        {
            DialogResult thongbao;
            thongbao = (MessageBox.Show("Ban co muon thoat??", "chu y", MessageBoxButtons.YesNo, MessageBoxIcon.Warning));
            if (thongbao == DialogResult.Yes)
                this.Close();
        }

        private void combohoahoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (combokhoahoc.Text == "Niit")
            {
                comchuyenganh.Visible = true;
                lbchuyennganh.Visible = true;
            }
            else
            {
                lbchuyennganh.Visible = false;
                comchuyenganh.Visible = false;
            }
        }

        private void btthemmoi_Click(object sender, EventArgs e)
        {


            txtdiachi.ResetText();
            txtsodt.ResetText();
            txtsophone.ResetText();
            txttensv.ResetText();
            combokhoahoc.ResetText();
            cmaychieu.Checked = false;
            cmphongmay.Checked = false;
            cmthuvien.Checked = false;
            btluu.Enabled = true;
            Form1_Load(this, null);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            validateTen.Visible = false;
            string masv = "SV001";
            if (File.Exists("SinhVien.txt"))
            {
                StreamReader sr = new StreamReader("SinhVien.txt");
                string line = sr.ReadLine();
                string lastLine = line;
                while (line != null)
                {
                    lastLine = line;
                    line = sr.ReadLine();
                }
                sr.Close();

                if (lastLine != null)
                {
                    string[] arrMSV = lastLine.Split(':');
                    int MSV = Convert.ToInt32(arrMSV[0].Substring(2, 3)) + 1;
                    if (MSV >= 1 && MSV <= 9)
                        masv = "SV00" + MSV;
                    else if (MSV <= 99)
                        masv = "SV0" + MSV;
                    else
                        masv = "SV" + MSV;
                }
                else
                {
                    masv = "SV001";
                }
            }
            txtmasv.Text = masv;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void txttensv_Validating(object sender, CancelEventArgs e)
        {
            if (txttensv.Text.Trim() == "")
            {
                errorProvider1.SetError(this.txttensv, "co loi");
                validateTen.Visible = true;
                txttensv.Focus();
            }
            else
            {
                errorProvider1.SetError(this.txttensv, "");
                validateTen.Visible = false;
            }
        }

        private void txtsophone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoadAll();
        }
        private void LoadAll()
        {
            DataSetqlsv.studentDataTable dt = new DataSetqlsv.studentDataTable();
            StreamReader sr = new StreamReader("sinhvien.txt");
            string dong = sr.ReadLine();
            while (dong != null)
            {
                string[] arr = dong.Split(';');
                dt.Rows.Add(arr[0], arr[1], arr[2], arr[3], arr[4], arr[5], arr[6], arr[7], arr[8]);
                dong = sr.ReadLine();
            }
            sr.Close();
            dataGridView1.DataSource = dt;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtmasv.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            txttensv.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            dateTimePicker1.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            txtdiachi.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();

            string gioitinh = "";

            gioitinh = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
            if (gioitinh.Contains("Nam"))
            {
                rdNam.Checked = true;
            }

            else
            {
                rdNu.Checked = true;
            }

            txtsophone.Text = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
            combokhoahoc.SelectedItem = dataGridView1.SelectedRows[0].Cells[6].Value.ToString();

            if (combokhoahoc.SelectedItem.ToString() == "Niit")
            {
                comchuyenganh.SelectedItem = dataGridView1.SelectedRows[0].Cells[7].Value.ToString();
            }


            string phtien = "";

            phtien = dataGridView1.SelectedRows[0].Cells[8].Value.ToString();
            if (phtien.Contains("phongmay"))
            {
                cmphongmay.Checked = true;
            }
            else
            {
                cmphongmay.Checked = false;
            }
            if (phtien.Contains("thuvien"))
            {
                cmthuvien.Checked = true;
            }
            else
            {
                cmthuvien.Checked = false;
            }
            if (phtien.Contains("maychieu"))
            {
                cmaychieu.Checked = true;
            }
            else
            {
                cmaychieu.Checked = false;
            }
        }

        private void txtdiachi_Validating(object sender, CancelEventArgs e)
        {
            if (txtdiachi.Text.Trim() == "")
            {
                errorProvider1.SetError(this.txtdiachi, "Có lỗi");
                txtdiachi.Focus();
            }
            else
            {
                errorProvider1.SetError(this.txtdiachi, "");
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtsophone_Validating(object sender, CancelEventArgs e)
        {
            if (txtsophone.Text.Trim() == "")
            {
                errorProvider1.SetError(this.txtsophone, "Có lỗi");
                txtsophone.Focus();
            }
            else
            {
                errorProvider1.SetError(this.txtsophone, "");
            }
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            FileStream fs = new FileStream("sinhvien.txt", FileMode.Create, FileAccess.Write);
            StreamWriter st = new StreamWriter(fs);
            for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
            {
                string masv = dataGridView1.Rows[i].Cells[0].Value.ToString();
                if (masv != txtmasv.Text)
                {
                    string tensv = dataGridView1.Rows[i].Cells[1].Value.ToString();
                    string ngaysinh = dataGridView1.Rows[i].Cells[2].Value.ToString();
                    string diachi = dataGridView1.Rows[i].Cells[3].Value.ToString();
                    string gioitinh = "";

                    gioitinh = dataGridView1.Rows[i].Cells[4].Value.ToString();
                    if (gioitinh.Contains("Nam"))
                    {
                        rdNam.Checked = true;
                    }

                    else
                    {
                        rdNu.Checked = true;
                    }
                    string sophone = dataGridView1.Rows[i].Cells[5].Value.ToString();
                    string khoahoc = dataGridView1.Rows[i].Cells[6].Value.ToString();
                    comchuyenganh.Items.Add(dataGridView1.Rows[i].Cells[7].Value.ToString());

                    string phtien = "";
                    phtien = dataGridView1.Rows[0].Cells[8].Value.ToString();
                    if (phtien.Contains("phongmay"))
                    {
                        cmphongmay.Checked = true;
                    }
                    else
                    {
                        cmphongmay.Checked = false;
                    }
                    if (phtien.Contains("thuvien"))
                    {
                        cmthuvien.Checked = true;
                    }
                    else
                    {
                        cmthuvien.Checked = false;
                    }
                    if (phtien.Contains("maychieu"))
                    {
                        cmaychieu.Checked = true;
                    }
                    else
                    {
                        cmaychieu.Checked = false;
                    }
                    st.WriteLine(masv + ";" + tensv + ";" + ngaysinh + ";" + diachi + ";" + gioitinh + ";" + sophone + ";" + khoahoc + ";" + comchuyenganh.SelectedItem + ";" + phtien);
                }
            }
            st.Flush();
            st.Close();
            fs.Close();
            MessageBox.Show("Xoa thanh cong");
            LoadAll();
        }

        private void btSua_Click(object sender, EventArgs e)
        {
            FileStream fs = new FileStream("sinhvien.txt", FileMode.Create, FileAccess.Write);
            StreamWriter st = new StreamWriter(fs);
            for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
            {
                string masv = dataGridView1.Rows[i].Cells[0].Value.ToString();
                if (masv != txtmasv.Text)
                {
                    string tensv = dataGridView1.Rows[i].Cells[1].Value.ToString();
                    string ngaysinh = dataGridView1.Rows[i].Cells[2].Value.ToString();
                    string diachi = dataGridView1.Rows[i].Cells[3].Value.ToString();
                    string gioitinh = "";

                    gioitinh = dataGridView1.Rows[i].Cells[4].Value.ToString();
                    if (gioitinh.Contains("Nam"))
                    {
                        rdNam.Checked = true;
                    }

                    else
                    {
                        rdNu.Checked = true;
                    }
                    string sophone = dataGridView1.Rows[i].Cells[5].Value.ToString();
                    string khoahoc = dataGridView1.Rows[i].Cells[6].Value.ToString();
                    comchuyenganh.Items.Add(dataGridView1.Rows[i].Cells[7].Value.ToString());

                    string phtien = "";
                    phtien = dataGridView1.Rows[0].Cells[8].Value.ToString();
                    if (phtien.Contains("phongmay"))
                    {
                        cmphongmay.Checked = true;
                    }
                    else
                    {
                        cmphongmay.Checked = false;
                    }
                    if (phtien.Contains("thuvien"))
                    {
                        cmthuvien.Checked = true;
                    }
                    else
                    {
                        cmthuvien.Checked = false;
                    }
                    if (phtien.Contains("maychieu"))
                    {
                        cmaychieu.Checked = true;
                    }
                    else
                    {
                        cmaychieu.Checked = false;
                    }
                    st.WriteLine(masv + ";" + tensv + ";" + ngaysinh + ";" + diachi + ";" + gioitinh + ";" + sophone + ";" + khoahoc + ";" + comchuyenganh.SelectedItem + ";" + phtien);


                }
                else
                {
                    string phtien = "";
                    if (cmphongmay.Checked)
                        phtien += "phongmay,";
                    if (cmthuvien.Checked)
                        phtien += "thuvien,";
                    if (cmaychieu.Checked)
                        phtien += "maychieu,";
                    phtien = phtien.Substring(0, phtien.Length - 1);

                    string gioitinh = "Nam";
                    if (rdNu.Checked)
                        gioitinh = "Nu";

                    string chuyennganh;
                    if (combokhoahoc.SelectedItem.ToString() == "Niit")
                    {
                        chuyennganh = comchuyenganh.SelectedItem.ToString();
                    }
                    else
                    {

                        chuyennganh = combokhoahoc.SelectedItem.ToString();
                    }

                    st.WriteLine(txtmasv.Text + ";" + txttensv.Text + ";" + dateTimePicker1.Value.ToString("yyyy-MM-dd") + ";" + txtdiachi.Text + ";" + gioitinh + ";" + txtsophone.Text + ";" + combokhoahoc.SelectedItem.ToString() + ";" + chuyennganh + ";" + phtien);


                }

            }
            st.Flush();
            st.Close();
            fs.Close();
            MessageBox.Show("Sua thanh cong");
            LoadAll();
        }
    }
}
