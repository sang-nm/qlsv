namespace qlsv
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loginToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DKToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nhapLieuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quanLySVToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quanLyLopToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.crystalReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cRqllopToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nhapDiemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.windowsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timKiemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.phanQuyenSDToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.nhapLieuToolStripMenuItem,
            this.windowsToolStripMenuItem,
            this.phanQuyenSDToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(698, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loginToolStripMenuItem,
            this.DKToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(44, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // loginToolStripMenuItem
            // 
            this.loginToolStripMenuItem.Name = "loginToolStripMenuItem";
            this.loginToolStripMenuItem.Size = new System.Drawing.Size(151, 24);
            this.loginToolStripMenuItem.Text = "Dang nhap";
            this.loginToolStripMenuItem.Click += new System.EventHandler(this.loginToolStripMenuItem_Click);
            // 
            // DKToolStripMenuItem
            // 
            this.DKToolStripMenuItem.Name = "DKToolStripMenuItem";
            this.DKToolStripMenuItem.Size = new System.Drawing.Size(151, 24);
            this.DKToolStripMenuItem.Text = "Dang ky";
            this.DKToolStripMenuItem.Click += new System.EventHandler(this.DKToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(151, 24);
            this.exitToolStripMenuItem.Text = "Thoat";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // nhapLieuToolStripMenuItem
            // 
            this.nhapLieuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quanLySVToolStripMenuItem,
            this.quanLyLopToolStripMenuItem,
            this.crystalReportToolStripMenuItem,
            this.nhapDiemToolStripMenuItem});
            this.nhapLieuToolStripMenuItem.Name = "nhapLieuToolStripMenuItem";
            this.nhapLieuToolStripMenuItem.Size = new System.Drawing.Size(88, 24);
            this.nhapLieuToolStripMenuItem.Text = "Nhap Lieu";
            // 
            // quanLySVToolStripMenuItem
            // 
            this.quanLySVToolStripMenuItem.Name = "quanLySVToolStripMenuItem";
            this.quanLySVToolStripMenuItem.Size = new System.Drawing.Size(175, 24);
            this.quanLySVToolStripMenuItem.Text = "Quan ly SV";
            this.quanLySVToolStripMenuItem.Click += new System.EventHandler(this.quanLySVToolStripMenuItem_Click);
            // 
            // quanLyLopToolStripMenuItem
            // 
            this.quanLyLopToolStripMenuItem.Name = "quanLyLopToolStripMenuItem";
            this.quanLyLopToolStripMenuItem.Size = new System.Drawing.Size(175, 24);
            this.quanLyLopToolStripMenuItem.Text = "Quan ly Lop";
            this.quanLyLopToolStripMenuItem.Click += new System.EventHandler(this.quanLyLopToolStripMenuItem_Click);
            // 
            // crystalReportToolStripMenuItem
            // 
            this.crystalReportToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cRqllopToolStripMenuItem});
            this.crystalReportToolStripMenuItem.Name = "crystalReportToolStripMenuItem";
            this.crystalReportToolStripMenuItem.Size = new System.Drawing.Size(175, 24);
            this.crystalReportToolStripMenuItem.Text = "CRqlsv";
            this.crystalReportToolStripMenuItem.Click += new System.EventHandler(this.crystalReportToolStripMenuItem_Click);
            // 
            // cRqllopToolStripMenuItem
            // 
            this.cRqllopToolStripMenuItem.Name = "cRqllopToolStripMenuItem";
            this.cRqllopToolStripMenuItem.Size = new System.Drawing.Size(180, 24);
            this.cRqllopToolStripMenuItem.Text = "CRnhapdiemSV";
            this.cRqllopToolStripMenuItem.Click += new System.EventHandler(this.cRqllopToolStripMenuItem_Click);
            // 
            // nhapDiemToolStripMenuItem
            // 
            this.nhapDiemToolStripMenuItem.Name = "nhapDiemToolStripMenuItem";
            this.nhapDiemToolStripMenuItem.Size = new System.Drawing.Size(175, 24);
            this.nhapDiemToolStripMenuItem.Text = "Nhap Diem";
            this.nhapDiemToolStripMenuItem.Click += new System.EventHandler(this.nhapDiemToolStripMenuItem_Click);
            // 
            // windowsToolStripMenuItem
            // 
            this.windowsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.timKiemToolStripMenuItem});
            this.windowsToolStripMenuItem.Name = "windowsToolStripMenuItem";
            this.windowsToolStripMenuItem.Size = new System.Drawing.Size(80, 24);
            this.windowsToolStripMenuItem.Text = "Sinh vien";
            this.windowsToolStripMenuItem.Click += new System.EventHandler(this.windowsToolStripMenuItem_Click);
            // 
            // timKiemToolStripMenuItem
            // 
            this.timKiemToolStripMenuItem.Name = "timKiemToolStripMenuItem";
            this.timKiemToolStripMenuItem.Size = new System.Drawing.Size(139, 24);
            this.timKiemToolStripMenuItem.Text = "Tim kiem";
            this.timKiemToolStripMenuItem.Click += new System.EventHandler(this.timKiemToolStripMenuItem_Click);
            // 
            // phanQuyenSDToolStripMenuItem
            // 
            this.phanQuyenSDToolStripMenuItem.Name = "phanQuyenSDToolStripMenuItem";
            this.phanQuyenSDToolStripMenuItem.Size = new System.Drawing.Size(120, 24);
            this.phanQuyenSDToolStripMenuItem.Text = "Phan quyen SD";
            this.phanQuyenSDToolStripMenuItem.Click += new System.EventHandler(this.phanQuyenSDToolStripMenuItem_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(698, 523);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMain";
            this.Text = "frmMain";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loginToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem DKToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nhapLieuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quanLySVToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quanLyLopToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem windowsToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem crystalReportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nhapDiemToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem timKiemToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem phanQuyenSDToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cRqllopToolStripMenuItem;

    }
}