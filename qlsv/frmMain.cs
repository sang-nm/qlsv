using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace qlsv
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void quanLySVToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmDangky f = new FrmDangky();
            f.MdiParent = this;
            f.Show();
        }

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            f2 = new FrmLogin();
            f2.ShowDialog();
            frmMain_Load(this, null);
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void quanLyLopToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmQLlophoc frmql = new FrmQLlophoc();
            frmql.MdiParent = this;
            frmql.Show();
        }

        private void crystalReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmRPqlsv fcr = new FrmRPqlsv();
            fcr.MdiParent = this;
            fcr.Show();
        }

        private void windowsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmTimkiem ftk = new FrmTimkiem();
            ftk.MdiParent = this;
            ftk.Show();
        }

        private void nhapDiemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Formdiem fdiem = new Formdiem();
            fdiem.MdiParent = this;
            fdiem.Show();
        }

        private void timKiemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmTimkiem ftk = new FrmTimkiem();
            ftk.MdiParent = this;
            ftk.Show();
        }

        private void DKToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmDK fd = new FrmDK();
            fd.MdiParent = this;
            fd.Show();
        }

        FrmLogin f2 = new FrmLogin();
        private void frmMain_Load(object sender, EventArgs e)
        {
            if (f2.dadangnhap == true && f2.quanly == true)
            {
                windowsToolStripMenuItem.Enabled = true;
                nhapLieuToolStripMenuItem.Enabled = true;
                phanQuyenSDToolStripMenuItem.Enabled = true;
                FrmDangky f = new FrmDangky();
                f.MdiParent = this;
                f.Show();
            }
            else if (f2.dadangnhap == true && f2.quanly == false)
            {
                windowsToolStripMenuItem.Enabled = true;
            }
            else
            {
                windowsToolStripMenuItem.Enabled = false;
                nhapLieuToolStripMenuItem.Enabled = false;
                phanQuyenSDToolStripMenuItem.Enabled = false;
            }
                
        }
            
        private void phanQuyenSDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmPhanquyenSD pqsd = new FrmPhanquyenSD();
            pqsd.MdiParent = this;
            pqsd.Show();
        }

        private void cRqllopToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCRnhapdiemSV ndsv = new FrmCRnhapdiemSV();
            ndsv.MdiParent = this;
            ndsv.Show();
        }
    }
}
