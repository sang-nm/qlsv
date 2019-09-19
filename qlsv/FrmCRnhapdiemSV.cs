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
    public partial class FrmCRnhapdiemSV : Form
    {
        public FrmCRnhapdiemSV()
        {
            InitializeComponent();
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {
            DataSetdiem.nhapdiemDataTable nd = new DataSetdiem.nhapdiemDataTable();
            StreamReader sr = new StreamReader("luudiem.txt");
            string dong = sr.ReadLine();
            while (dong != null)
            {
                string[] arr = dong.Split('|');
                nd.Rows.Add(arr[0], arr[1], arr[2], arr[3], arr[4], arr[5]);
                dong = sr.ReadLine();
            }
            sr.Close();
            CrystalReportNHAPDIEM crnd = new CrystalReportNHAPDIEM();
            crnd.SetDataSource((DataTable)nd);
            crystalReportViewer1.ReportSource = crnd;
        }
    }
}
