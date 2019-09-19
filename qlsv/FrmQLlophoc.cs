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
    public partial class FrmQLlophoc : Form
    {
        public FrmQLlophoc()
        {
            InitializeComponent();
        }
        private void LoadAll()
        {
            DataSet2.QLSVDataTable qddt = new DataSet2.QLSVDataTable();
            FileStream fs = new FileStream("sinhvien.txt", FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);
            string dong = sr.ReadLine();
            while (dong != null)
            {
                string[] arr = dong.Split(';');
                qddt.Rows.Add(arr[0], arr[1]);
                dong = sr.ReadLine();
            }
            sr.Close();
            fs.Close();
            dataGridView1.DataSource = qddt;

        }
        private void btthem_Click(object sender, EventArgs e)
        {
            txtmalop.ResetText();
            txttenlop.ResetText();
            dtbatdau.ResetText();
            dtketthuc.ResetText();
            txtmalop.Focus();
            dtql2.Rows.Clear();
            dataGridView2.DataSource = dtql2;
            btluu.Enabled = true;

        }


        DataSet2.QLSVDataTable dtql2 = new DataSet2.QLSVDataTable();
        private void btphai_Click(object sender, EventArgs e)
        {
            string ma = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            string ten = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();

            dtql2.Rows.Add(ma, ten);
            dataGridView2.DataSource = dtql2;
        }

        private void FrmQLlophoc_Load(object sender, EventArgs e)
        {
            btnView_Click(this, null);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoadAll();
        }

        private void btluu_Click(object sender, EventArgs e)
        {
            FileStream ft = new FileStream("loptemp.txt", FileMode.Create, FileAccess.Write,FileShare.None);
            StreamWriter sw = new StreamWriter(ft);
            StreamReader sr = new StreamReader("lop.txt");
            string line = sr.ReadLine();
            if (line == null)
            {
                sw.WriteLine(txtmalop.Text + '|' + txttenlop.Text + '|' + dtbatdau.Value.ToString("yyyy-MM-dd") + '|' + dtketthuc.Value.ToString("yyyy-MM-dd"));
                sw.Flush();
                sw.Close();
                ft.Close();
                sr.Close();
                FileStream fs = new FileStream(txtmalop.Text + ".txt", FileMode.Create, FileAccess.Write);
                StreamWriter Lsw = new StreamWriter(fs);

                for (int i = 0; i < dataGridView2.Rows.Count - 1; i++)
                {
                    Lsw.WriteLine(dataGridView2.Rows[i].Cells[0].Value + "|" + dataGridView2.Rows[i].Cells[1].Value);
                }
                Lsw.Flush();
                Lsw.Close();
                fs.Close();
                MessageBox.Show("Lưu thành công");
            }
            else
            {
                bool chuaco = true;
                while (line != null)
                {
                    string[] arrl = line.Split('|');
                    if (arrl[0] == txtmalop.Text)
                    {
                        sw.WriteLine(txtmalop.Text + '|' + txttenlop.Text + '|' + dtbatdau.Value.ToString("yyyy-MM-dd") + '|' + dtketthuc.Value.ToString("yyyy-MM-dd"));
                        chuaco = false;
                    }
                    else
                    {
                        sw.WriteLine(line);
                    }
                    line = sr.ReadLine();
                }
                if (chuaco)
                {
                    sw.WriteLine(txtmalop.Text + '|' + txttenlop.Text + '|' + dtbatdau.Value.ToString("yyyy-MM-dd") + '|' + dtketthuc.Value.ToString("yyyy-MM-dd"));
                }
                sw.Flush();
                sw.Close();
                ft.Close();
                sr.Close();

                

                FileStream fs = new FileStream(txtmalop.Text + ".txt", FileMode.Create, FileAccess.Write);
                StreamWriter Lsw = new StreamWriter(fs);

                for (int i = 0; i < dataGridView2.Rows.Count - 1; i++)
                {
                    Lsw.WriteLine(dataGridView2.Rows[i].Cells[0].Value + "|" + dataGridView2.Rows[i].Cells[1].Value);
                }
                Lsw.Flush();
                Lsw.Close();
                fs.Close();
            }
           

            FileStream fs2 = new FileStream("lop.txt", FileMode.Create, FileAccess.Write);
            StreamWriter sw2 = new StreamWriter(fs2);
            StreamReader sr2 = new StreamReader("loptemp.txt");
            string line2 = sr2.ReadLine();
            while (line2 != null)
            {
                sw2.WriteLine(line2);
                line2 = sr2.ReadLine();
            }
            sw2.Flush();
            sw2.Close();
            sr2.Close();
            fs2.Close();
        }

        private void btthoat_Click(object sender, EventArgs e)
        {
            DialogResult thongbao;
            thongbao = (MessageBox.Show("Ban co muon thoat??", "chu y", MessageBoxButtons.YesNo, MessageBoxIcon.Warning));
            if (thongbao == DialogResult.Yes)
                this.Close();
        }

        private void bttrai_Click(object sender, EventArgs e)
        {
            int i = dataGridView2.CurrentCell.RowIndex;
            if (i >= 0)
            {
                dtql2.Rows.RemoveAt(i);
            }
        }
        private void btnView_Click(object sender, EventArgs e)
        {
            DataSet2.ViewDataTable dt2 = new DataSet2.ViewDataTable();
            StreamReader sr = new StreamReader("lop.txt");
            while (!sr.EndOfStream)
            {
                string[] arr = sr.ReadLine().Split('|');
                dt2.Rows.Add(arr[0], arr[1], arr[2], arr[3]);
            }
            dataGridView3.DataSource = dt2;
            sr.Close();
        }

        private void dataGridView3_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dtql2.Rows.Clear();
            string selectC = dataGridView3.SelectedRows[0].Cells[0].Value.ToString();
            StreamReader sr1 = new StreamReader("lop.txt");
            string line = sr1.ReadLine();
            while (line != null)
            {
                string[] arrlop = line.Split('|');
                if (arrlop[0].ToLower() == selectC.ToLower())
                {
                    txtmalop.Text = arrlop[0];
                    txttenlop.Text = arrlop[1];
                    dtbatdau.Value = Convert.ToDateTime(arrlop[2]);
                    dtketthuc.Value = Convert.ToDateTime(arrlop[3]);
                    StreamReader sr2 = new StreamReader(arrlop[0] + ".txt");
                    string line2 = sr2.ReadLine();
                    while (line2 != null)
                    {
                        string[] arrlop2 = line2.Split('|');
                        dtql2.Rows.Add(arrlop2[0], arrlop2[1]);
                        line2 = sr2.ReadLine();
                    }
                    sr2.Close();
                    dataGridView2.DataSource = dtql2;
                    break;
                }
                line = sr1.ReadLine();
            }
            sr1.Close();
        }

        private void btxoa_Click(object sender, EventArgs e)
        {
            FileStream fs = new FileStream("luutam.txt", FileMode.Append, FileAccess.Write);
            StreamWriter sw = new StreamWriter(fs);

            StreamReader st = new StreamReader("lop.txt");
            string dong = st.ReadLine();
            while(dong!= null)
            {
                string[] arr = dong.Split('|');
                if(txtmalop.Text !=arr[0])
                {
                    sw.WriteLine(arr[0] + '|' + arr[1] + '|' + arr[2] + '|' + arr[3]);
                }
                dong = st.ReadLine();
            }
            st.Close();
            sw.Flush();
            sw.Close();
            fs.Close();
            MessageBox.Show("du lieu da xoa");
            File.Delete("lop.txt");
            File.Move("luutam.txt", "lop.txt");
            LoadAll();
            btnView_Click(this, null);
        }
    }
}
