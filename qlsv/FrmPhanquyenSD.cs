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
    public partial class FrmPhanquyenSD : Form
    {
        public FrmPhanquyenSD()
        {
            InitializeComponent();
        }

        private void LoadAll()
        {
            DataPQND.phanquyenDataTable pq = new DataPQND.phanquyenDataTable();
            StreamReader sr = new StreamReader("File.txt");
            while (!sr.EndOfStream)
            {
                string[] arr = sr.ReadLine().Split('|');
                pq.Rows.Add(arr[0], arr[1], arr[2]);
            }
            sr.Close();
            dataGridView1.DataSource = pq;
        }
           
        
        private void btluu_Click(object sender, EventArgs e)
        {

            FileStream fs = new FileStream("File.txt", FileMode.Create, FileAccess.Write);
            StreamWriter sw = new StreamWriter(fs);
            foreach (DataGridViewRow item in dataGridView1.Rows)
            {
                sw.WriteLine(item.Cells[0].Value + "|" + item.Cells[1].Value + "|" + item.Cells[2].Value);
            }
            sw.Flush();
            sw.Close();
            fs.Close();
            MessageBox.Show("Du lieu luu thanh cong");
        }

        private void FrmPhanquyenSD_Load(object sender, EventArgs e)
        {
            LoadAll();
        }

        private void btdangky_Click(object sender, EventArgs e)
        {
            FrmDK dk = new FrmDK();
            dk.ShowDialog();
        }
    }
}
        