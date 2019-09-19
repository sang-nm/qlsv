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
    public partial class FrmRPqlsv : Form
    {
        public FrmRPqlsv()
        {
            InitializeComponent();
        }

        private void FormCRreport_Load(object sender, EventArgs e)
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
            crSVtheokhoahoc1 report = new crSVtheokhoahoc1();
            report.SetDataSource((DataTable)dt);
            crystalReportViewer1.ReportSource = report;
        }
    }
}
