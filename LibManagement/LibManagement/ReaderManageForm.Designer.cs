using System;

namespace LibManagement
{
    partial class ReaderManageForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.MaDocGia = new System.Windows.Forms.TextBox();
            this.HoTen = new System.Windows.Forms.TextBox();
            this.GioiTinh = new System.Windows.Forms.ComboBox();
            this.Email = new System.Windows.Forms.TextBox();
            this.NgayLapThe = new System.Windows.Forms.DateTimePicker();
            this.NgayHetHan = new System.Windows.Forms.DateTimePicker();
            this.Them = new System.Windows.Forms.Button();
            this.Sua = new System.Windows.Forms.Button();
            this.Xoa = new System.Windows.Forms.Button();
            this.Thoat = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.CMND = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.SDT = new System.Windows.Forms.TextBox();
            this.GiaHan = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(405, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(276, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "QUẢN LÝ ĐỘC GIẢ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(114, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã độc giả:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(114, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Họ tên:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(114, 173);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Giới tính:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(577, 170);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 25);
            this.label6.TabIndex = 5;
            this.label6.Text = "Email:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(114, 222);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(127, 25);
            this.label7.TabIndex = 6;
            this.label7.Text = "Ngày lập thẻ:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(114, 272);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(134, 25);
            this.label8.TabIndex = 7;
            this.label8.Text = "Ngày hết hạn:";
            // 
            // MaDocGia
            // 
            this.MaDocGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaDocGia.Location = new System.Drawing.Point(266, 61);
            this.MaDocGia.Name = "MaDocGia";
            this.MaDocGia.Size = new System.Drawing.Size(123, 30);
            this.MaDocGia.TabIndex = 8;
            this.MaDocGia.TextChanged += new System.EventHandler(this.MaDocGia_TextChanged);
            // 
            // HoTen
            // 
            this.HoTen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HoTen.Location = new System.Drawing.Point(266, 116);
            this.HoTen.Name = "HoTen";
            this.HoTen.Size = new System.Drawing.Size(231, 30);
            this.HoTen.TabIndex = 9;
            this.HoTen.TextChanged += new System.EventHandler(this.HoTen_TextChanged);
            // 
            // GioiTinh
            // 
            this.GioiTinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GioiTinh.FormattingEnabled = true;
            this.GioiTinh.Items.AddRange(new object[] {
            "Nam",
            "Nữ",
            "Khác"});
            this.GioiTinh.Location = new System.Drawing.Point(266, 170);
            this.GioiTinh.Name = "GioiTinh";
            this.GioiTinh.Size = new System.Drawing.Size(100, 33);
            this.GioiTinh.TabIndex = 10;
            // 
            // Email
            // 
            this.Email.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Email.Location = new System.Drawing.Point(661, 167);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(213, 30);
            this.Email.TabIndex = 11;
            this.Email.TextChanged += new System.EventHandler(this.Email_TextChanged);
            // 
            // NgayLapThe
            // 
            this.NgayLapThe.CustomFormat = "dd/MM/yyyy";
            this.NgayLapThe.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NgayLapThe.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.NgayLapThe.Location = new System.Drawing.Point(266, 222);
            this.NgayLapThe.MinDate = new System.DateTime(2023, 5, 1, 0, 0, 0, 0);
            this.NgayLapThe.Name = "NgayLapThe";
            this.NgayLapThe.Size = new System.Drawing.Size(152, 30);
            this.NgayLapThe.TabIndex = 12;
            this.NgayLapThe.ValueChanged += new System.EventHandler(this.NgayLapThe_ValueChanged);
            // 
            // NgayHetHan
            // 
            this.NgayHetHan.CustomFormat = "dd/MM/yyyy";
            this.NgayHetHan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NgayHetHan.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.NgayHetHan.Location = new System.Drawing.Point(266, 272);
            this.NgayHetHan.MinDate = new System.DateTime(2023, 5, 1, 0, 0, 0, 0);
            this.NgayHetHan.Name = "NgayHetHan";
            this.NgayHetHan.Size = new System.Drawing.Size(152, 30);
            this.NgayHetHan.TabIndex = 13;
            // 
            // Them
            // 
            this.Them.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Them.Location = new System.Drawing.Point(119, 332);
            this.Them.Name = "Them";
            this.Them.Size = new System.Drawing.Size(96, 33);
            this.Them.TabIndex = 14;
            this.Them.Text = "Thêm";
            this.Them.UseVisualStyleBackColor = true;
            this.Them.Click += new System.EventHandler(this.Them_Click);
            // 
            // Sua
            // 
            this.Sua.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Sua.Location = new System.Drawing.Point(307, 332);
            this.Sua.Name = "Sua";
            this.Sua.Size = new System.Drawing.Size(96, 33);
            this.Sua.TabIndex = 15;
            this.Sua.Text = "Sửa";
            this.Sua.UseVisualStyleBackColor = true;
            this.Sua.Click += new System.EventHandler(this.Sua_Click);
            // 
            // Xoa
            // 
            this.Xoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Xoa.Location = new System.Drawing.Point(502, 332);
            this.Xoa.Name = "Xoa";
            this.Xoa.Size = new System.Drawing.Size(96, 33);
            this.Xoa.TabIndex = 16;
            this.Xoa.Text = "Xóa";
            this.Xoa.UseVisualStyleBackColor = true;
            this.Xoa.Click += new System.EventHandler(this.Xoa_Click);
            // 
            // Thoat
            // 
            this.Thoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Thoat.Location = new System.Drawing.Point(864, 332);
            this.Thoat.Name = "Thoat";
            this.Thoat.Size = new System.Drawing.Size(96, 33);
            this.Thoat.TabIndex = 17;
            this.Thoat.Text = "Thoát";
            this.Thoat.UseVisualStyleBackColor = true;
            this.Thoat.Click += new System.EventHandler(this.Thoat_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 391);
            this.dataGridView1.Name = "dataGridView1";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1061, 248);
            this.dataGridView1.TabIndex = 18;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(577, 64);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 25);
            this.label5.TabIndex = 19;
            this.label5.Text = "CMND:";
            // 
            // CMND
            // 
            this.CMND.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CMND.Location = new System.Drawing.Point(661, 61);
            this.CMND.Name = "CMND";
            this.CMND.Size = new System.Drawing.Size(171, 30);
            this.CMND.TabIndex = 20;
            this.CMND.TextChanged += new System.EventHandler(this.CMND_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(577, 119);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(59, 25);
            this.label9.TabIndex = 21;
            this.label9.Text = "SĐT:";
            // 
            // SDT
            // 
            this.SDT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SDT.Location = new System.Drawing.Point(661, 116);
            this.SDT.Name = "SDT";
            this.SDT.Size = new System.Drawing.Size(171, 30);
            this.SDT.TabIndex = 22;
            this.SDT.TextChanged += new System.EventHandler(this.SDT_TextChanged);
            // 
            // GiaHan
            // 
            this.GiaHan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GiaHan.Location = new System.Drawing.Point(689, 332);
            this.GiaHan.Name = "GiaHan";
            this.GiaHan.Size = new System.Drawing.Size(96, 33);
            this.GiaHan.TabIndex = 23;
            this.GiaHan.Text = "Gia hạn";
            this.GiaHan.UseVisualStyleBackColor = true;
            this.GiaHan.Click += new System.EventHandler(this.GiaHan_Click);
            // 
            // ReaderManageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1062, 639);
            this.Controls.Add(this.GiaHan);
            this.Controls.Add(this.SDT);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.CMND);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Thoat);
            this.Controls.Add(this.Xoa);
            this.Controls.Add(this.Sua);
            this.Controls.Add(this.Them);
            this.Controls.Add(this.NgayHetHan);
            this.Controls.Add(this.NgayLapThe);
            this.Controls.Add(this.Email);
            this.Controls.Add(this.GioiTinh);
            this.Controls.Add(this.HoTen);
            this.Controls.Add(this.MaDocGia);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ReaderManageForm";
            this.Text = "ReaderManageForm";
            this.Closed += new System.EventHandler(this.ReaderManageForm_Closed);
            this.Load += new System.EventHandler(this.ReaderManageForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox MaDocGia;
        private System.Windows.Forms.TextBox HoTen;
        private System.Windows.Forms.ComboBox GioiTinh;
        private System.Windows.Forms.TextBox Email;
        private System.Windows.Forms.DateTimePicker NgayLapThe;
        private System.Windows.Forms.DateTimePicker NgayHetHan;
        private System.Windows.Forms.Button Them;
        private System.Windows.Forms.Button Sua;
        private System.Windows.Forms.Button Xoa;
        private System.Windows.Forms.Button Thoat;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox CMND;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox SDT;
        private System.Windows.Forms.Button GiaHan;
    }
}