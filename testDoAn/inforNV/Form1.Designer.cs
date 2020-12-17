
namespace inforNV
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.inforNV = new System.Windows.Forms.DataGridView();
            this.header_maNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.header_hoTenNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.header_chucVu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblMaNV = new System.Windows.Forms.Label();
            this.lblHoTenNV = new System.Windows.Forms.Label();
            this.lblChucVu = new System.Windows.Forms.Label();
            this.txtMaNV = new System.Windows.Forms.TextBox();
            this.txtHoTenNV = new System.Windows.Forms.TextBox();
            this.txtChucVu = new System.Windows.Forms.TextBox();
            this.btnThemNV = new System.Windows.Forms.Button();
            this.btnXoaNV = new System.Windows.Forms.Button();
            this.btnSuaNV = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.inforNV)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView Information NV
            // 
            this.inforNV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.inforNV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.header_maNV,
            this.header_hoTenNV,
            this.header_chucVu});
            this.inforNV.Location = new System.Drawing.Point(0, 170);
            this.inforNV.RowTemplate.Height = 50;
            this.inforNV.Size = new System.Drawing.Size(350,300);
            // 
            // header
            // 
            this.header_maNV.HeaderText = "Mã NV";
            this.header_hoTenNV.HeaderText = "Họ tên NV";
            this.header_chucVu.HeaderText = "Chức vụ";
            // 
            // label MANV
            // 
            this.lblMaNV.AutoSize = true;
            this.lblMaNV.Location = new System.Drawing.Point(23, 20);
            this.lblMaNV.Size = new System.Drawing.Size(38, 15);
            this.lblMaNV.Text = "Mã NV";
            // 
            // label hotenNV
            // 
            this.lblHoTenNV.AutoSize = true;
            this.lblHoTenNV.Location = new System.Drawing.Point(23, 72);
            this.lblHoTenNV.Size = new System.Drawing.Size(38, 15);
            this.lblHoTenNV.Text = "Họ tên NV";
            // 
            // label chucVu
            // 
            this.lblChucVu.AutoSize = true;
            this.lblChucVu.Location = new System.Drawing.Point(23, 128);
            this.lblChucVu.Size = new System.Drawing.Size(38, 15);
            this.lblChucVu.Text = "Chức vụ";
            // 
            // textBox maNV
            // 
            this.txtMaNV.Location = new System.Drawing.Point(141, 17);
            this.txtMaNV.Size = new System.Drawing.Size(202, 23); 
            // 
            // textBox hoTen
            // 
            this.txtHoTenNV.Location = new System.Drawing.Point(141, 69);
            this.txtHoTenNV.Size = new System.Drawing.Size(202, 23);
            // 
            // textBox chucVu
            // 
            this.txtChucVu.Location = new System.Drawing.Point(141, 128);
            this.txtChucVu.Size = new System.Drawing.Size(202, 23);
            // 
            // button Them
            // 
            this.btnThemNV.Location = new System.Drawing.Point(376, 34);
            this.btnThemNV.Size = new System.Drawing.Size(106, 53);
            this.btnThemNV.Text = "Thêm";
            this.btnThemNV.UseVisualStyleBackColor = true;
            // 
            // button Xoa
            // 
            this.btnXoaNV.Location = new System.Drawing.Point(376, 149);
            this.btnXoaNV.Size = new System.Drawing.Size(106, 57);
            this.btnXoaNV.Text = "Xóa";
            this.btnXoaNV.UseVisualStyleBackColor = true;
            // 
            // button Sua
            // 
            this.btnSuaNV.Location = new System.Drawing.Point(376, 275);
            this.btnSuaNV.Size = new System.Drawing.Size(106, 63);
            this.btnSuaNV.Text = "Sửa";
            this.btnSuaNV.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(494, 450);
            this.Controls.Add(this.btnSuaNV);
            this.Controls.Add(this.btnXoaNV);
            this.Controls.Add(this.btnThemNV);
            this.Controls.Add(this.txtChucVu);
            this.Controls.Add(this.txtHoTenNV);
            this.Controls.Add(this.txtMaNV);
            this.Controls.Add(this.lblChucVu);
            this.Controls.Add(this.lblHoTenNV);
            this.Controls.Add(this.lblMaNV);
            this.Controls.Add(this.inforNV);
            this.Text = "Your information";
            ((System.ComponentModel.ISupportInitialize)(this.inforNV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView inforNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn header_maNV, header_hoTenNV, header_chucVu;
        private System.Windows.Forms.Label lblMaNV, lblHoTenNV, lblChucVu;
        private System.Windows.Forms.TextBox txtMaNV, txtHoTenNV, txtChucVu;
        private System.Windows.Forms.Button btnThemNV, btnXoaNV, btnSuaNV;
    }
}

