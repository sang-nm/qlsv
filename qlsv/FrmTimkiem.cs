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
    public partial class FrmTimkiem : Form
    {
        public FrmTimkiem()
        {
            InitializeComponent();
        }

        private void bttim_Click(object sender, EventArgs e)
        {
            load_lop();
            load_diem();
        }


        //load diem

        private void load_diem()
        {
            DataSetdiem.nhaplopDataTable l_dt = new DataSetdiem.nhaplopDataTable();
            FileStream fs = new FileStream("lop.txt", FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);
            string dong = sr.ReadLine();
            while (dong != null)
            {
                string[] arr = dong.Split('|');
                if (ma_lop == arr[0])
                {
                    l_dt.Rows.Add(arr[0], arr[1], arr[2], arr[3]);
                }
                dong = sr.ReadLine();
            }
            sr.Close();
            fs.Close();
            dataGridView1.DataSource = l_dt;
        }


        string ma_lop;
        //load lop
        private void load_lop()
        {
            DataSetdiem.nhapdiemDataTable n_dt = new DataSetdiem.nhapdiemDataTable();
            FileStream fs1 = new FileStream("luudiem.txt", FileMode.Open, FileAccess.Read);
            StreamReader sr1 = new StreamReader(fs1);
            string dong1 = sr1.ReadLine();
            while (dong1 != null)
            {
                string[] arr = dong1.Split('|');
                if (txt_tukhoa.Text == arr[1])
                {
                    n_dt.Rows.Add(arr[0], arr[1],arr[2], arr[3], arr[4], arr[5]);
                    ma_lop = arr[2];

                }
                dong1 = sr1.ReadLine();
            }
            sr1.Close();
            fs1.Close();
            dataGridView2.DataSource = n_dt;
        }
        private void FrmTimkiem_Load(object sender, EventArgs e)
        {

        }

        private void btthoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       
    }

}

