namespace qlsv
{
    partial class FrmPhanquyenSD
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.tênNgườiDùngDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mậtKhẩuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quyềnSDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phanquyenBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataPQND = new qlsv.DataPQND();
            this.btdangky = new System.Windows.Forms.Button();
            this.btluu = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.phanquyenBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataPQND)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tênNgườiDùngDataGridViewTextBoxColumn,
            this.mậtKhẩuDataGridViewTextBoxColumn,
            this.quyềnSDDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.phanquyenBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(45, 152);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(760, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(243, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(329, 27);
            this.label1.TabIndex = 1;
            this.label1.Text = "PHÂN QUYỀN TỚI NGƯỜI SD";
            // 
            // tênNgườiDùngDataGridViewTextBoxColumn
            // 
            this.tênNgườiDùngDataGridViewTextBoxColumn.DataPropertyName = "Tên người dùng";
            this.tênNgườiDùngDataGridViewTextBoxColumn.HeaderText = "Tên người dùng";
            this.tênNgườiDùngDataGridViewTextBoxColumn.Name = "tênNgườiDùngDataGridViewTextBoxColumn";
            this.tênNgườiDùngDataGridViewTextBoxColumn.Width = 239;
            // 
            // mậtKhẩuDataGridViewTextBoxColumn
            // 
            this.mậtKhẩuDataGridViewTextBoxColumn.DataPropertyName = "Mật khẩu";
            this.mậtKhẩuDataGridViewTextBoxColumn.HeaderText = "Mật khẩu";
            this.mậtKhẩuDataGridViewTextBoxColumn.Name = "mậtKhẩuDataGridViewTextBoxColumn";
            this.mậtKhẩuDataGridViewTextBoxColumn.Width = 239;
            // 
            // quyềnSDDataGridViewTextBoxColumn
            // 
            this.quyềnSDDataGridViewTextBoxColumn.DataPropertyName = "Quyền SD";
            this.quyềnSDDataGridViewTextBoxColumn.HeaderText = "Quyền SD";
            this.quyềnSDDataGridViewTextBoxColumn.Name = "quyềnSDDataGridViewTextBoxColumn";
            this.quyềnSDDataGridViewTextBoxColumn.Width = 239;
            // 
            // phanquyenBindingSource
            // 
            this.phanquyenBindingSource.DataMember = "phanquyen";
            this.phanquyenBindingSource.DataSource = this.dataPQND;
            // 
            // dataPQND
            // 
            this.dataPQND.DataSetName = "DataPQND";
            this.dataPQND.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btdangky
            // 
            this.btdangky.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btdangky.Location = new System.Drawing.Point(455, 356);
            this.btdangky.Name = "btdangky";
            this.btdangky.Size = new System.Drawing.Size(117, 32);
            this.btdangky.TabIndex = 2;
            this.btdangky.Text = "Đăng ký";
            this.btdangky.UseVisualStyleBackColor = true;
            this.btdangky.Click += new System.EventHandler(this.btdangky_Click);
            // 
            // btluu
            // 
            this.btluu.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btluu.Location = new System.Drawing.Point(190, 356);
            this.btluu.Name = "btluu";
            this.btluu.Size = new System.Drawing.Size(114, 32);
            this.btluu.TabIndex = 3;
            this.btluu.Text = "Lưu";
            this.btluu.UseVisualStyleBackColor = true;
            this.btluu.Click += new System.EventHandler(this.btluu_Click);
            // 
            // FrmPhanquyenSD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(845, 418);
            this.Controls.Add(this.btluu);
            this.Controls.Add(this.btdangky);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FrmPhanquyenSD";
            this.Text = "FrmPhanquyenSD";
            this.Load += new System.EventHandler(this.FrmPhanquyenSD_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.phanquyenBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataPQND)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn tênNgườiDùngDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mậtKhẩuDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quyềnSDDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource phanquyenBindingSource;
        private DataPQND dataPQND;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btdangky;
        private System.Windows.Forms.Button btluu;
    }
}