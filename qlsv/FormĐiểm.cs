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
    public partial class Formdiem : Form
    {
        public Formdiem()
        {
            InitializeComponent();
        }
        //luu diem
        private void btluu_Click(object sender, EventArgs e)
        {
            FileStream fs = new FileStream("luudiem.txt", FileMode.Append, FileAccess.Write);
            StreamWriter sw = new StreamWriter(fs);
            sw.WriteLine(txt_tensv.Text + '|' + txt_ma.Text + '|' + txt_lop.Text + '|' + txt_diem1.Text + '|' + txt_diem2.Text + '|' + txt_diemcuoi.Text);
            sw.Flush();
            sw.Close();
            fs.Close();
            MessageBox.Show("luu thanh cong");
            load_diem();
            //txt_lop.ResetText();
            txt_ma.ResetText();
            txt_diem1.ResetText();
            txt_diem2.ResetText();
            txt_diemcuoi.ResetText();
        }
        
        //Hien thi ten va ma Sv
        private void bthienthi_Click(object sender, EventArgs e)
        {
            if (txt_lop.Text != "")
            {
                DataSetdiem2.googleDataTable go_dt = new DataSetdiem2.googleDataTable();

                FileStream fs = new FileStream(txt_lop.Text + ".txt", FileMode.Open, FileAccess.Read);
                StreamReader st = new StreamReader(fs);
                string dong = st.ReadLine();
                while (dong != null)
                {
                    string[] arr = dong.Split('|');
                    go_dt.Rows.Add(arr[0], arr[1]);
                    dong = st.ReadLine();
                }
                st.Close();
                dataGridView2.DataSource = go_dt;
                load_diem();
            }
            else
            {
                MessageBox.Show("Nhap ma lop");
            }
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_ma.Text = dataGridView2.SelectedRows[0].Cells[0].Value.ToString();
            txt_tensv.Text = dataGridView2.SelectedRows[0].Cells[1].Value.ToString();
            txt_diem1.ResetText();
            txt_diem2.ResetText();
            txt_diemcuoi.ResetText();
        }


        // load diem
        private void load_diem()
        {
            DataSetdiem.nhapdiemDataTable nd_dt = new DataSetdiem.nhapdiemDataTable();
            nd_dt.Rows.Clear();
            FileStream fs = new FileStream("luudiem.txt", FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);
            string dong = sr.ReadLine();
            while (dong != null)
            {
                string[] arr = dong.Split('|');
                if (txt_lop.Text == arr[2])
                {
                    nd_dt.Rows.Add(arr[0], arr[1], arr[2], arr[3], arr[4], arr[5]);
                }
                dong = sr.ReadLine();
            }
            sr.Close();
            dataGridView1.DataSource = nd_dt;
        }
        //demo load diem
        private void button1_Click(object sender, EventArgs e)
        {
          //  load_diem();
        }

        //xoa diem
        private void btxoa_Click(object sender, EventArgs e)
        {
            FileStream fs = new FileStream("tam.txt", FileMode.Create, FileAccess.Write);
            StreamWriter st = new StreamWriter(fs);

            FileStream fs1 = new FileStream("luudiem.txt", FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs1);
            string dong = sr.ReadLine();
            while (dong != null)
            {
                string[] arr = dong.Split('|');
                if (txt_ma.Text != arr[1])
                {
                   st.WriteLine(arr[0]+'|'+arr[1]+'|'+arr[2]+'|'+arr[3]+'|'+arr[4]+'|'+arr[5]);
                }
                dong = sr.ReadLine();
            }
            sr.Close();
            fs1.Close();
            st.Flush();
            st.Close();
            fs.Close();
            File.Delete("luudiem.txt");
            File.Move("tam.txt", "luudiem.txt");
            load_diem();

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_tensv.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            txt_ma.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            txt_diem1.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            txt_diem2.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            txt_diemcuoi.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
        }

        private void btsua_Click(object sender, EventArgs e)
        {
            FileStream fs = new FileStream("tam.txt", FileMode.Create, FileAccess.Write);
            StreamWriter st = new StreamWriter(fs);

            FileStream fs1 = new FileStream("luudiem.txt", FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs1);
            string dong = sr.ReadLine();
            while (dong != null)
            {
                string[] arr = dong.Split('|');
                if (txt_ma.Text == arr[1])
                {
                    st.WriteLine(txt_tensv.Text + '|' + txt_ma.Text + '|' + txt_lop.Text + '|' + txt_diem1.Text + '|' + txt_diem2.Text + '|' + txt_diemcuoi.Text);
                }
                if (txt_ma.Text != arr[1])
                {
                    st.WriteLine(arr[0] + '|' + arr[1] + '|' + arr[2] + '|' + arr[3] + '|' + arr[4] + '|' + arr[5]);
                }
                dong = sr.ReadLine();
            }
            sr.Close();
            fs1.Close();
            st.Flush();
            st.Close();
            fs.Close();
            File.Delete("luudiem.txt");
            File.Move("tam.txt", "luudiem.txt");
            load_diem();
        }

        private void Formdiem_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}
