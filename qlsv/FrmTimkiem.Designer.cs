namespace qlsv
{
    partial class FrmTimkiem
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
            this.label1 = new System.Windows.Forms.Label();
            this.gbthongtin = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_tukhoa = new System.Windows.Forms.TextBox();
            this.bttim = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.maLopDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenLopDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngayBatDauDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngayKetThucDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nhaplopBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetdiem = new qlsv.DataSetdiem();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.tenSVDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maSVDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maLopDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.điểmKỳIDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.điểmKỳIIDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.điểmCuốiKỳDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nhapdiemBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btthoat = new System.Windows.Forms.Button();
            this.gbthongtin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhaplopBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetdiem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhapdiemBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(491, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 34);
            this.label1.TabIndex = 0;
            this.label1.Text = "TÌM KIẾM";
            // 
            // gbthongtin
            // 
            this.gbthongtin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.gbthongtin.Controls.Add(this.btthoat);
            this.gbthongtin.Controls.Add(this.label2);
            this.gbthongtin.Controls.Add(this.txt_tukhoa);
            this.gbthongtin.Controls.Add(this.bttim);
            this.gbthongtin.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbthongtin.Location = new System.Drawing.Point(39, 94);
            this.gbthongtin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbthongtin.Name = "gbthongtin";
            this.gbthongtin.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbthongtin.Size = new System.Drawing.Size(904, 198);
            this.gbthongtin.TabIndex = 1;
            this.gbthongtin.TabStop = false;
            this.gbthongtin.Text = "THÔNG TIN TÌM KIẾM";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(106, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 22);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nhập mã SV";
            // 
            // txt_tukhoa
            // 
            this.txt_tukhoa.Location = new System.Drawing.Point(347, 60);
            this.txt_tukhoa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_tukhoa.Name = "txt_tukhoa";
            this.txt_tukhoa.Size = new System.Drawing.Size(314, 30);
            this.txt_tukhoa.TabIndex = 1;
            // 
            // bttim
            // 
            this.bttim.BackColor = System.Drawing.Color.White;
            this.bttim.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttim.Location = new System.Drawing.Point(110, 135);
            this.bttim.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bttim.Name = "bttim";
            this.bttim.Size = new System.Drawing.Size(142, 35);
            this.bttim.TabIndex = 0;
            this.bttim.Text = "Tìm theo mã";
            this.bttim.UseVisualStyleBackColor = false;
            this.bttim.Click += new System.EventHandler(this.bttim_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maLopDataGridViewTextBoxColumn,
            this.tenLopDataGridViewTextBoxColumn,
            this.ngayBatDauDataGridViewTextBoxColumn,
            this.ngayKetThucDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.nhaplopBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(39, 328);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(640, 101);
            this.dataGridView1.TabIndex = 2;
            // 
            // maLopDataGridViewTextBoxColumn
            // 
            this.maLopDataGridViewTextBoxColumn.DataPropertyName = "Ma lop";
            this.maLopDataGridViewTextBoxColumn.HeaderText = "Ma lop";
            this.maLopDataGridViewTextBoxColumn.Name = "maLopDataGridViewTextBoxColumn";
            this.maLopDataGridViewTextBoxColumn.Width = 149;
            // 
            // tenLopDataGridViewTextBoxColumn
            // 
            this.tenLopDataGridViewTextBoxColumn.DataPropertyName = "Ten lop";
            this.tenLopDataGridViewTextBoxColumn.HeaderText = "Ten lop";
            this.tenLopDataGridViewTextBoxColumn.Name = "tenLopDataGridViewTextBoxColumn";
            this.tenLopDataGridViewTextBoxColumn.Width = 150;
            // 
            // ngayBatDauDataGridViewTextBoxColumn
            // 
            this.ngayBatDauDataGridViewTextBoxColumn.DataPropertyName = "Ngay bat dau";
            this.ngayBatDauDataGridViewTextBoxColumn.HeaderText = "Ngay bat dau";
            this.ngayBatDauDataGridViewTextBoxColumn.Name = "ngayBatDauDataGridViewTextBoxColumn";
            this.ngayBatDauDataGridViewTextBoxColumn.Width = 149;
            // 
            // ngayKetThucDataGridViewTextBoxColumn
            // 
            this.ngayKetThucDataGridViewTextBoxColumn.DataPropertyName = "Ngay ket thuc";
            this.ngayKetThucDataGridViewTextBoxColumn.HeaderText = "Ngay ket thuc";
            this.ngayKetThucDataGridViewTextBoxColumn.Name = "ngayKetThucDataGridViewTextBoxColumn";
            this.ngayKetThucDataGridViewTextBoxColumn.Width = 149;
            // 
            // nhaplopBindingSource
            // 
            this.nhaplopBindingSource.DataMember = "nhaplop";
            this.nhaplopBindingSource.DataSource = this.dataSetdiem;
            // 
            // dataSetdiem
            // 
            this.dataSetdiem.DataSetName = "DataSetdiem";
            this.dataSetdiem.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tenSVDataGridViewTextBoxColumn,
            this.maSVDataGridViewTextBoxColumn,
            this.maLopDataGridViewTextBoxColumn1,
            this.điểmKỳIDataGridViewTextBoxColumn,
            this.điểmKỳIIDataGridViewTextBoxColumn,
            this.điểmCuốiKỳDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.nhapdiemBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(39, 461);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(904, 101);
            this.dataGridView2.TabIndex = 3;
            // 
            // tenSVDataGridViewTextBoxColumn
            // 
            this.tenSVDataGridViewTextBoxColumn.DataPropertyName = "Ten SV";
            this.tenSVDataGridViewTextBoxColumn.HeaderText = "Ten SV";
            this.tenSVDataGridViewTextBoxColumn.Name = "tenSVDataGridViewTextBoxColumn";
            this.tenSVDataGridViewTextBoxColumn.Width = 144;
            // 
            // maSVDataGridViewTextBoxColumn
            // 
            this.maSVDataGridViewTextBoxColumn.DataPropertyName = "Ma SV";
            this.maSVDataGridViewTextBoxColumn.HeaderText = "Ma SV";
            this.maSVDataGridViewTextBoxColumn.Name = "maSVDataGridViewTextBoxColumn";
            this.maSVDataGridViewTextBoxColumn.Width = 143;
            // 
            // maLopDataGridViewTextBoxColumn1
            // 
            this.maLopDataGridViewTextBoxColumn1.DataPropertyName = "Ma Lop";
            this.maLopDataGridViewTextBoxColumn1.HeaderText = "Ma Lop";
            this.maLopDataGridViewTextBoxColumn1.Name = "maLopDataGridViewTextBoxColumn1";
            this.maLopDataGridViewTextBoxColumn1.Width = 144;
            // 
            // điểmKỳIDataGridViewTextBoxColumn
            // 
            this.điểmKỳIDataGridViewTextBoxColumn.DataPropertyName = "Điểm Kỳ I";
            this.điểmKỳIDataGridViewTextBoxColumn.HeaderText = "Điểm Kỳ I";
            this.điểmKỳIDataGridViewTextBoxColumn.Name = "điểmKỳIDataGridViewTextBoxColumn";
            this.điểmKỳIDataGridViewTextBoxColumn.Width = 143;
            // 
            // điểmKỳIIDataGridViewTextBoxColumn
            // 
            this.điểmKỳIIDataGridViewTextBoxColumn.DataPropertyName = "Điểm Kỳ II";
            this.điểmKỳIIDataGridViewTextBoxColumn.HeaderText = "Điểm Kỳ II";
            this.điểmKỳIIDataGridViewTextBoxColumn.Name = "điểmKỳIIDataGridViewTextBoxColumn";
            this.điểmKỳIIDataGridViewTextBoxColumn.Width = 144;
            // 
            // điểmCuốiKỳDataGridViewTextBoxColumn
            // 
            this.điểmCuốiKỳDataGridViewTextBoxColumn.DataPropertyName = "Điểm Cuối Kỳ";
            this.điểmCuốiKỳDataGridViewTextBoxColumn.HeaderText = "Điểm Cuối Kỳ";
            this.điểmCuốiKỳDataGridViewTextBoxColumn.Name = "điểmCuốiKỳDataGridViewTextBoxColumn";
            this.điểmCuốiKỳDataGridViewTextBoxColumn.Width = 143;
            // 
            // nhapdiemBindingSource
            // 
            this.nhapdiemBindingSource.DataMember = "nhapdiem";
            this.nhapdiemBindingSource.DataSource = this.dataSetdiem;
            // 
            // btthoat
            // 
            this.btthoat.Location = new System.Drawing.Point(347, 135);
            this.btthoat.Name = "btthoat";
            this.btthoat.Size = new System.Drawing.Size(111, 35);
            this.btthoat.TabIndex = 3;
            this.btthoat.Text = "Thoát";
            this.btthoat.UseVisualStyleBackColor = true;
            this.btthoat.Click += new System.EventHandler(this.btthoat_Click);
            // 
            // FrmTimkiem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1108, 601);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.gbthongtin);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FrmTimkiem";
            this.Text = "FrmTimkiem";
            this.Load += new System.EventHandler(this.FrmTimkiem_Load);
            this.gbthongtin.ResumeLayout(false);
            this.gbthongtin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhaplopBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetdiem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhapdiemBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbthongtin;
        private System.Windows.Forms.Button bttim;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_tukhoa;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenSVDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maSVDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maLopDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn điểmKỳIDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn điểmKỳIIDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn điểmCuốiKỳDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource nhapdiemBindingSource;
        private DataSetdiem dataSetdiem;
        private System.Windows.Forms.DataGridViewTextBoxColumn maLopDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenLopDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngayBatDauDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngayKetThucDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource nhaplopBindingSource;
        private System.Windows.Forms.Button btthoat;
    }
}